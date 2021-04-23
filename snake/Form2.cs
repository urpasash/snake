﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            Hide();
        }

        private void Records_Click(object sender, EventArgs e)
        {
            timer1.Enabled = (timer1.Enabled) ? false : true;
            if (timer1.Enabled == true)
            {
                recBox.Text = File.ReadAllText("Records.txt");
                recBox.Visible = true;
            }
            else
            {
                recBox.Visible = false;
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            timer1.Enabled = (timer1.Enabled) ? false : true;
            if (timer1.Enabled == true)
            {
                recBox.Text = File.ReadAllText("About.txt");
                recBox.Visible = true;
            }
            else
            {
                recBox.Visible = false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}