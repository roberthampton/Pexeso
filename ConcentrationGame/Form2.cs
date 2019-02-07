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
        int diff;

        //2D array that the AI uses to log seen cards so that it can guess them later in the game
        String[,] AILog;

        //variables to hold the positions of firstclicked and secondclicked so that the AI can use them to guess those positions again.
        int firstClickedX;
        int firstClickedY;
        int secondClickedX;
        int secondClickedY;


        //Int values to hold the scores for each player
        Int32 player1Score = 0;
        Int32 player2Score = 0;

        //these bools are used to determine whos playing so that the points are allocated correctly
        bool player1Active = true;
        bool player2Active = false;

        Label player1Label;
        Label player2Label;

        bool singlePlayer = false;

        /*
         * The constructor is used to create games with different settings. The first 2 ints represent the width and height of the grid of 'cards'.
         * the bool sPlayer is used to indicate whether the game is single player or not (makes the AI play player 2s turns).
         * the int difficulty shows the difficulty level of the game. 1 = easy. 2 = med. 3 = hard.
         */
        public Concentration(int a, int b, bool sPlayer, int difficulty)
        {
            btn = new Button[a, b];
            singlePlayer = sPlayer;
            diff = difficulty;
            AILog = new string[a, b];

            InitializeComponent();
            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(100 * x, 100 * y, 90, 90);
                    btn[x, y].BackColor = Color.PowderBlue;
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);
                    btn[x, y].Name = "unassigned";
                    btn[x, y].Text = "";
                    Controls.Add(btn[x, y]);

                    //initialises the log 2d array
                    AILog[x, y] = "";
                   
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

            if (singlePlayer == false)
            {
                player2Label.Text = "Player 2: " + p2;
            }
            else
            {
                player2Label.Text = "CPU: " + p2;
            }
           
        }

        /**
         * Assigns every button in the grid a number (between 0 and half the number of buttons minus 1) as a name. Each number is assigned twice, so the buttons
         * are in numbered pairs. The names are then used later to index the arrays in which the items to be matched are held (text/images).
         * */
        private void assignValues()
        {
            int a = btn.GetLength(0);
            int b = btn.GetLength(1);

            int max = ((a * b) / 2) - 1;

            Random r = new Random();
            for (int i = 0; i < max + 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    bool accepted = false;
                    while (!accepted)
                    {
                        int x = r.Next(0, a);
                        int y = r.Next(0, b);

                        if (btn[x, y].Name == "unassigned")
                        {
                            btn[x, y].Name = i.ToString();
                            accepted = true;
                        }
                    }
                }
            }
        }

        /*
         * If the AI is on med or hard difficulty, then it will try to 'remember' guessed postitions. On med, a random number is drawn and the
         * CPU has a 1/2 chance of 'remembering'. on hard, the CPU will always log guesses.
         */
        private void AILogsCards()
        {
            Random r = new Random();

            int num = r.Next(0, 2);

            if(diff == 2)
            {
                if(num == 1)
                {
                    AILog[firstClickedX, firstClickedY] = firstClicked.Name;
                    AILog[secondClickedX, secondClickedY] = secondClicked.Name;
                    MessageBox.Show("Saved " + firstClickedX + firstClickedY + secondClickedX + secondClickedY);
                }
            }

            else if(diff == 3)
            {
                AILog[firstClickedX, firstClickedY] = firstClicked.Name;
                AILog[secondClickedX, secondClickedY] = secondClicked.Name;
            }

        }


        //Checks the selected squares to see if they are a pair. If they are then a point is given to the current player
        //Put this into its own method as it will likely need changes later (eg comparing colours)
        private void checkForPair()
        {
            AILogsCards();
            firstClickedX = 0;
            firstClickedY = 0;
            secondClickedX = 0;
            secondClickedY = 0;

            //Checks if first and second buttons clicked are same
            if ((firstClicked.Text == secondClicked.Text) && (firstClicked != secondClicked))
            {
                firstClicked.Hide();
                secondClicked.Hide();

                if (player1Active)
                    player1Score++;
                else
                    player2Score++;

                firstClicked.Text = "";
                secondClicked.Text = "";
                firstClicked = null;
                secondClicked = null;

                //Makes sure whoever has got the pair will have their score incremented on the 'scoreboard'
                updateScoreLabels();
                //switches to the other players turn
                switchCurrentPlayer();

                //Variable to hold the maximum number of pairs
                int totalScore = (btn.GetLength(0) * btn.GetLength(1)) / 2;
                //Checks to see if the total score is the same as the number of pairs. if so the game is over.
                if ((player1Score + player2Score) == totalScore)
                {
                    gameOver();
                }

            }
            else
            {
                //If buttons aren't the same, starts timer
                timer.Start();

            }
                
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
                if(singlePlayer)
                {
                    MessageBox.Show("The AI is the winner!");

                }
                else
                {
                    MessageBox.Show("Player 2 is the winner!");
                }
                
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

            if(singlePlayer && player2Active)
            {
                AITurn();
            }
        }

        //Plays the AIs turn
        private void AITurn()
        {
            bool accepted = false;

            int a = btn.GetLength(0);
            int b = btn.GetLength(1);
            int arrayPos;

            Random r = new Random();
            int x;
            int y;

            if(checkLogForAPair() == true)
            {
                firstClicked = btn[firstClickedX, firstClickedY];
                secondClicked = btn[secondClickedX, secondClickedY];
                arrayPos = Convert.ToInt32(firstClicked.Name);
                firstClicked.Text = cardCharacters[arrayPos];

                arrayPos = Convert.ToInt32(secondClicked.Name);
                secondClicked.Text = cardCharacters[arrayPos];
            }
            else
            {
                while (!accepted)
                {
                    x = r.Next(0, a);
                    y = r.Next(0, b);

                    firstClicked = btn[x, y];

                    if (firstClicked.Visible)
                    {
                        accepted = true;
                        firstClickedX = x;
                        firstClickedY = y;
                    }
                }

                arrayPos = Convert.ToInt32(firstClicked.Name);
                firstClicked.Text = cardCharacters[arrayPos];

                accepted = false;
                while (!accepted)
                {
                    x = r.Next(0, a);
                    y = r.Next(0, b);
                    secondClicked = btn[x, y];

                    if ((firstClicked != secondClicked) && btn[x, y].Visible)
                    {
                        accepted = true;
                        secondClickedX = x;
                        secondClickedY = y;
                    }
                }

                arrayPos = Convert.ToInt32(secondClicked.Name);
                secondClicked.Text = cardCharacters[arrayPos];
            }
            
            checkForPair();

        }

        /*
         * Checks the log for a pair. Does this by first looping through until it reaches an element which has a value and which's corresponding button
         * is still visible. It then searches to see if it can find a match for this element. if not then it keeps going through.
         */
        private bool checkLogForAPair()
        {
            String pairValue;

            for(int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    if(!(AILog[i,j].Equals("")) && btn[i, j].Visible)
                    {
                        pairValue = AILog[i, j];
                        if(matchExists(pairValue))
                        {
                            firstClickedX = i;
                            firstClickedY = j;
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        //Checks to see if there is a match to an element in the AIs log
        private bool matchExists(string pairValue)
        {
            int count = 0;
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    if ((AILog[i, j].Equals(pairValue)) && (count == 1) && btn[i,j].Visible)
                    {
                        secondClickedX = i;
                        secondClickedY = j;
                        return true;
                    }

                    if (AILog[i, j].Equals(pairValue))
                        count++;
                }
            }

            return false;
        }

        void btnEvent_Click(object sender, EventArgs e)
        {
            //Variable to hold the array position of the character used for the text
            int arrayPos;

            //Stops the player from playing on the AIs turn
            if (singlePlayer && player2Active)
                return;


            //Checks if two buttons have been clicked - makes sure player cannot click more than one button at a time
            if (firstClicked != null && secondClicked != null)
                return;

            Button buttonClicked = sender as Button;

            if (buttonClicked == null)
                return;

            //Checks if button has already been clicked on
            if (buttonClicked.Text != "")
                return;

            //Sets firstClicked button to button currently clicked on
            if (firstClicked == null)
            {
                firstClicked = buttonClicked;
                arrayPos =  Convert.ToInt32(firstClicked.Name);
                firstClicked.Text = cardCharacters[arrayPos];
                return;
            }

            //Set secondClicked button to button currently clicked
            secondClicked = buttonClicked;
            arrayPos = Convert.ToInt32(secondClicked.Name);
            secondClicked.Text = cardCharacters[arrayPos];

            if(singlePlayer)
            {
                for (int i = 0; i < btn.GetLength(0); i++)
                {
                    for (int j = 0; j < btn.GetLength(1); j++)
                    {
                        if(firstClicked == btn[i,j])
                        {
                            firstClickedX = i;
                            firstClickedY = j;
                        }

                        else if(secondClicked == btn[i, j])
                            {
                                secondClickedX = i;
                                secondClickedY = j;
                            }
                    }
                }
            }

            checkForPair();
        }

        //Timer that allows player some time to look at cards before they disappear again, so player can try to memorize cards he just clicked
        private void timer_Tick_1(object sender, EventArgs e)
        {
            timer.Stop();

            firstClicked.Text = "";
            secondClicked.Text = "";

            firstClicked = null;
            secondClicked = null;

            switchCurrentPlayer();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



    }
}
