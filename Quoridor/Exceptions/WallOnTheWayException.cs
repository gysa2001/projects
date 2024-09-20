using System;

namespace quoridor_v2.Exceptions
{
    internal class WallOnTheWayException : Exception
    {
        public WallOnTheWayException()
            : base("Wall is on the way of movement.") { }
    }
}