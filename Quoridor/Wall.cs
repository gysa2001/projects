using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quoridor_v2
{
    public class Wall
    {
        public Point start { get; set; }
        public Point end { get; set; }
        public Wall(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
