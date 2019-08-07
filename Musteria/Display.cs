using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace Musteria
{
    public class Display
    {
        public static void Map(LandType[,] map)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int t = 0; t < map.GetLength(1); t++) //⬛
                {
                    if (map[i, t].Type == 2)
                    {
                        Console.Write(".", Color.LightBlue);
                        Console.Write(" ");
                    }
                    else if (map[i, t].Type == 1)
                    {
                        Console.Write(":", Color.FromArgb(250, 124, 38));
                        Console.Write(" ");
                    }
                    else if (map[i, t].Type == 3)
                    {
                        Console.Write("ϔ", Color.LightGreen);
                        Console.Write(" ");
                    }
                    else if (map[i, t].Type == 4)
                    {
                        Console.Write("⬛", Color.OrangeRed);
                        Console.Write(" ");
                    }
                    else if (map[i, t].Type == 5)
                    {
                        Console.Write("⬛", Color.SandyBrown);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
