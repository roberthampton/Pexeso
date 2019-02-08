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
    public partial class MainMenu : Form
    {
        int x, y, diff, imNum;
        bool singlePlayer, imMode;

        bool accepted = true;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void howToPlay_Click(object sender, EventArgs e)
        {
            HowToPlay htPlay = new HowToPlay();
            htPlay.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void easyBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Performs all the neccessary checks whent the start game button is clicked and if appropriate settings are selected the game is started
        private void start_Click(object sender, EventArgs e)
        {
            //Makes sure that the game cannot start if accepted has been changed to false
            accepted = true;
            if(sPlayer.Checked)
            {
                singlePlayer = true;
            }
            else if(mPlayer.Checked)
            {
                singlePlayer = false;
            }
            else
            {
                accepted = false;
            }

            if (easyBtn.Checked)
            {
                diff = 1;
                x = 4;
                y = 4;
            }
            else if(medBtn.Checked)
            {
                diff = 2;
                x = 6;
                y = 4;
            }
            else if (hardBtn.Checked)
            {
                diff = 3;
                x = 6;
                y = 6;
            }
            else
            {
                accepted = false;
            }

            if (symbols.Checked)
            {
                imMode = false;
                imNum = 1;
            }
            else if (legends.Checked)
            {
                imMode = true;
                imNum = 1;
            }
            else if (logos.Checked)
            {
                imMode = true;
                imNum = 2;
            }
            else
            {
                accepted = false;
            }

            if(!accepted)
            {
                //Displays message if accepted has been changed to false (happens if a section has no selection).
                MessageBox.Show("Please ensure there is a selection for each section.");

            }
            else
            {
                //Game is launched using the settings that have been determined from the radio button selections
                Pexeso newGame = new Pexeso(x, y, singlePlayer, diff, imMode, imNum);
                newGame.Size = new System.Drawing.Size(1000, 1000);
                newGame.Show();
            }
        }
    }
}
