﻿namespace snake
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.NewGame = new System.Windows.Forms.Button();
            this.Records = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.aBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recBox = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(175, 253);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Records
            // 
            this.Records.Location = new System.Drawing.Point(175, 282);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(75, 23);
            this.Records.TabIndex = 1;
            this.Records.Text = "Records";
            this.Records.UseVisualStyleBackColor = true;
            this.Records.Click += new System.EventHandler(this.Records_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(175, 311);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(75, 23);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(175, 340);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // aBox
            // 
            this.aBox.Enabled = false;
            this.aBox.Location = new System.Drawing.Point(383, 180);
            this.aBox.Multiline = true;
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(172, 282);
            this.aBox.TabIndex = 4;
            this.aBox.Text = resources.GetString("aBox.Text");
            this.aBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(89, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 514);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // recBox
            // 
            this.recBox.Enabled = false;
            this.recBox.Location = new System.Drawing.Point(383, 180);
            this.recBox.Multiline = true;
            this.recBox.Name = "recBox";
            this.recBox.Size = new System.Drawing.Size(172, 282);
            this.recBox.TabIndex = 6;
            this.recBox.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 611);
            this.Controls.Add(this.recBox);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Records;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox recBox;
        private System.Windows.Forms.Timer timer2;
    }
}