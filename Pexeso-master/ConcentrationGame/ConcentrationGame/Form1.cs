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
    public partial class Form1 : Form
    {
        String[] cardCharacters = new String[8] {"O", "X", "@", "£", "~", "#", "<", ">"};
        Button[,] btn = new Button[4, 4];
        public Form1()
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

        void assignValues()
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
                            accepted = true;
                        }
                    }
                }
                }
        }
        void btnEvent_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
