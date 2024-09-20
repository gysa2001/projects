#!/bin/bash
#Function definitions
LoginToOpennebula(){
   echo -e -n "\033[0;37mUsername: " && read U_NAME
   echo -e -n "\033[0;37mPassword: " && read -s PASSW
   oneuser login --user $U_NAME --password $PASSW  --force --endpoint $URL >/dev/null 2>&1
}

Open_Ports(){
   if [ "$1" == "webserver" ];then
      echo "TCP_PORT_FORWARDING=\"22 80"\">port.txt
      onevm update $VM_ID -a port.txt --user $U_NAME --password $PASSW --endpoint $URL
   elif [ "$1" == "dbserver" ];then
      echo "TCP_PORT_FORWARDING=\"22 3306"\">port.txt
      onevm update $VM_ID -a port.txt --user $U_NAME --password $PASSW --endpoint $URL
   elif [ "$1" == "client" ];then
      echo "TCP_PORT_FORWARDING=\"22 3389"\">port.txt
      onevm update $VM_ID -a port.txt --user $U_NAME --password $PASSW --endpoint $URL
   fi
}

CreateVM(){
   echo -e "\033[0mConnecting to OpenNebula:"
   if LoginToOpennebula; then
       echo -n ""
   else
       echo -e "\033[1;31m\nWrong username or password! Try again!\n"
       LoginToOpennebula
   fi
   eval ${1}_admin=$U_NAME
   echo -e "\033[0;32m\nCreating..."
   {
   onetemplate clone $TEMPLATE "temp_copy" --user $U_NAME --password $PASSW --endpoint $URL
   echo -e "DISK=[SIZE=\"20480\",IMAGE=\"$TEMPLATE\",IMAGE_UNAME=\"oneadmin\"]\n
   CPU=\"0.3\"\nMEMORY=\"3072\"">conf.txt

   onetemplate update "temp_copy" -a conf.txt --user $U_NAME --password $PASSW --endpoint $URL

   RESULT=$(onetemplate instantiate "temp_copy" --hold --name "$1-vm" --user $U_NAME --password $PASSW --endpoin $URL)
   VM_ID=$(echo $RESULT | cut -d ' ' -f 3)
   onetemplate delete "temp_copy" --user $U_NAME --password $PASSW --endpoint $URL
   Open_Ports $1
   onevm release $VM_ID --user $U_NAME --password $PASSW --endpoint $URL
   sleep 60

   onevm show $VM_ID --user $U_NAME --password $PASSW --endpoint $URL >$VM_ID.txt

   VM_PASS=$(cat $VM_ID.txt | grep USER\_PASSWORD | cut -d '=' -f 2 | tr -d '",')
   PRV_IP=$(cat $VM_ID.txt | grep PRIVATE\_IP | cut -d '=' -f 2 | tr -d '"')

   echo -e "[$1]\n$PRV_IP">> /etc/ansible/hosts
   echo -e "${1}_ip: $PRV_IP" >>~/some_vars.yml

   sshpass -p "$VM_PASS" ssh-copy-id -o StrictHostKeyChecking=no $U_NAME@$PRV_IP
   ssh $U_NAME@$PRV_IP "echo -e '$VM_PASS\n%sudo   ALL=(ALL) NOPASSWD:ALL' | sudo -S tee -a /etc/sudoers"
   rm $VM_ID.txt port.txt conf.txt
   }>/dev/null 2>&1
   echo -e "\033[1;32mCreated."
}

Configure_VMS(){
   ansible-playbook -u $dbserver_admin  dbserver.yml
   ansible-playbook -u $webserver_admin webserver.yml
   ansible-playbook -u $client_admin client.yml
}>/dev/null 2>&1
###Commands start here
echo -e "\033[1;31m!!!This script creates 3 virtual mashines\n"
URL="https://grid5.mif.vu.lt/cloud3/RPC2"
TEMPLATE="ubuntu-20.04"
ssh-keygen -q -t rsa -N '' -f ~/.ssh/id_rsa <<<y >/dev/null 2>&1
echo -n "" >/etc/ansible/hosts
echo -n "" >~/.ssh/known_hosts

#Here you can change information about the database
echo "---
db_user_name: \"user\"
db_user_password: \"inception\"
db_name: \"call_center\"" >~/some_vars.yml

echo -e "\033[1;37m(4/1) VM for database server: "
CreateVM "dbserver"
echo -e "\033[1;37m\n(4/2) VM for web server: "
CreateVM "webserver"
echo -e "\033[1;37m\n(4/3) VM for client: "
CreateVM "client"
echo -e "\033[1;37m(4/4) Configuring all VM's...\n"
Configure_VMS
rm ~/some_vars.yml
echo -e "\033[1;92m\nIt's Done! Now you can check your website!"


