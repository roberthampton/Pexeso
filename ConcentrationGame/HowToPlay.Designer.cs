namespace ConcentrationGame
{
    partial class HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.rulesText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.ForeColor = System.Drawing.Color.White;
            this.titleTextBox.Location = new System.Drawing.Point(209, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(631, 48);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TabStop = false;
            this.titleTextBox.Text = "How To Play Pexeso";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rulesText
            // 
            this.rulesText.BackColor = System.Drawing.Color.DarkGreen;
            this.rulesText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rulesText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesText.Location = new System.Drawing.Point(28, 86);
            this.rulesText.Multiline = true;
            this.rulesText.Name = "rulesText";
            this.rulesText.Size = new System.Drawing.Size(658, 324);
            this.rulesText.TabIndex = 1;
            this.rulesText.TabStop = false;
            this.rulesText.Text = resources.GetString("rulesText.Text");
            this.rulesText.TextChanged += new System.EventHandler(this.rulesText_TextChanged);
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1081, 559);
            this.Controls.Add(this.rulesText);
            this.Controls.Add(this.titleTextBox);
            this.Name = "HowToPlay";
            this.Text = "HowToPlay";
            this.Load += new System.EventHandler(this.HowToPlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox rulesText;
    }
}