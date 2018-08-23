using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Andrian Alexander Putra & Thet Paing Htun
 * Date: 29.7.2018
 * INFT2012 Application Programming - Assignment
 * Lurgit Dice Game
 */

namespace LurgItDiceGameAndrianThet
{
    public partial class LurgIt : Form
    {
        int player; //declare the player
        int[] iValue = new int[3]; //to store the values of the 3 dices
        Random r = new Random(); //to generate the random number of the dices
        Graphics[] graPaper; //to draw the outcomes of the 3 dices
        int roll = 0; //to count the roll number
        int rp1 = 1; //to count round player1
        int rp2 = 1; //to count round player2
        int d1, d2, d3; //to check the dice number
        int iBonus = 0;
        int iRoundScore;
        int score; //to declare the scoring number
        int p1score = 0; //to declare the player 1 score
        int p2score = 0; //to declare the player 2 score
        int reqNo = 1; //to check with the required number

        public LurgIt()
        {
            InitializeComponent();
            graPaper = new Graphics[3]; //instantiate the random number generator
            graPaper[0] = picBx1.CreateGraphics(); //create the graphics paper to draw the outcomes of the dice
            graPaper[1] = picBx2.CreateGraphics();
            graPaper[2] = picBx3.CreateGraphics();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            player = 3; //to instantiate the single player
            if (tbxPlayer1.Text == "")
            {
                MessageBox.Show("cannot be blank!"); //to show the user must fill in the player name
            }
            else
            {
                tbxSetting.AppendText("Single Player: " + tbxPlayer1.Text + Environment.NewLine);
                tbxPlayer2.Enabled = false;
                btnSinglePlayer.Enabled = false;
                btnDouble.Enabled = false;
                btnComputer.Enabled = false;
                tbxP2Score.Enabled = false;
                btnSinglePlayer.BackColor = Color.Red;
                btnRoll.Enabled = true;
                btnNextRound.Enabled = false;
                tbxOutput.Text = "Round                  Roll                 Dice Rolled                  Round Score                  Bonus\r\n";
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            if (tbxPlayer1.Text == "" || tbxPlayer2.Text == "")
            {
                MessageBox.Show("cannot be blanks!"); //to show the user must fill in the player name
            }
            else
            {
                player = r.Next(1, 3); //to check who start the game first (player 1 or player 2)
                if (player == 1)
                    tbxSetting.AppendText("Player 1 start the game: " + tbxPlayer1.Text + Environment.NewLine);
                else
                    tbxSetting.AppendText("Player 2 start the game: " + tbxPlayer2.Text + Environment.NewLine);

                btnSinglePlayer.Enabled = false;
                btnDouble.Enabled = false;
                btnComputer.Enabled = false;
                btnDouble.BackColor = Color.Yellow;
                btnRoll.Enabled = true;
                tbxOutput.Text = "Round                  Roll                 Dice Rolled                  Round Score                  Bonus\r\n";
            }

        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            if (btnHold.Text == "Roll" || roll == 0) //change the hold button to roll when the user holds the dice 1
                btnHold.Text = "Hold";
            else
                btnHold.Text = "Roll"; //set the hold button back when the user unhold the dice

        }

        private void btnHold2_Click(object sender, EventArgs e)
        {
            if (btnHold2.Text == "Roll" || roll == 0) //change the hold button to roll when the user holds the dice 2
                btnHold2.Text = "Hold";
            else
                btnHold2.Text = "Roll"; //set the hold button back when the user unhold the dice
        }

        private void btnHold3_Click(object sender, EventArgs e)
        {
            if (btnHold3.Text == "Roll" || roll == 0) //change the hold button to roll when the user holds the dice 3
                btnHold3.Text = "Hold";
            else
                btnHold3.Text = "Roll"; //set the hold button back when the user unhold the dice
        }

        private void drawDie(Graphics graPaper, int value)
        {
            graPaper.Clear(picBx1.BackColor);
            graPaper.DrawRectangle(Pens.Black, 0, 0, 133, 117);
            int width = 20;
            if (value == 1) //draw the outcome of the dice number 1
            {
                graPaper.FillEllipse(Brushes.Red, 54, 54, width, width);
            }
            if (value == 2) //draw the outcome of the dice number 2
            {
                graPaper.FillEllipse(Brushes.Red, 10, 10, width, width);
                graPaper.FillEllipse(Brushes.Red, 105, 90, width, width);
            }
            if (value == 3) //draw the outcome of the dice number 3
            {
                graPaper.FillEllipse(Brushes.Red, 10, 10, width, width);
                graPaper.FillEllipse(Brushes.Red, 54, 54, width, width);
                graPaper.FillEllipse(Brushes.Red, 105, 90, width, width);
            }
            if (value == 4) //draw the outcome of the dice number 4
            {
                graPaper.FillEllipse(Brushes.Red, 10, 10, width, width);
                graPaper.FillEllipse(Brushes.Red, 105, 10, width, width);
                graPaper.FillEllipse(Brushes.Red, 10, 90, width, width);
                graPaper.FillEllipse(Brushes.Red, 105, 90, width, width);
            }
            if (value == 5) //draw the outcome of the dice number 5
            {
                graPaper.FillEllipse(Brushes.Red, 10, 10, width, width);
                graPaper.FillEllipse(Brushes.Red, 105, 10, width, width);
                graPaper.FillEllipse(Brushes.Red, 10, 90, width, width);
                graPaper.FillEllipse(Brushes.Red, 105, 90, width, width);
                graPaper.FillEllipse(Brushes.Red, 54, 54, width, width);
            }
            if (value == 6) //draw the outcome of the dice number 6
            {
                graPaper.FillEllipse(Brushes.Red, 10, 10, width, width);
                graPaper.FillEllipse(Brushes.Red, 105, 10, width, width);
                graPaper.FillEllipse(Brushes.Red, 10, 90, width, width);
                graPaper.FillEllipse(Brushes.Red, 105, 90, width, width);
                graPaper.FillEllipse(Brushes.Red, 10, 52, width, width);
                graPaper.FillEllipse(Brushes.Red, 105, 52, width, width);
            }
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            if (tbxPlayer1.Text == "")
            {
                MessageBox.Show("cannot be blank!"); //to show the user must fill in the player name
            }
            else
            {
                tbxPlayer2.Text = "COMM"; //computer player name
                tbxPlayer2.Enabled = false;
                btnSinglePlayer.Enabled = false;
                btnDouble.Enabled = false;
                btnComputer.Enabled = false;
                btnComputer.BackColor = Color.Green;
                btnRoll.Enabled = true;
                tbxOutput.Text = "Round                  Roll                 Dice Rolled                  Round Score                  Bonus\r\n";

                player = r.Next(1, 3);
                if (player == 1)
                {
                    tbxSetting.AppendText("Player 1 start the game: " + tbxPlayer1.Text + Environment.NewLine);
                }
                else
                {
                    tbxSetting.AppendText("Player 2 start the game: " + tbxPlayer2.Text + Environment.NewLine);
                    compTurn();
                }
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (player == 0 || tbxPlayer1.Text == "")
            {
                MessageBox.Show("Cannot roll dice! You need to enter your name...");
            }
            else
            {
                Random RndRandom = new Random();
                roll++;
                for (int x = 1; x <= 10; x++)
                {
                    if (btnHold.Text == "Hold")
                    {
                        d1 = RndRandom.Next(1, 7);
                        drawDie(graPaper[0], d1);
                    }
                    if (btnHold2.Text == "Hold")
                    {
                        d2 = RndRandom.Next(1, 7);
                        drawDie(graPaper[1], d2);
                    }
                    if (btnHold3.Text == "Hold")
                    {
                        d3 = RndRandom.Next(1, 7);
                        drawDie(graPaper[2], d3);
                    }

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(70);
                }

                iValue[0] = d1;
                iValue[1] = d2;
                iValue[2] = d3;

                if (player == 1) //1st player multiplayer
                {
                    rollPDice();
                }
                else if (player == 2) //2nd player multiplayer
                {
                    rollPDice();
                }
                if (tbxPlayer2.Text == "" || player == 3) //single player
                {
                    player = 3;
                    rollDice();
                }

                tbxP1Score.Text = p1score.ToString();
                tbxP2Score.Text = p2score.ToString();
            }
        }
        private void rollPDice() //rolldice for player vs player & player vs computer
        {
            int[] num = new int[3] { d1, d2, d3 };
            Array.Sort(num);

            lblRound1.Text = rp1.ToString();
            lblRound2.Text = rp2.ToString();

            if (roll == 1)
            {
                btnRoll.Enabled = true;
                if (player == 1)
                    tbxOutput.AppendText("    " + rp1);
                else
                    tbxOutput.AppendText("    " + rp2);

                tbxOutput.AppendText("                        " + roll + "                        " + d1 + " " + d2 + " " + d3 + "                                                                  " + sequenceBonus(num) + Environment.NewLine);
            }
            else if (roll == 2)
            {
                if (player == 1)
                    tbxOutput.AppendText("    " + rp1);
                else
                    tbxOutput.AppendText("    " + rp2);

                tbxOutput.AppendText("                        " + roll + "                        " + d1 + " " + d2 + " " + d3 + "                                                                  " + sequenceBonus(num) + Environment.NewLine);
            }
            else if (roll == 3)
            {
                if (player == 1)
                    tbxOutput.AppendText("    " + rp1);
                else
                    tbxOutput.AppendText("    " + rp2);

                tbxOutput.AppendText("                        " + roll + "                        " + d1 + " " + d2 + " " + d3 + "                                                                  " + sequenceBonus(num) + Environment.NewLine);
                roll = 0;
                if (player == 1)
                {
                    player = 2;
                    rp1++;
                    tbxSetting.AppendText("Player 2 start the game: " + tbxPlayer2.Text + Environment.NewLine);
                }
                else
                {
                    player = 1;
                    rp2++;
                    tbxSetting.AppendText("Player 1 start the game: " + tbxPlayer1.Text + Environment.NewLine);
                }
                lblMsg.Text = "Please proceed to the next round.You have reached the maximum rolls for this round\r\n";

                tbxOutput.Text += "                                                                                                 " + roundScore(num, rp1) + "\r\n";
                tbxOutput.Text += "                                                                                                 " + roundScore(num, rp2) + "\r\n";

                if (player == 1)
                {
                    p1score += sequenceBonus(num);
                    p1score += LurgItBonus(num, rp1);
                    p1score += roundScore(num, rp1);
                }
                else
                {
                    p2score += sequenceBonus(num);
                    p2score += LurgItBonus(num, rp2);
                    p2score += roundScore(num, rp2);
                }

                btnHold.Text = "Hold";
                btnHold2.Text = "Hold";
                btnHold3.Text = "Hold";
            }
            if (rp1 == 7)
            {
                tbxSetting.AppendText("Player 1 Ends the game" + Environment.NewLine);
            }
            else if (rp2 == 7)
            {
                tbxSetting.AppendText("Player 2 Ends the game" + Environment.NewLine);
            }
            if (rp1 == 7 || rp2 == 7)
            {
                if (p1score < p2score)
                {
                    MessageBox.Show("Player 2 wins the game!");
                }
                else if (p1score > p2score)
                {
                    MessageBox.Show("Player 1 wins the game!");
                }
                else if (p1score == p2score)
                {
                    MessageBox.Show("Draw the game!");
                }

                DialogResult dialogResult = MessageBox.Show("You still want to play for the next round?", "Sure", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    rp1 = 1;
                    rp2 = 1;

                    btnComputer.Enabled = false;
                    btnSinglePlayer.Enabled = false;
                    btnDouble.Enabled = false;
                    tbxSetting.AppendText("Next Round for Double Player" + Environment.NewLine);
                    player = r.Next(1, 3);
                    if (player == 1)
                        tbxSetting.AppendText("Player 1 start the game: " + tbxPlayer1.Text + Environment.NewLine);
                    else
                        tbxSetting.AppendText("Player 2 start the game: " + tbxPlayer2.Text + Environment.NewLine);
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }

        }
        private void rollDice() //roll dice for single player
        {
            int[] num = new int[3] { d1, d2, d3 };
            Array.Sort(num);

            p1score += sequenceBonus(num);
            p1score += LurgItBonus(num, rp1);
            p1score += roundScore(num, rp1);

            if (roll == 0)
                btnNextRound.Enabled = false;
            if (roll == 1)
            {
                btnNextRound.Enabled = true;
                tbxOutput.AppendText("    " + rp1);
                tbxOutput.AppendText("                        " + roll + "                        " + d1 + " " + d2 + " " + d3 + "                                                                  " + sequenceBonus(num) + Environment.NewLine);
            }
            else if (roll == 2)
            {
                tbxOutput.AppendText("    " + rp1);
                tbxOutput.AppendText("                        " + roll + "                        " + d1 + " " + d2 + " " + d3 + "                                                                  " + sequenceBonus(num) + Environment.NewLine);
            }
            else if (roll == 3)
            {
                tbxOutput.AppendText("    " + rp1);
                tbxOutput.AppendText("                        " + roll + "                        " + d1 + " " + d2 + " " + d3 + "                                                                  " + sequenceBonus(num) + Environment.NewLine);
                roll = 0;
                btnRoll.Enabled = false;

                tbxOutput.Text += "                                                                                                 " + roundScore(num, rp1) + "\r\n";

                lblMsg.Text = "Please proceed to the next round.You have reached the maximum rolls for this round\r\n";

                btnHold.Text = "Hold";
                btnHold2.Text = "Hold";
                btnHold3.Text = "Hold";
            }

            if (rp1 == 6)
            {
                if (roll == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("You still want to play for the next round? \r\n" + "Game Score: " + p1score + "\r\nPlayer wins - but that's easy in a 1-player game!", "Sure", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        rp1 = 0;
                        p1score = 0;
                        btnComputer.Enabled = false;
                        btnSinglePlayer.Enabled = false;
                        btnDouble.Enabled = false;
                        tbxSetting.AppendText("Next Round for Single Player: " + tbxPlayer1.Text + Environment.NewLine);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            if (player == 3) //single player
            {
                rp1 += 1;
                roll = 0;
                btnRoll.Enabled = true;
                btnNextRound.Enabled = false;
                lblRound1.Text = rp1.ToString();
                lblMsg.Text = "";
            }
            else if (player == 1 || player == 2) //double player or with computer player
            {
                if (player == 1)
                {
                    rp1 += 1;
                    roll = 0;
                    btnRoll.Enabled = true;
                    btnNextRound.Enabled = false;
                    lblRound1.Text = rp1.ToString();
                    lblMsg.Text = "";
                }
                if (player == 2)
                {
                    rp2 += 1;
                    roll = 0;
                    btnRoll.Enabled = true;
                    btnNextRound.Enabled = false;
                    lblRound2.Text = rp2.ToString();
                    lblMsg.Text = "";
                }
            }
        }
        //method to check the sequence bonus
        private int sequenceBonus(int[] iValues)
        {
            if (iValues[0] + 1 == iValues[1] && iValues[1] + 1 == iValues[2]) //checking whether the 3 values are consecutive number
            {
                return 10;
            }
            else
                return 0;
        }
        //method to check the lurgItBonus
        private int LurgItBonus(int[] num, int round)
        {
            if (num[0] == round && num[1] == round && num[2] == round)
                return 20;
            else
                return 0;
        }

        //method to check the score of the round
        private int roundScore(int[] iValues, int iRound)
        {
            int total = 0;
            for (int n = 0; n < 3; n++) //loop to check whether the last 3 values of the dices of the round equal with the round number 
            {
                if (iValues[n] == iRound)
                    total += iRound;
            }
            return total; //return the total score of the round
        }
        //computer strategies
        private void compTurn()
        {
            btnRoll.Enabled = true;
            for (int n = 0; n < 3; n++)
            {
                btnRoll_Click(sender, e);
                if (d1 == rp2 && n == 1)
                {
                    btnHold_Click(sender, e);
                    lblMsg.Text += "Computer holds dice 1";
                }
                if (d2 == rp2 && n == 2)
                {
                    btnHold2_Click(sender, e);
                    lblMsg.Text += "Computer holds dice 2";
                }
                if (d3 == rp2 && n == 3)
                {
                    btnHold3_Click(sender, e);
                    lblMsg.Text += "Computer holds dice 3";
                }
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
            }
        }
        public EventArgs e { get; set; }

        public object sender { get; set; }
    }
}
