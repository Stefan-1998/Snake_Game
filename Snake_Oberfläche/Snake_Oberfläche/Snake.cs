using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




enum Directions {Up,Down,Right,Left }

namespace Snake_Oberfläche
{
    class Snake
    {
        
        public Snake()
        {
            Head_directions = Directions.Right;
            length = 5;
            Tail = new Snaketail();
            Head = new Snakepart(13,10);
            
        }
        public Snaketail Tail;
        public Snakepart Head;        
        private int length;
        private Directions Head_directions;
        

        public void changeDirection(Directions _directions)
        {
            switch (Head_directions)
            {
                case Directions.Up:
                    if(_directions==Directions.Right)
                    {
                        Head_directions = Directions.Right;
                    }
                    else if(_directions==Directions.Left)
                    {
                        Head_directions = Directions.Left;
                    }
                    break;
                case Directions.Down:
                    if (_directions == Directions.Right)
                    {
                        Head_directions = Directions.Right;
                    }
                    else if (_directions == Directions.Left)
                    {
                        Head_directions = Directions.Left;
                    }
                    break;
                case Directions.Right:
                    if (_directions == Directions.Up)
                    {
                        Head_directions = Directions.Up;
                    }
                    else if (_directions == Directions.Down)
                    {
                        Head_directions = Directions.Down;
                    }
                    break;

                    
                case Directions.Left:
                    if (_directions == Directions.Up)
                    {
                        Head_directions = Directions.Up;
                    }
                    else if (_directions == Directions.Down)
                    {
                        Head_directions = Directions.Down;
                    }
                    break;

                default:
                    MessageBox.Show("Die Richtung ist fehlerhaft","Richtungsfehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;

            }
        }
        public void ateApple(Snakepart Head)
        {
            length++;
            Tail.add_Tailpart(Head.x,Head.y) ;
        }
    
    
    }
}
