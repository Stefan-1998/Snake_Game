using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Oberfläche
{
    class Snaketail
    {
        public Snaketail() 
        {
            Tail= new List<Snakepart>();
            this.add_Tailpart(12, 10);
            this.add_Tailpart(11, 10);
            this.add_Tailpart(10, 10);
            this.add_Tailpart(9, 10);
        }
        public List<Snakepart> Tail;
        public void add_Tailpart(int _x, int _y)
        {
            Snakepart t = new Snakepart(_x, _y);
            Tail.Add(t);
        }
        
    }
    class Snakepart
    {
        public int x { get; set; }
        public int y { get; set; }
        public Snakepart(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

    }
}
