using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;


namespace Musteria
{
    class Program
    {
        static void Main(string[] args)
        {
            var map1 = new Map(100,100);
            var A = map1.RdnWalker(2000);
            Display.Map(A);
        }
    }
}
