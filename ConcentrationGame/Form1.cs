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
    public partial class Menu : Form
    {
        
        Button startGame = new Button();
        Button startGame2 = new Button();

        public Menu()
        {
            InitializeComponent();

            startGame.Text = "Start 4x4 grid";
            startGame.Click += new EventHandler(this.startGameEvent_Click);

            

            startGame2.Text = "Start 6x6 grid";
            startGame2.Click += new EventHandler(this.startGame2Event_Click);
            startGame2.Location = new Point(400, 10);


            Controls.Add(startGame);
            Controls.Add(startGame2);


        }

        void startGameEvent_Click(object sender, EventArgs e)
        {
           
            Concentration gameForm = new Concentration(4, 4);
            gameForm.Show();
        }

        void startGame2Event_Click(object sender, EventArgs e)
        {

            Concentration gameForm = new Concentration(6, 6);
            gameForm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
            


}
    }




    
