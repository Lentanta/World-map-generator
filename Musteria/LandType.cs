using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musteria
{
    public class LandType
    {
        int type;
        public int Type { get => type; set => type = value; }
        public LandType()
        {}
        public LandType(int Type)
        {
            type = Type;
        }
    }
}
