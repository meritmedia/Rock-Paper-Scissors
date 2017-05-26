/*
 * Name: Charles Pecot
 * Date: Sept 29, 2015
 * Project: Exercise 4.8, RockPaperScissorsGUI
 * Demonstration of If ELSE and SWITCH logic.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace RockPaperScissorsGUI
{
    public partial class frmRPS : Form
    {
        int  youWins = 0, compWins = 0;
        enum Hands
        {
            ROCK = 1, PAPER, SCISSORS
        }
        public frmRPS()
        {
            InitializeComponent();
        }
        // das buttons
        private void btnRock_Click(object sender, EventArgs e)
        {
            whoWon((int)Hands.ROCK, ComputerPick());
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            whoWon((int)Hands.PAPER, ComputerPick());
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            whoWon((int)Hands.SCISSORS, ComputerPick());
        }

        // called from whoWon
        private void YouPick(int you)
        {
            //set the user's choices to their dimmed versions
            btnPaper.Image = ((System.Drawing.Image)(Properties.Resources.paper_l_no));
            btnRock.Image = ((System.Drawing.Image)(Properties.Resources.rock_l_no));
            btnScissors.Image = ((System.Drawing.Image)(Properties.Resources.scissors_l_no));
            switch (you)
            {  // reset the user's pick to normal
                case 1: //ROCK
                    btnRock.Image = ((System.Drawing.Image)(Properties.Resources.rock_l));
                    break;
                case 2: //PAPER
                    btnPaper.Image = ((System.Drawing.Image)(Properties.Resources.paper_l));
                    break;
                case 3: //SCISSORS
                    btnScissors.Image = ((System.Drawing.Image)(Properties.Resources.scissors_l));
                    break;
                default: //SOMETHING ELSE
                    btnScissors.Image = ((System.Drawing.Image)(Properties.Resources.computer));
                    break;
            }
            
        }
        // The computer's pick
        private int ComputerPick()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, Enum.GetNames(typeof(Hands)).Length+1);
            // change the computer's picked image
            switch (choice)
            {
                case 1:
                    btnComputer.Image = ((System.Drawing.Image)(Properties.Resources.rock_r));
                    break;
                case 2:
                    btnComputer.Image = ((System.Drawing.Image)(Properties.Resources.paper_r));
                    break;
                case 3:
                    btnComputer.Image = ((System.Drawing.Image)(Properties.Resources.scissors_r));
                    break;
                default:
                    btnComputer.Image = ((System.Drawing.Image)(Properties.Resources.computer));
                    break;
            }
            return choice;  // return the value to be used in method "whoWon".
        }
        private void whoWon(int youVal, int computerVal)
        {
            YouPick(youVal); // display what the user picked
            // commpare the user's choice with the computer's choice.
            // Could also be coded as
            // (youVal==1 && computerVal==3) || (youVal==2 && computerVal==1) || (youVal==3 && computerVal==2)
            // But it may just be easier to say "rock (1) beats scissors (3), difference is -2,
            //                                   paper (2) beats rock (1), difference is 1,
            //                               and scissors (3) beats paper (2), difference is 1".
            // Now you're making two comparisons rather than 3
            // BTW, the differences the other way round are -1 and 2 (the same numbers * -1)
            int diff = youVal - computerVal;
            string winningHand = "";
            if (diff == 0)
            {
                lblWinner.Text =  "Tie!";
                lblComputerWinner.Text =  "Tie!";
            }
            else if (diff == 1 || diff == -2)
            {
                winningHand = Enum.GetName(typeof(Hands), youVal);
                lblWinner.Text =  winningHand + " wins!";
                lblComputerWinner.Text = "";
                lblYouWins.Text = "Wins: " + ++youWins;
            }
            else
            {
                winningHand = Enum.GetName(typeof(Hands), computerVal);
                lblComputerWinner.Text = winningHand + " wins!";
                lblWinner.Text = "";
                lblCompWins.Text = "Wins: " + ++compWins; 
            }
             
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening up your default browser...");
            Process.Start("http://beyourownhero.us/donations.html#rockpaperscissors");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
