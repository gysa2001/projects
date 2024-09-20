using System;

namespace quoridor_v2.Exceptions
{
    internal class PlayerUsedWallsException : Exception
    {
        public PlayerUsedWallsException()
            : base("Not enough walls.") { }
    }
}