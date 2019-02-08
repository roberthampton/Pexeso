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
        //Button, Checkbox, and picture/icon variables
        Button startGame = new Button();
        Button howToPlay = new Button();
        CheckBox easyBox = new CheckBox();
        CheckBox medBox = new CheckBox();
        CheckBox hardBox = new CheckBox();
        CheckBox sPlayer = new CheckBox();
        CheckBox multiPlayer = new CheckBox();
        CheckBox legends = new CheckBox();
        CheckBox logos = new CheckBox();
        CheckBox random = new CheckBox();
        PictureBox menuPic = new PictureBox();
        //HowToPlay howTo = new HowToPlay();
        Icon icon = new System.Drawing.Icon("memoryicon.ico");

        /*
         * Method to create main menu - includes checkboxes, buttons, and picture
         */       
        public Menu()
        {
            InitializeComponent();

            //Sets background color to green
            BackColor = Color.DarkRed;
            Size = new Size(500, 900);
            // Display the form in the center of the screen.
            StartPosition = FormStartPosition.CenterScreen;

            /*//Sets attributes of picture on menu
            menuPic.Name = "Menu Image";
            menuPic.SizeMode = PictureBoxSizeMode.StretchImage;
            menuPic.Size = new Size(700, 80);
            menuPic.Location = new Point(50, 30);
            menuPic.Image = Image.FromFile("memory.png");
            Controls.Add(menuPic);*/

            //Sets attributes of title
            TextBox title = new TextBox
            {
                Width = 500,
                Height = 400,
                BackColor = Color.Maroon,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.None,
                Text = "Pexeso",
                Font = new Font("Hiragino Kaku Gothic Std", 50),
                SelectionStart = 0,
                TextAlign = HorizontalAlignment.Center,
                ReadOnly = true,
                Enabled = false,
                Cursor = Cursors.Arrow,
            };
            Controls.Add(title);

            TextBox numOfPlayersText = new TextBox
            {
                Width = 210,
                Height = 50,
                BackColor = Color.Maroon,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.None,
                Text = "Number of Players",
                Font = new Font("Impact", 18),
                SelectionStart = 0,
                TextAlign = HorizontalAlignment.Center,
                ReadOnly = true,
                Enabled = false,
                Cursor = Cursors.Arrow,
                Location = new Point(140, 125),
            };
            Controls.Add(numOfPlayersText);

            TextBox difficulty = new TextBox
            {
                Width = 210,
                Height = 50,
                BackColor = Color.Maroon,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.None,
                Text = "Difficulty Level",
                Font = new Font("Impact", 18),
                SelectionStart = 0,
                TextAlign = HorizontalAlignment.Center,
                ReadOnly = true,
                Enabled = false,
                Cursor = Cursors.Arrow,
                Location = new Point(140, 235),
            };
            Controls.Add(difficulty);

            TextBox cardCategories = new TextBox
            {
                Width = 210,
                Height = 50,
                BackColor = Color.Maroon,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.None,
                Text = "Card Categories",
                Font = new Font("Impact", 18),
                SelectionStart = 0,
                TextAlign = HorizontalAlignment.Center,
                ReadOnly = true,
                Enabled = false,
                Cursor = Cursors.Arrow,
                Location = new Point(140, 350),
            };
            Controls.Add(cardCategories);

            //Sets attributes of "Start Game" buttons
            startGame.Text = "Start Game";
            startGame.Click += new EventHandler(this.StartGameEvent_Click);
            startGame.Left = 75;
            startGame.Top = 780;
            startGame.Height = 50;
            startGame.Width = 150;
            startGame.BackColor = Color.DarkRed;
            startGame.ForeColor = Color.White;
            startGame.Name = "StartButton";
            startGame.Font = new Font("Consolas", 16);
            startGame.FlatAppearance.BorderSize = 2;
            Controls.Add(startGame);

            //Sets attributes of "How To Play" Button
            howToPlay.Text = "How To Play";
            //howToPlay.Click += new EventHandler(this.howToPlayEvent_Click);
            howToPlay.Left = 270;
            howToPlay.Top = 780;
            howToPlay.Height = 50;
            howToPlay.Width = 150;
            howToPlay.BackColor = Color.DarkRed;
            howToPlay.ForeColor = Color.White;
            howToPlay.Name = "HowToButton";
            howToPlay.Font = new Font("Consolas", 16);
            howToPlay.FlatAppearance.BorderSize = 0;
            Controls.Add(howToPlay);

            //Sets attributes of "Easy" Button
            easyBox.Text = "    Easy";
            easyBox.Left = 10;
            easyBox.Top = 285;
            easyBox.Width = 125;
            easyBox.Height = 30;
            easyBox.BackColor = Color.Orange;
            easyBox.ForeColor = Color.Black;
            easyBox.Name = "EasyCheckBox";
            easyBox.Font = new Font("Consolas", 14);
            Controls.Add(easyBox);

            //Sets attributes of "Medium" Button
            medBox.Text = "  Medium";
            medBox.Left = 180;
            medBox.Top = 285;
            medBox.Width = 125;
            medBox.Height = 30;
            medBox.BackColor = Color.Orange;
            medBox.ForeColor = Color.Black;
            medBox.Name = "MedCheckBox";
            medBox.Font = new Font("Consolas", 14);
            Controls.Add(medBox);

            //Sets attributes of "Hard" Button
            hardBox.Text = "    Hard";
            hardBox.Left = 357;
            hardBox.Top = 285;
            hardBox.Width = 125;
            hardBox.Height = 30;
            hardBox.BackColor = Color.Orange;
            hardBox.ForeColor = Color.Black;
            hardBox.Name = "HardCheckBox";
            hardBox.Font = new Font("Consolas", 14);
            Controls.Add(hardBox);

            //Sets attributes of "Single-Player" CheckBox
            sPlayer.Text = "Single-Player";
            sPlayer.Left = 50;
            sPlayer.Top = 175;
            sPlayer.Width = 150;
            sPlayer.Height = 30;
            sPlayer.BackColor = Color.Orange;
            sPlayer.ForeColor = Color.Black;
            sPlayer.Name = "SPlayerCheckBox";
            sPlayer.Font = new Font("Consolas", 14);
            Controls.Add(sPlayer);

            //Sets attributes of "Multi-Player" CheckBox
            multiPlayer.Text = "Multi-Player";
            multiPlayer.Left = 290;
            multiPlayer.Top = 175;
            multiPlayer.Width = 150;
            multiPlayer.Height = 30;
            multiPlayer.BackColor = Color.Orange;
            multiPlayer.ForeColor = Color.Black;
            multiPlayer.Name = "MultiPlayerCheckBox";
            multiPlayer.Font = new Font("Consolas", 14);
            Controls.Add(multiPlayer);

            //Sets attributes of "Legends" CheckBox
            legends.Image = Image.FromFile("turing.jpeg");
            legends.Left = 20;
            legends.Top = 390;
            legends.Width = 220;
            legends.Height = 280;
            legends.BackColor = Color.DarkRed;
            legends.Name = "LegendsCheckBox";
            Controls.Add(legends);

            //Sets attributes of "Logos" CheckBox
            logos.Image = Image.FromFile("java.png");
            logos.Left = 270;
            logos.Top = 390;
            logos.Width = 215;
            logos.Height = 280;
            logos.BackColor = Color.DarkRed;
            logos.Name = "LegendsCheckBox";
            Controls.Add(logos);

            //Sets attributes of "Random" CheckBox
            random.Text = "   Random";
            random.Left = 180;
            random.Top = 700;
            random.Width = 150;
            random.Height = 30;
            random.BackColor = Color.Orange;
            random.ForeColor = Color.Black;
            random.Name = "RandomCheckBox";
            random.Font = new Font("Consolas", 14);
            Controls.Add(random);
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

        /*void howToPlayEvent_Click(object sender, EventArgs e)
        {
            howTo.Show();
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}




    
