using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake32
{
    public partial class Form1 : Form
    {
        SolidBrush black_brush;
        SolidBrush white_brush;
        SolidBrush green_brush;
        SolidBrush gray_brush;
        SolidBrush yelow_brush;
        Point[] snake;
        Point apple;
        Point wall;
        Random r;
        int width, height;
        int len = 1;
        int i;


        public Form1()
        {
                r = new Random();
                snake = new Point[10000];
                InitializeComponent();
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                width = pictureBox1.Width / 10;
                height = pictureBox1.Height / 10;
                snake[0].X = width / 2;
                snake[0].Y = height / 2;
                black_brush = new SolidBrush(Color.Black);
                green_brush = new SolidBrush(Color.Green);
                white_brush = new SolidBrush(Color.White);
                gray_brush = new SolidBrush(Color.Gray);
                yelow_brush = new SolidBrush(Color.Yellow);
                apple.X = r.Next(0, width - 1);
                apple.Y = r.Next(0, height - 1);
                wall.X = r.Next(0, width - 1);
                wall.Y = r.Next(0, height - 1);

        }
        string direction = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.FillRectangle(yelow_brush, 0, 0, pictureBox1.Width, pictureBox1.Height);
            g.FillEllipse(white_brush, snake[1].X * 10, snake[1].Y * 10, 10, 10);

            for (i = 0; i < len; i++)
            {

                g.FillEllipse(black_brush, snake[i + 2].X * 10, snake[i + 2].Y * 10, 10, 10);
                if (apple.X == snake[i].X && apple.Y == snake[i].Y)
                {
                    apple.X = r.Next(0, width - 1);
                    apple.Y = r.Next(0, height - 1);
                    len++;


                }
                if (apple.X == wall.X && apple.Y == wall.Y)
                {
                    wall.X = r.Next(0, width - 1);
                    wall.Y = r.Next(0, height - 1);

                }

                if (snake[i].X < 0)
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                    Hide();
                    direction = "";
                    snake[i].X += width;

                }
                if (snake[i].X > width)
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                    Hide();
                    direction = "";
                    snake[i].X -= width;
                }
                if (snake[i].Y < 0)
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                    Hide();
                    direction = "";
                    snake[i].Y += height;
                }
                if (snake[i].Y > height)
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                    Hide();
                    direction = "";
                    snake[i].Y -= height;
                }

            }
            g.FillRectangle(gray_brush, wall.X * 10, wall.Y * 10, 10, 10);
            g.FillEllipse(green_brush, apple.X * 10, apple.Y * 10, 10, 10);
            if (direction == "up") snake[0].Y -= 1;
            if (direction == "down") snake[0].Y += 1;
            if (direction == "left") snake[0].X -= 1;
            if (direction == "right") snake[0].X += 1;
            if (len > 10000 - 3)
            {
                len = 10000 - 3;
            }
            if (wall.X == snake[i].X && wall.Y == snake[i].Y)
            {
                Form2 newForm = new Form2();
                newForm.Show();
                direction = "Up";
                Hide();
            }
            if (len > 4)
            {
                for (i = 1; i < len; i++)
                {
                    for (int J = i + 1; J < len; J++)
                    {
                        if (snake[i].X == snake[J].X && snake[i].Y == snake[J].Y)
                        {
                            len = 3;
                        }
                    }
                }
            }


            for (int i = len + 2; i >= 0; i--)
            {
                snake[i + 1].X = snake[i].X;
                snake[i + 1].Y = snake[i].Y;
            }
            if (len < 4) len++;
            pictureBox1.Invalidate();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                direction = "up";
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                direction = "down";
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                direction = "left";
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                direction = "right";
            }


            

        }

    }

}
   

