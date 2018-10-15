using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NumberGuessingGame
{
    public partial class frmGuessingGame : Form
    {
        public frmGuessingGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declare constant and variable
            const int REAL_ANSWER = 6;
            int numUser;

            //Get the number from the user
            numUser = int.Parse(txtNumber.Text);


            //Check the number and display the answer
            if (numUser == REAL_ANSWER)
            {
                lblAnswer.Text = "Correct!";
                this.pictureBox1.Image = Properties.Resources.checkmark1;
                SoundPlayer splayer = new SoundPlayer(@
                splayer.Play();
            }
            if (numUser != REAL_ANSWER)
            {
                lblAnswer.Text = "Wrong!";
                this.pictureBox1.Image = Properties.Resources.red_x;
                
            
            }
            
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
