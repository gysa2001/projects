using System;

namespace quoridor_v2.Exceptions
{
    internal class JumpOverTwoPlayersException : Exception
    {
        public JumpOverTwoPlayersException()
            : base("Cannot jump over two players.") { }
    }
}