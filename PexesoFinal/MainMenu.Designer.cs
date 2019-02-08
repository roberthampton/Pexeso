namespace ConcentrationGame
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hardBtn = new System.Windows.Forms.RadioButton();
            this.medBtn = new System.Windows.Forms.RadioButton();
            this.easyBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.playersLabel = new System.Windows.Forms.Label();
            this.mPlayer = new System.Windows.Forms.RadioButton();
            this.sPlayer = new System.Windows.Forms.RadioButton();
            this.title = new System.Windows.Forms.Label();
            this.noOfPlayers = new System.Windows.Forms.Panel();
            this.difficulty = new System.Windows.Forms.Panel();
            this.categories = new System.Windows.Forms.Panel();
            this.symbols = new System.Windows.Forms.RadioButton();
            this.legends = new System.Windows.Forms.RadioButton();
            this.logos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.howToPlay = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.noOfPlayers.SuspendLayout();
            this.difficulty.SuspendLayout();
            this.categories.SuspendLayout();
            this.SuspendLayout();
            // 
            // hardBtn
            // 
            this.hardBtn.AutoSize = true;
            this.hardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardBtn.ForeColor = System.Drawing.Color.White;
            this.hardBtn.Location = new System.Drawing.Point(3, 74);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(69, 28);
            this.hardBtn.TabIndex = 15;
            this.hardBtn.Text = "Hard";
            this.hardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hardBtn.UseVisualStyleBackColor = true;
            // 
            // medBtn
            // 
            this.medBtn.AutoSize = true;
            this.medBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medBtn.ForeColor = System.Drawing.Color.White;
            this.medBtn.Location = new System.Drawing.Point(3, 40);
            this.medBtn.Name = "medBtn";
            this.medBtn.Size = new System.Drawing.Size(97, 28);
            this.medBtn.TabIndex = 14;
            this.medBtn.Text = "Medium";
            this.medBtn.UseVisualStyleBackColor = true;
            // 
            // easyBtn
            // 
            this.easyBtn.AutoSize = true;
            this.easyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyBtn.ForeColor = System.Drawing.Color.White;
            this.easyBtn.Location = new System.Drawing.Point(3, 6);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(69, 28);
            this.easyBtn.TabIndex = 13;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = true;
            this.easyBtn.CheckedChanged += new System.EventHandler(this.easyBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(349, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Difficulty Level";
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersLabel.ForeColor = System.Drawing.Color.LightGray;
            this.playersLabel.Location = new System.Drawing.Point(12, 175);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(219, 34);
            this.playersLabel.TabIndex = 11;
            this.playersLabel.Text = "Number of Players";
            // 
            // mPlayer
            // 
            this.mPlayer.AutoSize = true;
            this.mPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPlayer.ForeColor = System.Drawing.Color.White;
            this.mPlayer.Location = new System.Drawing.Point(3, 53);
            this.mPlayer.Name = "mPlayer";
            this.mPlayer.Size = new System.Drawing.Size(95, 28);
            this.mPlayer.TabIndex = 10;
            this.mPlayer.Text = "2 Player";
            this.mPlayer.UseVisualStyleBackColor = true;
            // 
            // sPlayer
            // 
            this.sPlayer.AutoSize = true;
            this.sPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPlayer.ForeColor = System.Drawing.Color.White;
            this.sPlayer.Location = new System.Drawing.Point(3, 19);
            this.sPlayer.Name = "sPlayer";
            this.sPlayer.Size = new System.Drawing.Size(95, 28);
            this.sPlayer.TabIndex = 9;
            this.sPlayer.Text = "1 Player";
            this.sPlayer.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(272, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(345, 100);
            this.title.TabIndex = 8;
            this.title.Text = "Pexeso";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // noOfPlayers
            // 
            this.noOfPlayers.Controls.Add(this.sPlayer);
            this.noOfPlayers.Controls.Add(this.mPlayer);
            this.noOfPlayers.Location = new System.Drawing.Point(18, 217);
            this.noOfPlayers.Name = "noOfPlayers";
            this.noOfPlayers.Size = new System.Drawing.Size(112, 100);
            this.noOfPlayers.TabIndex = 16;
            // 
            // difficulty
            // 
            this.difficulty.Controls.Add(this.easyBtn);
            this.difficulty.Controls.Add(this.medBtn);
            this.difficulty.Controls.Add(this.hardBtn);
            this.difficulty.Location = new System.Drawing.Point(355, 215);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(107, 116);
            this.difficulty.TabIndex = 17;
            this.difficulty.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // categories
            // 
            this.categories.Controls.Add(this.symbols);
            this.categories.Controls.Add(this.legends);
            this.categories.Controls.Add(this.logos);
            this.categories.Location = new System.Drawing.Point(649, 215);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(216, 116);
            this.categories.TabIndex = 19;
            // 
            // symbols
            // 
            this.symbols.AutoSize = true;
            this.symbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbols.ForeColor = System.Drawing.Color.White;
            this.symbols.Location = new System.Drawing.Point(3, 6);
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(100, 28);
            this.symbols.TabIndex = 13;
            this.symbols.Text = "Symbols";
            this.symbols.UseVisualStyleBackColor = true;
            this.symbols.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // legends
            // 
            this.legends.AutoSize = true;
            this.legends.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legends.ForeColor = System.Drawing.Color.White;
            this.legends.Location = new System.Drawing.Point(3, 40);
            this.legends.Name = "legends";
            this.legends.Size = new System.Drawing.Size(199, 28);
            this.legends.TabIndex = 14;
            this.legends.Text = "Computing Legends";
            this.legends.UseVisualStyleBackColor = true;
            // 
            // logos
            // 
            this.logos.AutoSize = true;
            this.logos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logos.ForeColor = System.Drawing.Color.White;
            this.logos.Location = new System.Drawing.Point(3, 74);
            this.logos.Name = "logos";
            this.logos.Size = new System.Drawing.Size(170, 28);
            this.logos.TabIndex = 15;
            this.logos.Text = "Language Logos";
            this.logos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(643, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Card Categories";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.LightGray;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(157, 393);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(154, 42);
            this.start.TabIndex = 20;
            this.start.Text = "Start Game";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // howToPlay
            // 
            this.howToPlay.BackColor = System.Drawing.Color.LightGray;
            this.howToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.howToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlay.Location = new System.Drawing.Point(344, 393);
            this.howToPlay.Name = "howToPlay";
            this.howToPlay.Size = new System.Drawing.Size(154, 42);
            this.howToPlay.TabIndex = 21;
            this.howToPlay.Text = "How To Play";
            this.howToPlay.UseVisualStyleBackColor = false;
            this.howToPlay.Click += new System.EventHandler(this.howToPlay_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LightGray;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(536, 393);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(154, 42);
            this.exit.TabIndex = 22;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(879, 460);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.howToPlay);
            this.Controls.Add(this.start);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.noOfPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playersLabel);
            this.Controls.Add(this.title);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.noOfPlayers.ResumeLayout(false);
            this.noOfPlayers.PerformLayout();
            this.difficulty.ResumeLayout(false);
            this.difficulty.PerformLayout();
            this.categories.ResumeLayout(false);
            this.categories.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton hardBtn;
        private System.Windows.Forms.RadioButton medBtn;
        private System.Windows.Forms.RadioButton easyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.RadioButton mPlayer;
        private System.Windows.Forms.RadioButton sPlayer;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel noOfPlayers;
        private System.Windows.Forms.Panel difficulty;
        private System.Windows.Forms.Panel categories;
        private System.Windows.Forms.RadioButton symbols;
        private System.Windows.Forms.RadioButton legends;
        private System.Windows.Forms.RadioButton logos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button howToPlay;
        private System.Windows.Forms.Button exit;
    }
}