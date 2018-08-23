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
    public partial class frmLurgIt : Form
    {
        Graphics [] graPaper; //declare drawing pad for dice
        int iDiceNo1, iDiceNo2, iDiceNo3, iRoundScore, iBonus = 0, iGameScore = 0, iGameScore2 = 0, a, iRound = 1, iRound2 = 1, iRoll = 1; //declare dice no: 1,2,3, roundscore, bonus score, game score for player 1 and player 2, to check with the round number from 1-6, to check with the how many rolls from 1-3
        Random randomDice = new Random(); //declare random number
        bool hold1 = true, hold2 = true, hold3 = true, p1 = true, comp = true; //to check hold the dice
        int[] ascendingDiceValue; //check the value if ascending

        public frmLurgIt()
        {
            InitializeComponent();
            graPaper = new Graphics[3]; //initialize the graphics into array [3]
            graPaper[0] = picBx1.CreateGraphics(); /* initialize the first picbx 1,2,3 into an array */
            graPaper[1] = picBx2.CreateGraphics();
            graPaper[2] = picBx3.CreateGraphics();
            btnNextRoundP1.Enabled = false;
            btnNextRoundP2.Enabled = false;
            btnHold1.Enabled = false;
            btnHold2.Enabled = false;
            btnHold3.Enabled = false;
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e) //single player
        {
            if(tbxPlayer1.Text=="") //user must enter player name before start the game
            {
                MessageBox.Show("Enter Player Name", "Enter Name"); //show the error message if the textbox is empty
                return;
            }
            lblRound1.Text =  iRound.ToString(); //to show the round of each single player 
            tbxOutput1.Text = "   Round     Roll      Dice Rolled      Round Score      Bonus\r\n"; //to show the output of how many rolls, round score, bonus
            btnRoll.Enabled = true;
            btnSinglePlayer.Enabled = false;
            btnDouble.Enabled = false;
            btnComputer.Enabled = false;
            tbxPlayer1.Enabled = false;
            tbxPlayer2.Enabled = false;
            lblPlayer1Score.Text = tbxPlayer1.Text + " Score:";
            lblP1ScoreBoard.Text = tbxPlayer1.Text;
            lblPlayer2Score.Visible = false;
            tbxP2Score.Visible = false;
            lblRound2.Visible = false;
            btnNextRoundP2.Visible = false;
            panel2.Visible = false;

        }

        private void btnDouble_Click(object sender, EventArgs e) //double player
        {
            if (tbxPlayer1.Text == ""|| tbxPlayer2.Text=="") //user need to enter the player name 1 and 2
            {
                MessageBox.Show("Enter Both Player Names", "Enter Names"); // to show the error message if the textbox is empty
                return;
            }
            tbxGameFeed.Text = tbxPlayer1.Text + " starts the game \r\n";
            p1 = false;
            panel2.Visible = true;
            panel2.Enabled = false;
            lblRound1.Text =  iRound.ToString();
            tbxOutput1.Text = "   Round     Roll      Dice Rolled      Round Score      Bonus\r\n"; //to show the output of how many rolls, round score, bonus
            tbxOutput2.Text = "   Round     Roll      Dice Rolled      Round Score      Bonus\r\n";
            btnRoll.Enabled = true;
            btnSinglePlayer.Enabled = false;
            btnDouble.Enabled = false;
            btnComputer.Enabled = false;
            tbxPlayer1.Enabled = false;
            tbxPlayer2.Enabled = false;
            lblPlayer1Score.Text = tbxPlayer1.Text + " Score:";
            lblPlayer2Score.Text = tbxPlayer2.Text + " Score:";
            lblP1ScoreBoard.Text = tbxPlayer1.Text;
            lblP2ScoreBoard.Text = tbxPlayer2.Text;
        }

        private void btnComputer_Click(object sender, EventArgs e) //play with computer
        {
            if (tbxPlayer1.Text == "") //player 1 need to enter the name
            {
                MessageBox.Show("Enter Player Name", "Enter Name"); //to show error message when the textbos is empty
                return;
            }
            comp = false;
            tbxPlayer2.Text = "Computer";
            btnNextRoundP2.Visible = false;
            btnDouble_Click(sender, e);
        }

        private void drawDie(Graphics graPaper, int value) //to declare the dice
        {
            graPaper.Clear(picBx1.BackColor); //to clear the dice
            graPaper.DrawRectangle(Pens.Black, 0, 0, 133, 117); //to draw the rectangle
            int width = 20; //set the width of the each dice
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

        
        private int calculateRoundScore(int[] iValues, int iRound) //functions to calculate the round score
        {
            int total = 0; //initialize the total number -- start from zero
            for (int n = 0; n < 3; n++)
            {
                if (iValues[n] == iRound) //if the values equal to the round number
                    total += iRound; //plus one from the round number
            }
            return total; //return the total round score
        }

        private int calculateLurgitBonus(int[] iValues, int iRound) //functions to calculate the lurg it bonus
        {
            if (iValues[0] == iRound && iValues[1] == iRound && iValues[2] == iRound) //check if the values same with the round score
            {
                lblMsg.Text = "Lurgit Bonus = 20"; //show the message when user hit the lurg it bonus
                btnRoll.Enabled = false;
                return 20; //user get 20 score
            }
            else
                return 0; //user did not get any score
        }

        private int calculateSequenceBonus(int[] iValues) //functions to calculate the sequence bonus
        {
            if (iValues[0] + 1 == iValues[1] && iValues[1] + 1 == iValues[2]) //to check sequence number of the dice
            {
                lblMsg.Text = "Sequence Bonus = 10"; //to show the user when hit the sequence bonus
                return 10; //user will get score 10
            }
            else
                return 0; //user will get zero
        }

      
        private void btnHold1_Click(object sender, EventArgs e) //to hold the dice 1
        {
            hold1 = !hold1; 
            if (hold1 == false)
                btnHold1.ForeColor = Color.Red; //when user hold the dice the text become red colour
            else
                btnHold1.ForeColor = Color.Black; //when user did not hold the dice the text become black colour
        }

        private void btnHold2_Click(object sender, EventArgs e) //to hold the dice 2
        {
            hold2 = !hold2;
            if (hold2 == false)
                btnHold2.ForeColor = Color.Red; //when user hold the dice the text become red colour
            else
                btnHold2.ForeColor = Color.Black; //when user did not hold the dice the text become black colour
        }

        private void btnHold3_Click(object sender, EventArgs e) //to hold the dice 3
        {
            hold3 = !hold3;
            if (hold3 == false)
                btnHold3.ForeColor = Color.Red; //when user hold the dice the text become red colour
            else
                btnHold3.ForeColor = Color.Black; //when user did not hold the dice the text become black colour
        }
        private void ascending(int[] iValues) //to make the number of dice become ascending order
        {
            for (int n = 0; n < 2; n++) //use for loop to check the dice number
            {
                int smallest = n; //initialize the smallest number to n
                for (int m = 1; m < 3; m++)
                {
                    if (iValues[smallest] > iValues[m])
                    {
                        smallest = m;
                    }
                }
                int temp = iValues[n];
                iValues[n] = iValues[smallest];
                iValues[smallest] = temp;
            }

        }      
        private void buttonsDisable() //functions to disable the hold button and next round -- applicable for first rolling the dice
        {
            btnHold1.Enabled = false;
            btnHold2.Enabled = false;
            btnHold3.Enabled = false;
            btnNextRoundP1.Enabled = false;
            btnNextRoundP2.Enabled = false;
        }

        private void unhold() //functions to unhold the dice
        {
            if (!hold1)
                btnHold1_Click(sender, e);
            if (!hold2)
                btnHold2_Click(sender, e);
            if (!hold3)
                btnHold3_Click(sender, e);
        }

        private void compTurn() //functions for computer player -- auto rolling the dice
        {
            btnRoll.Enabled = false;//disable the roll button to prevent clicking of the player
            //loop for the computer to roll 3 times for one round
            for (a = 0; a < 3; a++)
            {
                btnRoll_Click(sender, e);//clicking the roll button
                //computer will hold the dice if the value equals to the round number
                if (iDiceNo1 == iRound2 && a < 3) //computer can hold dice 1
                {
                    btnHold1_Click(sender, e); 
                    lblMsg.Text += "  Computer holds dice 1";
                }
                if (iDiceNo2 == iRound2 && a < 3) //computer can hold dice 2
                {
                    btnHold2_Click(sender, e);
                    lblMsg.Text += "  Computer holds dice 2";
                }
                if (iDiceNo3 == iRound2 && a < 3) //computer can hold dice 3
                {
                    btnHold3_Click(sender, e);
                    lblMsg.Text += "  Computer holds dice 3";
                }
                //to delay the steps of the computer so that player 1 can see what's happening
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
            }
            btnNextRoundP2_Click(sender, e);  //click the next round button after rolling 3 times         
        }

        private void btnNextRoundP1_Click(object sender, EventArgs e) //next round button for player one
        {
            if (iRound <= 5)  //when user hits the round 6 of player 1
            {
                buttonsDisable(); //disable the button
                iBonus = 0; //bonus score will become zero
                iRoundScore = calculateRoundScore(ascendingDiceValue, iRound); //call the functions to calculate the round score
                tbxOutput1.Text += "                                                           " + iRoundScore + "\r\n"; //to show the output for round score
                iGameScore += iRoundScore; //plus the game score of roundscore
                tbxP1Score.Text = iGameScore.ToString(); //to show the game score in textbox
                iRound++; //round increment by 1
                btnRoll.Enabled = true; //roll button is enabled
                btnRoll.Text = "Roll"; 
                lblMsg.Text = ""; //label message is empty
                iRoundScore = 0; //round score will become zero
                
                iRoll = 1; //when the user finished one 
            }
            else
            {
                if (p1 == true) //if player one is true
                {
                    btnRoll.Enabled = false; //roll button is disabled
                    btnNextRoundP2.Enabled = false; //next round button for player 2 is disabled
                    iRoundScore = calculateRoundScore(ascendingDiceValue, iRound); //call the functions to calculate the round score
                    tbxOutput1.Text += "                                                           " + iRoundScore + "\r\n"; //to show the output for roundscore
                    iGameScore += iRoundScore; //add the game score from the roundscore
                    tbxP1Score.Text = iGameScore.ToString(); // to show the gamescore
                    lblMsg.Text = tbxPlayer1.Text+ " wins- but that's easy in a 1-player game!"; //to show when the player one is wins the game
                }
                else
                {
                    btnRoll.Enabled = true; //roll button is disabled
                    btnNextRoundP1.Enabled = false; //next round button for player 1 is disabled
                    btnRoll.Text = "Roll";
                    iRoll = 1;
                    iRoundScore = calculateRoundScore(ascendingDiceValue, iRound); //call the functions to calculate the round score
                    tbxOutput1.Text += "                                                           " + iRoundScore + "\r\n"; //to show the output for roundscore
                    iGameScore += iRoundScore; //add the game score from the roundscore
                    tbxP1Score.Text = iGameScore.ToString(); //to show the game score
                }
            }
            if (p1 == false) //if player two turn the game
            {
                panel1.Enabled = false; 
                panel2.Enabled = true;
                tbxGameFeed.Text += tbxPlayer2.Text + " turns \r\n"; //show in the game feeds textbox player two start the game
            }
            if (!comp) //if computer turn the game
            {
                buttonsDisable(); 
                compTurn(); 
                unhold(); 
            }
        }

        private void btnRoll_Click(object sender, EventArgs e) //roll the button
        {
            if (iRoll <= 3) //if roll less than 4
            {
             
                if (!hold1 && !hold2 && !hold3) //cannot hold the dice when first rolling
                {
                    if (panel1.Enabled == true) //to show the panel 
                    {
                        unhold(); //to unhold the dice
                        btnNextRoundP1_Click(sender, e);

                    }
                    else
                    {
                        btnNextRoundP2_Click(sender, e);
                        unhold();
                    }
                }
                else
                {
                    lblMsg.Text = "";
                    btnRoll.Text = "Roll " + iRoll; //to show how many roll in roll button
                    
                    if (comp || panel1.Enabled == true) //when computer turn the game
                    {
                        btnHold1.Enabled = true;
                        btnHold2.Enabled = true;
                        btnHold3.Enabled = true;
                    }
                    
                    for (int n = 0; n < 8; n++) //use for loop to roll the dice eight times
                    {
                        if (hold1) 
                            iDiceNo1 = randomDice.Next(1, 7);
                        if (hold2)
                            iDiceNo2 =  randomDice.Next(1, 7);
                        if (hold3)
                            iDiceNo3 =  randomDice.Next(1, 7);
                        drawDie(graPaper[0], iDiceNo1); 
                        drawDie(graPaper[1], iDiceNo2);
                        drawDie(graPaper[2], iDiceNo3);
                        //to delay the steps of the rolling dice so that player's can see what's happening
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(70);
                    }
                    ascendingDiceValue = new int[3] { iDiceNo1, iDiceNo2, iDiceNo3 }; //to store the dice number 1,2,3 into an array
                    ascending(ascendingDiceValue); //call the functions to make the value is ascending
                    iBonus += calculateSequenceBonus(ascendingDiceValue); //call the calculateSequenceBonus functions               
                    if (panel1.Enabled == true)
                    {
                        if (hold1 && hold2 && hold3)
                            iBonus += calculateLurgitBonus(ascendingDiceValue, iRound); //to plus with the bonus scoring number
                        lblRound1.Text =iRound.ToString(); //to show the round number
                        btnNextRoundP1.Enabled = true;
                        if (iBonus == 0)
                            tbxOutput1.Text += "      " + iRound + "           " + iRoll + "             " + ascendingDiceValue[0] + "," + ascendingDiceValue[1] + "," + ascendingDiceValue[2] + "\r\n"; //to show when there is no bonus
                        else
                            tbxOutput1.Text += "      " + iRound + "           " + iRoll + "             " + ascendingDiceValue[0] + "," + ascendingDiceValue[1] + "," + ascendingDiceValue[2] + "                                    " + iBonus + "\r\n"; //to show when there is a bonus
                        iGameScore += iBonus; //bonus plus with the game score
                    }
                    else
                    {
                        if (hold1 && hold2 && hold3)
                            iBonus += calculateLurgitBonus(ascendingDiceValue, iRound2); //to call the calculateLurgItBonus functions
                        if (!comp && iBonus == 20)
                            a = 3;
                        lblRound2.Text =  iRound2.ToString(); //show the round number
                         btnNextRoundP2.Enabled = true;
                        if (iBonus == 0)
                            tbxOutput2.Text += "       " + iRound2 + "          " + iRoll + "             " + ascendingDiceValue[0] + "," + ascendingDiceValue[1] + "," + ascendingDiceValue[2] + "\r\n"; //to show when there is no lurgit bonus
                        else
                            tbxOutput2.Text += "       " + iRound2 + "          " + iRoll + "             " + ascendingDiceValue[0] + "," + ascendingDiceValue[1] + "," + ascendingDiceValue[2] + "                                    " + iBonus + "\r\n"; //to show when there is a lurgit bonus
                        iGameScore2 += iBonus; //bonus plus with the game score
                    }
                    iBonus = 0; //bonus start from zero
                    tbxP1Score.Text = iGameScore.ToString(); //to show the player one score
                    iRoll++; //roll increase by 1
                    unhold(); //unhold the dice
                }
            }
            else
            {
                btnRoll.Enabled = false; //to make the roll button disabled
                lblMsg.Text = "Please proceed to the next round.You have reached the maximum rolls for this round\r\n"; //to show the message when user reached third rolling button

            }

        }
        private void btnNextRoundP2_Click(object sender, EventArgs e) //next button for player 2
        {
            if (iRound2 <= 5) //when user hits the round 6 for player 2
            {
                buttonsDisable(); //disabled the button
                iBonus = 0; //bonus start from zero
                iRoundScore = calculateRoundScore(ascendingDiceValue, iRound2); //call the functions for ascending the dice number
                tbxOutput2.Text += "                                                            " + iRoundScore + "\r\n"; //to show the roundscore
                iGameScore2 += iRoundScore; //plus with the roundscore from gamescore
                tbxP2Score.Text = iGameScore2.ToString(); //to show the game score of player two
                iRound2++; //round2 increment by one
                btnRoll.Enabled = true; //to enabled the roll button
                btnRoll.Text = "Roll";
                lblMsg.Text = "";
                iRoundScore = 0; //round score start from zero
                lblRound1.Text =  iRound2.ToString(); //to show the round number
                iRoll = 1; //roll start from 1
                panel1.Enabled = true;
                panel2.Enabled = false;
                tbxGameFeed.Text+= tbxPlayer1.Text + " turns \r\n"; //to show the player turns 
            }
            else
            {
                btnRoll.Enabled = false; //disable the roll button
                btnNextRoundP2.Enabled = false; //disable the next round button
                iRoundScore = calculateRoundScore(ascendingDiceValue, iRound2);
                tbxOutput2.Text += "                                                            " + iRoundScore + "\r\n"; //to calculate the round score
                iGameScore2 += iRoundScore; //plus with the roundscore of gamescore
                tbxP2Score.Text = iGameScore2.ToString(); //to show the player two score
                panel1.Enabled = true;
         
                if (iGameScore > iGameScore2)
                    MessageBox.Show(tbxPlayer1.Text + " wins", "Congratulations"); //if player one wins the game
                else if (iGameScore < iGameScore2)
                    MessageBox.Show(tbxPlayer2.Text + " wins", "Congratulations"); //if player two wins the game
                else
                    MessageBox.Show("Draw", "Lurgit Dice Game"); //if player 1 and player 2 same score
                panel1.Enabled = true;
            }

        }

        public EventArgs e { get; set; }

        public object sender { get; set; }

    }
}
