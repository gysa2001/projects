using System;

namespace quoridor_v2.Exceptions
{
    internal class WallInterceptsWithOtherWallException : Exception
    {
        public WallInterceptsWithOtherWallException()
            : base("Wall intercepts with other wall.") { }
    }
}