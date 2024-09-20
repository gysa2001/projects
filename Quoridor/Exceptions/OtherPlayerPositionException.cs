using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quoridor_v2.Exceptions
{
    internal class OtherPlayerPositionException : Exception
    {
        public OtherPlayerPositionException() :
            base("This direction used by other player!")
        { }
    }
}
