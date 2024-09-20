using quoridor_v2.GameAI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quoridor_v2
{
    public partial class Start : Form
    {
        public DialogResult result = DialogResult.OK;
       
        public Start()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.OK;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Program.main.game = new Game(AIOption.Checked);

            if (Program.main.game.IsGameWithAI)
            {
                Program.main.ai = new AI();
                Program.main.aiTime = 0.0;
                Program.main.aiActions = 0.0;
            }

            Program.main.DrawGame();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Program.main.Close();
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Program.main.Close();
        }
    }
}
