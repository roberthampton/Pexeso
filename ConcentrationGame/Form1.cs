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
        CheckBox medBox = new CheckBox();
        CheckBox hardBox = new CheckBox();
        CheckBox sPlayer = new CheckBox();
        PictureBox menuPic = new PictureBox();

        public Menu()
        {
            InitializeComponent();

            this.BackColor = Color.DarkGreen;

            menuPic.Name = "Menu Image";
            menuPic.SizeMode = PictureBoxSizeMode.StretchImage;
            menuPic.Size = new Size(700, 80);
            menuPic.Location = new Point(50, 30);
            menuPic.Image = Image.FromFile("memory.png");
            Controls.Add(menuPic);

            startGame.Text = "Start Game";
            startGame.Click += new EventHandler(this.StartGameEvent_Click);
            startGame.Left = 335;
            startGame.Top = 300;
            startGame.Height = 30;
            startGame.Width = 100;
            startGame.BackColor = Color.DarkRed;
            startGame.ForeColor = Color.Black;
            startGame.Name = "StartButton";
            startGame.Font = new Font("Georgia", 12, FontStyle.Bold);
            Controls.Add(startGame);

            easyBox.Text = "Easy";
            easyBox.Left = 335;
            easyBox.Top = 150;
            easyBox.Width = 100;
            easyBox.Height = 30;
            easyBox.BackColor = Color.Orange;
            easyBox.ForeColor = Color.Black;
            easyBox.Name = "EasyCheckBox";
            easyBox.Font = new Font("Georgia", 12, FontStyle.Bold);
            Controls.Add(easyBox);

            medBox.Text = "Medium";
            medBox.Left = 335;
            medBox.Top = 200;
            medBox.Width = 100;
            medBox.Height = 30;
            medBox.BackColor = Color.Orange;
            medBox.ForeColor = Color.Black;
            medBox.Name = "MedCheckBox";
            medBox.Font = new Font("Georgia", 12, FontStyle.Bold);
            Controls.Add(medBox);

            hardBox.Text = "Hard";
            hardBox.Left = 335;
            hardBox.Top = 250;
            hardBox.Width = 100;
            hardBox.Height = 30;
            hardBox.BackColor = Color.Orange;
            hardBox.ForeColor = Color.Black;
            hardBox.Name = "HardCheckBox";
            hardBox.Font = new Font("Georgia", 12, FontStyle.Bold);
            Controls.Add(hardBox);
        }

        void StartGameEvent_Click(object sender, EventArgs e)
        {
            Concentration easyGame = new Concentration(4, 4);
            Concentration medGame = new Concentration(6, 4);
            Concentration hardGame = new Concentration(6, 6);

            if (easyBox.Checked == true && medBox.Checked == false && hardBox.Checked == false)
            {
                easyGame.Show();
                this.Hide();
            }

            if (medBox.Checked == true && easyBox.Checked == false && hardBox.Checked == false)
            {
                medGame.Show();
                this.Hide();
            }

            if (hardBox.Checked == true && easyBox.Checked == false && medBox.Checked == false)
            { 
                hardGame.Show();
                this.Hide();
            }

            if(easyBox.Checked == true && medBox.Checked == true || easyBox.Checked == true && hardBox.Checked == true || medBox.Checked == true && hardBox.Checked == true || easyBox.Checked == true && medBox.Checked == true && hardBox.Checked == true)
            { 
                MessageBox.Show("Please check only one box.");
                easyBox.Checked = false;
                medBox.Checked = false;
                hardBox.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}




    
