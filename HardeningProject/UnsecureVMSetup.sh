################# Unsecure virtual machine setup #################
# root passwrod: "admin"

#!/bin/bash
yes y | sudo apt-get  update
yes y | sudo apt-get upgrade

yes y | sudo apt-get install apache2 php php-mysql libapache2-mod-php php-curl php-gd php-mbstring php-xml php-xmlrpc gnupg

#Install MySQL server version 5.7
wget https://dev.mysql.com/get/mysql-apt-config_0.8.12-1_all.deb
sudo dpkg -i mysql-apt-config_0.8.12-1_all.deb    # Choose the Ubuntu Bionic. And then select the MySQL Server & Cluster option. After that, choose mysql-5.7 and then select ok.
sudo apt-get update
sudo apt-key adv --keyserver keyserver.ubuntu.com --recv-keys 467B942D3A79BD29
sudo apt-get update
sudo apt-get install -f mysql-client=5.7* mysql-community-server=5.7* mysql-server=5.7*    #Type root password - "admin"
sudo service mysql start

MYSQL_HOST="localhost"
MYSQL_USER="root"
MYSQL_PASSWORD="admin"
mysql -u root --password=$MYSQL_PASSWORD -e "CREATE DATABASE wordpress;"
MYSQL_DATABASE="wordpress"
MYSQL_HOST="localhost"
PASSWORDS=("password", "123123", "1234567", "1111111", "admin", "qwerty", "qwetry123", "abcdef", "12345", "123456789")

NUM_USERS=10

# Loop to create users
for i in $(seq 1 $NUM_USERS)
do
    # Generate a username
    USERNAME="user_$i"

    # Get the password from the password file
    PASSWORD=${PASSWORDS[$i-1]}

    # Create the user in MySQL
    mysql -u $MYSQL_USER -p$MYSQL_PASSWORD -h $MYSQL_HOST -e "CREATE USER '$USERNAME'@'$MYSQL_HOST' IDENTIFIED BY '$PASSWORD';" $MYSQL_DATABASE

    # Grant privileges to the user
    mysql -u $MYSQL_USER -p$MYSQL_PASSWORD -h $MYSQL_HOST -e "GRANT ALL PRIVILEGES ON $MYSQL_DATABASE.* TO '$USERNAME'@'$MYSQL_HOST';" $MYSQL_DATABASE

    echo "User created: $USERNAME with password: $PASSWORD"
done

#Setup wp-cli that we can use wp command
curl -O https://raw.githubusercontent.com/wp-cli/builds/gh-pages/phar/wp-cli.phar
php wp-cli.phar --info
chmod +x wp-cli.phar
sudo mv wp-cli.phar /usr/local/bin/wp

#Setup wordpress
cd /var/www/html
sudo wget https://wordpress.org/wordpress-5.7.2.tar.gz
sudo tar -xzvf wordpress-5.7.2.tar.gz
cd wordpress

sudo chown -R www-data:www-data /var/www/html/wordpress
sudo chmod -R 777 /var/www/html/wordpress/
sudo chmod 777 ../wordpress

wp config create --dbname=$MYSQL_DATABASE --dbuser=$MYSQL_USER --dbpass=$MYSQL_PASSWORD --dbhost=$MYSQL_HOST
wp config shuffle-salts
wp core install --url=server123.site --title="Your Site Title" --admin_user=admin --admin_password=admin123 --admin_email=admin@gmail.com

wp user create user1 user1@gmail.com --role=administrator --user_pass=password1
wp user create user2 user2@gmail.com --role=editor --user_pass=password2
wp user create user3 user3@gmail.com --role=author --user_pass=password3
wp user create user4 user4@gmail.com --role=contributor --user_pass=password4
wp user create user5 user5@gmail.com --role=subscriber --user_pass=password5
wp user create user6 user6@gmail.com --role=editor --user_pass=password6
wp user create user7 user7@gmail.com --role=author --user_pass=password7

cd /var/www/html/wordpress/wp-content/plugins

sudo curl -O https://downloads.wordpress.org/plugin/wordpress-seo.17.1.zip
sudo curl -O https://downloads.wordpress.org/plugin/jetpack.9.6.zip
sudo curl -O https://downloads.wordpress.org/plugin/contact-form-7.5.4.1.zip
sudo curl -O https://downloads.wordpress.org/plugin/woocommerce.5.0.0.zip
sudo curl -O https://downloads.wordpress.org/plugin/wp-super-cache.1.7.1.zip

sudo unzip wordpress-seo.17.1.zip
sudo unzip jetpack.9.6.zip
sudo unzip contact-form-7.5.4.1.zip
sudo unzip woocommerce.5.0.0.zip
sudo unzip wp-super-cache.1.7.1.zip

wp plugin activate wordpress-seo
wp plugin activate jetpack
wp plugin activate contact-form-7
wp plugin activate woocommerce
wp plugin activate wp-super-cache

sudo chmod -R 755 /var/www/html/wordpress/

#Update apache server

sudo touch /etc/apache2/sites-available/server123.conf
sudo chmod 766 /etc/apache2/sites-available/server123.conf
sudo echo "
<VirtualHost *:80>
    ServerAdmin webmaster@server123.site
    ServerName server123.site
    DocumentRoot /var/www/html/wordpress

    ErrorLog /${APACHE_LOG_DIR}/server123_error.log
    CustomLog /${APACHE_LOG_DIR}/server123_access.log combined

    <Directory /var/www/html/wordpress>
        Options Indexes FollowSymLinks
        AllowOverride All
        Require all granted
    </Directory>
</VirtualHost>
" > /etc/apache2/sites-available/server123.conf
sudo ln -s /etc/apache2/sites-available/server123.conf /etc/apache2/sites-enabled/
sudo a2dissite 000-default.conf
sudo service apache2 reload
sudo service apache2 restart


##Creating distribution users

sudo groupadd admin

# 2 admin group users
sudo useradd -m admin1
sudo useradd -m admin2

echo 'admin1:Pass123!' | sudo chpasswd
echo 'admin2:Hello@123' | sudo chpasswd

# 3 sudo users
sudo useradd -m sudo_user1
sudo useradd -m sudo_user2
sudo useradd -m sudo_user3

# Set passwords for the sudo users
echo 'sudo_user1:SecurePwd!' | sudo chpasswd
echo 'sudo_user2:EasyAsABC1' | sudo chpasswd
echo 'sudo_user3:1234Pass!' | sudo chpasswd

# adding users to sudo group
sudo usermod -aG adm admin1
sudo usermod -aG adm admin2
sudo usermod -aG sudo admin1
sudo usermod -aG sudo admin2

sudo usermod -aG sudo sudo_user1
sudo usermod -aG sudo sudo_user2
sudo usermod -aG sudo sudo_user3

# 3 regular users
sudo useradd -m regular_user1
sudo useradd -m regular_user2
sudo useradd -m regular_user3

# Set passwords for the regular users
echo 'regular_user1:Sunshine12' | sudo chpasswd
echo 'regular_user2:Password$1' | sudo chpasswd
echo 'regular_user3:SimplePwd!' | sudo chpasswd


###Additional tasks###

#Change hostname
sudo hostnamectl set-hostname server123.site
sudo sed -i "s/localhost/server123.site/g" /etc/hosts

#Mail server setup#
yes y | sudo apt-get install mailutils postfix dovecot-imapd dovecot-pop3d opendkim opendkim-tools

sudo chmod 766 /etc/postfix/main.cf
sudo echo -e "
##Postfix configuration##
smtpd_banner = \$myhostname ESMTP \$mail_name (Ubuntu)
biff = no
append_dot_mydomain = no
readme_directory = no
compatibility_level = 2

smtpd_tls_cert_file=/etc/ssl/certs/ssl-cert-snakeoil.pem
smtpd_tls_key_file=/etc/ssl/private/ssl-cert-snakeoil.key
smtpd_tls_security_level=may

smtp_tls_CApath=/etc/ssl/certs
smtp_tls_security_level=may
smtp_tls_session_cache_database = btree:\${data_directory}/smtp_scache

smtpd_relay_restrictions = permit_mynetworks permit_sasl_authenticated defer_unauth_destination
myhostname = server123.site
alias_maps = hash:/etc/aliases
alias_database = hash:/etc/aliases
myorigin = /etc/mailname
mydestination = \$myhostname, server123.site, localhost.site, , localhost
relayhost = 
mynetworks = 127.0.0.0/8 [::ffff:127.0.0.0]/104 [::1]/128
mailbox_size_limit = 0
recipient_delimiter = +
inet_interfaces = all
inet_protocols = all
home_mailbox = Maildir/

smtpd_milters = inet:127.0.0.1:8892
non_smtpd_milters = \$smtpd_milters
milter_default_action = accept" > /etc/postfix/main.cf

sudo service postfix restart
sudo chmod 766 /etc/dovecot/dovecot.conf
sudo echo "
protocols = pop3 pop3s imap imaps
log_path = /var/log/dovecot.log" >> /etc/dovecot/dovecot.conf

sudo service dovecot restart

sudo chmod 766 /etc/opendkim.conf
sudo echo "
# Log to syslog
Autorestart             yes
AutorestartRate         10/1h
Syslog			yes
LogWhy                  yes
UMask			002
Socket                  inet:8892@localhost
PidFile               /run/opendkim/opendkim.pid
OversignHeaders		From
TrustAnchorFile       /usr/share/dns/root.key
UserID                opendkim

ExternalIgnoreList   refile:/etc/opendkim/TrustedHosts
InternalHosts    refile:/etc/opendkim/TrustedHosts
KeyTable   refile:/etc/opendkim/KeyTable
SigningTable   refile:/etc/opendkim/SigningTable
SignatureAlgorithm     rsa-sha256" > /etc/opendkim.conf

sudo service opendkim restart
sudo mkdir /etc/opendkim
sudo opendkim-genkey -D /etc/opendkim/ --domain server123.site --selector dkim
sudo touch /etc/opendkim/TrustedHosts
sudo touch /etc/opendkim/SigningTable
sudo touch /etc/opendkim/KeyTable
sudo chmod 400 /etc/opendkim/dkim.private
sudo chmod 766 /etc/opendkim/TrustedHosts
sudo chmod 766 /etc/opendkim/SigningTable
sudo chmod 766 /etc/opendkim/KeyTable
sudo echo "
server123.site
127.0.0.1
::1" > /etc/opendkim/TrustedHosts
sudo echo "dkim._domainkey.server123.site server123.site:dkim:/etc/opendkim/dkim.private" > /etc/opendkim/KeyTable
sudo echo "*@server123.site dkim._domainkey.server123.site" > /etc/opendkim/SigningTable
sudo chown opendkim:opendkim /etc/opendkim/dkim.private
sudo service opendkim restart
sudo service postfix restart
sudo service dovecot restart

###

###Desktop environment and rdp setup###

yes y | sudo apt-get install lxde lightdm rdesktop xorg x2goserver

sudo touch /etc/lightdm/lightdm.conf
sudo chmod 766 /etc/lightdm/lightdm.conf
sudo echo "
[SeatDefaults]
user-session=LXDE
" > /etc/lightdm/lightdm.conf
sudo service lightdm restart
yes y | sudo apt-get install rdesktop xrdp x2goserver

#Restart system
sudo reboot


