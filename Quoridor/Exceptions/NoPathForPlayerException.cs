using System;
namespace quoridor_v2
{
    internal class NoPathForPlayerException : Exception
    {
        public NoPathForPlayerException() : 
            base ("There is no path to goal for one of the players") { }
    }
}