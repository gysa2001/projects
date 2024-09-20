using System;

namespace quoridor_v2.Exceptions
{
    internal class WallIsBeyondBoardException : Exception
    {
        public WallIsBeyondBoardException() : base("Wall position is beyond board.") { }
    }
}