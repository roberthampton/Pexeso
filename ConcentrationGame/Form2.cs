using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcentrationGame
{
    public partial class Concentration : Form
    {
        String[] cardCharacters = new String[18] { "O", "X", "@", "£", "~", "#", "<", ">", "1", "g", "+", "=", "_", "{", "!", "]", "*", "%"};
        Button[,] btn;
        Button firstClicked, secondClicked;


        //Int values to hold the scores for each player
        Int32 player1Score = 0;
        Int32 player2Score = 0;

        //these bools are used to determine whos playing so that the points are allocated correctly
        bool player1Active = true;
        bool player2Active = false;

        Label player1Label;
        Label player2Label;

        int globalX;
        int globalY;


        public Concentration(int a, int b)
        {
             btn = new Button[a, b];
            globalX = a;
            globalY = b;

            InitializeComponent();
            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(100 * x, 100 * y, 90, 90);
                    btn[x, y].BackColor = Color.PowderBlue;
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);
                    btn[x, y].Text = "";
                    Controls.Add(btn[x, y]);
                }
            }
            assignValues();
            
            //Labels which will be used to display the scores
            player1Label = new Label();
            player2Label = new Label();

            //As player one will go first, their text is made red. The current players text will be made red and the other players black so it is easy 
            //to follow who is playing at any given time.
            player1Label.BackColor = Color.White;
            player1Label.ForeColor = Color.Red;

            //Makes sure the label is in the right place/is the right size
            player1Label.Location = new Point(400, 10);
            player1Label.Height = 40;
            player1Label.Width = 200;
            player1Label.Font = new Font("Arial", 20, FontStyle.Bold);

            player2Label.BackColor = Color.White;
            player2Label.ForeColor = Color.Black;
            player2Label.Font = new Font("Arial", 20, FontStyle.Bold);

            player2Label.Location = new Point(400, 80);
            player2Label.Height = 40;
            player2Label.Width = 200;

            Controls.Add(player1Label);
            Controls.Add(player2Label);

            //Will set the text of the labels to the current scores (0) 
            updateScoreLabels();
        }

        //Sets the text of the labels to the scores
        private void updateScoreLabels()
        {
            String p1 = Convert.ToString(player1Score);
            String p2 = Convert.ToString(player2Score);

            player1Label.Text = "Player 1: " + p1;
            player2Label.Text = "Player 2: " + p2;
        }

        /**
         * Assigns the values to the grid, using a random number to randomly allocate the characters
         * Loops make sure all 8 characters are allocated, twice each. If the random number picks a 
         * square that already has a value it will loop round again due to the use of the while loop.
         * */
        private void assignValues()
        {
            int noToAssign = (globalX * globalY) / 2;
            Random r = new Random();
            for (int i = 0; i < noToAssign; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    bool accepted = false;
                    while (!accepted)
                    {
                        int x = r.Next(0, globalX);
                        int y = r.Next(0, globalY);

                        if (btn[x, y].Text == "")
                        {
                            btn[x, y].Text = cardCharacters[i];
                            btn[x, y].ForeColor = Color.PowderBlue;
                            accepted = true;
                        }
                    }
                }
            }
        }


        //Checks the selected squares to see if they are a pair. If they are then a point is given to the current player
        //Put this into its own method as it will likely need changes later (eg comparing colours)
        private void checkForPair()
        {
            //Checks if first and second buttons clicked are same
            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked.Hide();
                secondClicked.Hide();

                if (player1Active)
                    player1Score++;
                else
                    player2Score++;

                firstClicked = null;
                secondClicked = null;

                //Makes sure whoever has got the pair will have their score incremented on the 'scoreboard'
                updateScoreLabels();
                //switches to the other players turn
                switchCurrentPlayer();

                //Checks to see if 8 pairs have been found. This need to be changed later when grid is larger. 
                // There might be a smarter way to do this by checking to see if all the boxes are hidden.
                if ((player1Score + player2Score) == 8)
                {
                    gameOver();
                }

            }
            else
                //If buttons aren't the same, starts timer
                timer.Start();
        }

        //Creates a message box to tell the players the result of the game. Could take user input for names and use players actual names later on.
        private void gameOver()
        {
            if (player1Score > player2Score)
            {
                MessageBox.Show("Player 1 is the winner!");
            }

            else if (player2Score > player1Score)
            {
                MessageBox.Show("Player 2 is the winner!");
            }
            else
            {
                MessageBox.Show("It's a draw!");
            }

            Close();
        }

        //Switches which player is currently active and playing. When a player is playing the colour of their score is red to show them its their turn.
        private void switchCurrentPlayer()
        {
            if (player1Active)
            {
                player1Active = false;
                player2Active = true;

                player1Label.ForeColor = Color.Black;
                player2Label.ForeColor = Color.Red;
            }
            else
            {
                player1Active = true;
                player2Active = false;
                player1Label.ForeColor = Color.Red;
                player2Label.ForeColor = Color.Black;
            }
        }

        void btnEvent_Click(object sender, EventArgs e)
        {
            //Checks if two buttons have been clicked - makes sure player cannot click more than one button at a time
            if (firstClicked != null && secondClicked != null)
                return;

            Button buttonClicked = sender as Button;

            if (buttonClicked == null)
                return;

            //Checks if button has already been clicked on
            if (buttonClicked.ForeColor == Color.Black)
                return;

            //Sets firstClicked button to button currently clicked on
            if (firstClicked == null)
            {
                firstClicked = buttonClicked;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            //Set secondClicked button to button currently clicked
            secondClicked = buttonClicked;
            secondClicked.ForeColor = Color.Black;

            checkForPair();


        }

        //Timer that allows player some time to look at cards before they disappear again, so player can try to memorize cards he just clicked
        private void timer_Tick_1(object sender, EventArgs e)
        {
            timer.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;

            switchCurrentPlayer();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



    }
}
