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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            using (StreamWriter incdate = File.AppendText("Records.txt"))
            {
                incdate.Write(textBox1.Text);
            }
            Form1 frm = new Form1();
            frm.Show();
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Records.txt", string.Empty);

        }
    }
}
