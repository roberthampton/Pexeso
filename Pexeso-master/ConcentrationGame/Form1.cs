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
        CheckBox easyBox = new CheckBox();
        CheckBox hardBox = new CheckBox();

        public Menu()
        {
            InitializeComponent();

            startGame.Text = "Start Game";
            startGame.Click += new EventHandler(this.StartGameEvent_Click);
            Controls.Add(startGame);

            easyBox.Text = "Easy";
            easyBox.Left = 20;
            easyBox.Top = 20;
            easyBox.Width = 300;
            easyBox.Height = 30;
            easyBox.BackColor = Color.Orange;
            easyBox.ForeColor = Color.Black;
            easyBox.Name = "EasyCheckBox";
            easyBox.Font = new Font("Georgia", 12);

            hardBox.Text = "Hard";
            hardBox.Left = 100;
            hardBox.Top = 100;
            hardBox.Width = 300;
            hardBox.Height = 30;
            hardBox.BackColor = Color.Orange;
            hardBox.ForeColor = Color.Black;
            hardBox.Name = "HardCheckBox";
            hardBox.Font = new Font("Georgia", 12);

            Controls.Add(easyBox);
            Controls.Add(hardBox);
        }

        void StartGameEvent_Click(object sender, EventArgs e)
        {
            Concentration easyGame = new Concentration(4, 4);
            Concentration hardGame = new Concentration(6, 6);

            if (easyBox.Checked == true && hardBox.Checked == false)
                easyGame.Show();
           
            if (hardBox.Checked == true && hardBox.Checked == false)
                hardGame.Show();

            if (hardBox.Checked == true && easyBox.Checked == true)
            {
                startGame.Enabled = false;
                MessageBox.Show("Please check only one box");
                easyBox.Checked = false;
                hardBox.Checked = false;
                startGame.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}




    
