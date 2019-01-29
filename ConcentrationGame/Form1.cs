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
        String[] cardCharacters = new String[8] {"O", "X", "@", "£", "~", "#", "<", ">"};
        Button[,] btn = new Button[4, 4];
        Button firstClicked, secondClicked;
        public Concentration()
        {
            InitializeComponent();
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
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
        }

        private void assignValues()
        {
            Random r = new Random();
            for (int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    bool accepted = false;
                    while (!accepted)
                    {
                        int x = r.Next(0, 4);
                        int y = r.Next(0, 4);

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

            //Checks if first and second buttons clicked are same
            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                //If buttons aren't the same, starts timer
                timer.Start();
        }

        //Timer that allows player some time to look at cards before they disappear again, so player can try to memorize cards he just clicked
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
