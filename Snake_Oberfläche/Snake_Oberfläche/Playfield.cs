using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Oberfläche
{
    public partial class Playfield_main : Form
    {
        Graphics field;
        Snake snake;
        
        public Playfield_main()
        {
            InitializeComponent();
            field = Playfield_wf.CreateGraphics();
            snake = new Snake();
        }

        
        private void draw_grid(Graphics playfield)
        {
            
            var pen = new Pen(Color.Black, 1);
            //Horizontal
            for (int i = 0; i < 21; i++)
            {
                playfield.DrawLine(pen, 0, i*25, 700, i*25);
            }
            for (int i = 0; i < 29; i++)
            {
                playfield.DrawLine(pen, i*25,0,i*25,500);
            }
            pen.Dispose();
        }
        
        private void draw_snake(Graphics g, Snake s )
        {
            //draw Head
            SolidBrush brush= new SolidBrush(Color.Red);
            g.FillEllipse(brush, s.Head.x*25, s.Head.y*25, 24, 24);
            
            
            brush.Dispose();

        }

        private void Playfield_Tick(object sender, EventArgs e)
        {
            
            field.Clear(Color.Silver);
            draw_grid(field);
            draw_snake(field, snake);
        }

        private void Movementtimer_Tick(object sender, EventArgs e)
        {
            ;
        }
    }
}
