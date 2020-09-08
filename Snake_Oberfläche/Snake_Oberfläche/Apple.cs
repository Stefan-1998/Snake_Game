using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Snake_Oberfläche
{
    class Apple
    {
        public Apple(ref Snake s) 
        {
            snake = new Snake();
            snake = s;              //Kann vielleicht zu fehlern führen, ggf. mit Pointer arbeiten oder Pointer übergeben
            Random r = new Random();
            do {
                this.new_position(r);
            } while (!this.check_position(s));
            r = null;
        }
        private int Position; //0-559
        private Snake snake;

        private void new_position(Random r) 
        {
           Position=r.Next(0, 559);
        }
        private bool check_position(Snake s) 
        {
            //returns false if snake and apple are in the same position
            bool dif_pos = true;
            int x=0, y=0;
            get_position_x_y(ref x, ref y);
            if (snake.Head.x == x && snake.Head.y == y) 
            {
                dif_pos = false;
            }
            else 
            {
                foreach(Snakepart p in snake.Tail.Parts)
                {
                    if(p.x==x&&p.y==y)
                    {
                        dif_pos = false;
                    }
                }
            }
           
            return dif_pos;
        }

        public void get_position_x_y(ref int _x, ref int _y) 
        {
            decimal d=Position;
            
           
            _x = Position % 28;
           
            d=Math.Round(d / 28, 0, MidpointRounding.AwayFromZero)-1;
            _y = Decimal.ToInt32(d);
        }

        public void apple_eaten(ref Snake s) 
        {
            bool diff_pos=check_position(s);
            if(diff_pos==false)
            {
                Random r = new Random();
                s.ateApple();
                do
                {
                    this.new_position(r);
                } while (!this.check_position(s));
                r = null;            
            }
        }
        
        
        

       
    }
}
