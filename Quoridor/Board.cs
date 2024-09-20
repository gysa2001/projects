using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quoridor_v2
{
    public class Board:ICloneable
    {
        public int width = 17;//or 9 for player
        public int height = 17;// or 9 for players
        public TileState[,] tiles;

        public Board()
        {
            tiles = new TileState[width,height];
        }

        public object Clone()
        {
            Board clone = new Board();
            clone.height = height;
            clone.width = width;
            return clone;
        }
    }
}
