using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quoridor_v2.Exceptions
{
    internal class NotPossibleMoveException : Exception
    {
        public NotPossibleMoveException()
            : base("Can't move to the given direction. Expected position is too far from player.") { }
    }
}
