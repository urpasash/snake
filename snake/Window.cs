using System;
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
    public partial class Window: Form
    {
        bool flag;
        public Window()
        {
            InitializeComponent();
            recBox.Visible = false;
            aBox.Visible = false;
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Username frm = new Username();
            frm.Show();
            Hide();
        }

        private void Records_Click(object sender, EventArgs e)
        {
            timer2.Enabled = (timer2.Enabled) ? false : true;
            if (timer2.Enabled == true)
            {
                switch (flag)
                {
                    case true:
                        flag = false;
                        File.WriteAllText("Rec",recBox.Text);
                        break;
                    case false:
                        recBox.Text = File.ReadAllText("Rec");
                        break;

                }
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
                aBox.Visible = true;
            }
            else
            {
                aBox.Visible = false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
