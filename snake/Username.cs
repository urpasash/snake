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
    public partial class Username : Form
    {
        public Username()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Введите имя", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                               MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                using (StreamWriter incdate = File.AppendText("Rec"))
                {
                    incdate.Write(textBox.Text);
                }
                Game frm = new Game();
                frm.Show();
                Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Rec", string.Empty);
        }
    }
}
