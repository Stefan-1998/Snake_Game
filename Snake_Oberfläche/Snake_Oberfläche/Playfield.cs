using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Snake_Oberfläche
{
    public partial class Playfield_main : Form
    {
        Graphics field;
        Snake snake;
        Apple apple;

        public Playfield_main()
        {
            InitializeComponent();
            field = Playfield_wf.CreateGraphics();
            snake = new Snake();
            apple = new Apple(ref snake);

        }

        /*Draw-Functions*/

        private void draw_grid(Graphics playfield)
        {
            /*Draws 28x20 Grid*/

            var pen = new Pen(Color.Black, 1);
            //Horizontal
            for (int i = 0; i < 21; i++)
            {
                playfield.DrawLine(pen, 0, i * 25, 700, i * 25);
            }
            for (int i = 0; i < 29; i++)
            {
                playfield.DrawLine(pen, i * 25, 0, i * 25, 500);
            }
            pen.Dispose();
        }

        private void draw_snake(Graphics g, Snake s, Color c)
        {

            SolidBrush brush = new SolidBrush(c);
            //drawHead
            g.FillEllipse(brush, s.Head.x * 25 + 1, s.Head.y * 25 + 1, 23, 23);
            //draw Tail
            if (c == Color.DarkGreen)
            {
                brush.Color = Color.SeaGreen;
            }

            foreach (Snakepart part in s.Tail.Parts)
            {
                g.FillRectangle(brush, part.x * 25 + 2, part.y * 25 + 2, 22, 22);
            }
            brush.Dispose();

        }
        private void draw_Apple(Graphics g)
        {
            //Snake is placed on a 0..27x0..19
            //=>0..559 squares
            int x = 0;
            int y = 0;
            SolidBrush brush = new SolidBrush(Color.Red);
            Random r = new Random(44);
            apple.get_position_x_y(ref x, ref y);


            g.FillEllipse(brush, x * 25+1, y * 25+1, 23, 23);
            brush.Dispose();
        }
        private bool check_Apple_position(int pos)
        {
            return true;
        }

        /*Events*/
        private void Playfield_Tick(object sender, EventArgs e)
        {
            draw_grid(field);
            draw_snake(field, snake, Color.Silver);
            snake.move();
            draw_Apple(field);
            draw_snake(field, snake, Color.DarkGreen);
            apple.apple_eaten(ref snake);
        }

        private void Playfield_main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                snake.changeDirection(Directions.Up);
            }
            if (e.KeyCode == Keys.Down)
            {
                snake.changeDirection(Directions.Down);
            }
            if (e.KeyCode == Keys.Right)
            {
                snake.changeDirection(Directions.Right);
            }
            if (e.KeyCode == Keys.Left)
            {
                snake.changeDirection(Directions.Left);
            }

        }
    }
}
