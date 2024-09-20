using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quoridor_v2.Exceptions
{
    internal class GameOverException : Exception
    {
        public GameOverException() : base("Game over!") { }
    }
}
