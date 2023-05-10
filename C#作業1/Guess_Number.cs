using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace C_作業1
{
    public partial class Guess_Number : Form
    {
        private int lives = 10;
        private int random = 0;
        public Guess_Number()
        {
            InitializeComponent();
            Random rnd = new Random();
            random = rnd.Next() % 100;
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(lives ==0)
            {
                labFrom.Text = "You";
                labTo.Text = "lose";
                return;
            }
            if(e. KeyCode == Keys.Enter)
            {
                lives--;
                int userGuessed = Int32.Parse(txtInput.Text); 
                if(userGuessed == random)
                {
                    labFrom.Text = "You";
                    labTo.Text = "win";
                    return;
                }
                if (userGuessed < random)
                {
                    labFrom.Text = userGuessed.ToString();
                }
                else 
                {
                    labTo.Text = userGuessed.ToString();
                }

                labStatus.Text = "Remaining Lives: " + lives;
                //if (lives <= 3)
                //{
                //    labStatus.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0));
                //}
            }

        }
    }
}
