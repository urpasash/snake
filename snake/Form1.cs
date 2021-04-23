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
    public partial class Form1 : Form
    {
        Point[] snake;
        Point food;
        int l;
        string way;
        int s = 40;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            way = "UP";
            l = 3;
            snake = new Point[300];
            for (int i = 0; i < l; i++)
            {
                snake[i].X = 400;
                snake[i].Y = 400 - i * s;
            }
            food.X = s;
            food.Y = s;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if(snake[0].Y <= snake[1].Y)
                    way = "UP";
                    break;
                case Keys.S:
                    if (snake[0].Y >= snake[1].Y)
                        way = "Down";
                    break;
                case Keys.A:
                    if (snake[0].X <= snake[1].X)
                        way = "Left";
                    break;
                case Keys.D:
                    if (snake[0].X >= snake[1].X)
                        way = "Right";
                    break;

            }
            if (e.KeyCode == Keys.ShiftKey)
            {
                timer1.Stop();
            }
            if (e.KeyCode == Keys.ControlKey)
            {
                timer1.Start();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics text = e.Graphics;
            text.DrawString("Score: " + score, new Font("Times New Roman", 12, FontStyle.Regular), new SolidBrush(Color.Black), new PointF(10, 610)) ;
            Graphics gr = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            Point p1 = new Point(0, 0);
            Point p2 = new Point(800,0);
            Point p3 = new Point(800, 600);
            Point p4 = new Point(0, 600);
            gr.DrawLine(p, p1, p2);
            gr.DrawLine(p, p2, p3); 
            gr.DrawLine(p, p3, p4); 
            gr.DrawLine(p, p4, p1);
            Graphics Food = e.Graphics;
            Food.FillEllipse(new SolidBrush(Color.Red), food.X, food.Y, s, s);
            Graphics Snake = e.Graphics;
            for (int i = 0; i < l; i++)
            {
                Snake.FillEllipse(new SolidBrush(Color.Black), snake[i].X, snake[i].Y, s, s);
            }
            for (int i = 298; i >= 0; i--)
            {
                snake[i + 1].X = snake[i].X;
                snake[i + 1].Y = snake[i].Y;
            }
            if (way == "UP")
            {
                    snake[0].X = snake[1].X;
                    snake[0].Y = snake[1].Y - s;
            }
            if (way == "Down")
            {
                    snake[0].X = snake[1].X;
                    snake[0].Y = snake[1].Y + s;
            }
            if (way == "Left")
            {
                    snake[0].X = snake[1].X - s;
                    snake[0].Y = snake[1].Y;
            }
            if (way == "Right")
            {
                    snake[0].X = snake[1].X + s;
                    snake[0].Y = snake[1].Y;
            }
            
            if (snake[0].X == food.X && snake[0].Y == food.Y)
            {
                l++;
                Random r = new Random();
                food.X = r.Next(0, 20) * s;
                food.Y = r.Next(0, 15) * s;
                score++;

            }
            for (int i = 1; i < l; i++)
            {
                if (snake[i].X == food.X && snake[i].Y == food.Y)
                {
                    Random r = new Random();
                    food.X = r.Next(0, 20) * s;
                    food.Y = r.Next(0, 15) * s;
                    score++;
                }
            }
            Restrictions();
        }
        private void Restrictions()
        {
            if (snake[0].X+s > 800 || snake[0].Y+s > 600 || snake[0].X < 0  || snake[0].Y < 0)
            {
                DialogResult result = MessageBox.Show("GAMEOVER. Вы хотите выйти?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                     Application.Exit();
                    using (StreamWriter txt = File.AppendText("Rec"))
                    {
                        txt.WriteLine("   Score: " + score, '\n');
                    }
                }
                else
                {
                    Application.Restart();
                    using (StreamWriter txt = File.AppendText("Rec"))
                    {
                        txt.WriteLine("   Score: " + score, '\n'); ;
                    }
                }
            }
            if (l > 4)
            {
                for (int i = 4; i < l; i++)
                {
                    if (snake[0].X == snake[i].X && snake[0].Y == snake[i].Y)
                    {
                        DialogResult result = MessageBox.Show("GAMEOVER.Вы хотите выйти?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                               MessageBoxOptions.DefaultDesktopOnly);
                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();
                            using (StreamWriter txt = File.AppendText("Rec"))
                            {
                                txt.WriteLine("   Score: " + score, '\n');
                            }
                        }
                        else
                        {
                            Application.Restart();
                            using (StreamWriter txt = File.AppendText("Rec"))
                            {
                                txt.WriteLine("   Score: " + score, '\n');
                            }
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
