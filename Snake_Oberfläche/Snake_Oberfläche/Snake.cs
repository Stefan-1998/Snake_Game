using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




enum Directions { Up, Down, Right, Left }

namespace Snake_Oberfläche
{
    class Snake
    {

        public Snake()
        {
            Head_directions = Directions.Left;
            length = 5;
            Tail = new Snaketail();
            Head = new Snakepart(13, 10);

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
                    if (_directions == Directions.Right)
                    {
                        Head_directions = Directions.Right;
                    }
                    else if (_directions == Directions.Left)
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
                    MessageBox.Show("Die Richtung ist fehlerhaft", "Richtungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }
        public void ateApple()
        {
            length++;
            Tail.add_Tailpart(Head.x, Head.y);
        }
        public void move()
        {
            Tail.Parts.RemoveAt(length - 2);      //length-Head-offset   (It starts with 0)
            Tail.add_Tailpart_beginning(Head.x, Head.y);
            switch (Head_directions)
            {

                case Directions.Up:         //Fehlen der Abfrage ob Head am Rand
                    if (Head.y == 0)
                    {
                        Head.y = 28;
                    }
                    else
                    {
                        Head.y = Head.y + 1;
                    }
                    break;

                case Directions.Down:
                    if (Head.y == 19)
                    {
                        Head.y = 0; 
                    }
                    else
                    {
                        Head.y = Head.y - 1;
                    }
                    break;

                case Directions.Right:
                    if (Head.x == 27)
                    {
                        Head.x = 0;
                    }
                    else
                    {
                        Head.x = Head.x + 1;
                    }
                    break;

                case Directions.Left:
                    if (Head.x == 0)
                    { Head.x = 27; }
                    else
                    {
                        Head.x = Head.x - 1;
                    }
                    break;
            }

        }


    }
}
