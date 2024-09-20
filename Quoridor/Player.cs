using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace quoridor_v2
{
    public class Player: ICloneable
    {
        public Point position;
        public int wallCounter;
        public int goal;

        public Player(Point position, int goal)
        {
            this.position = position;
            wallCounter = 10;
            this.goal = goal;
        }
        public Player() { }

        public object Clone()
        {
            Player clone = new Player();
            clone.position = position;
            clone.wallCounter = wallCounter;
            clone.goal = goal;
            return clone;
        }
    }
}
