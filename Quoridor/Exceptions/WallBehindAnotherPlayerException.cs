using System;

namespace quoridor_v2.Exceptions
{
    internal class WallBehindAnotherPlayerException : Exception
    {
        public WallBehindAnotherPlayerException()
            : base("There is a wall behind another player on the way.") { }
    }
}