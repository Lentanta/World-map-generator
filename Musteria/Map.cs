using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Musteria
{
    class Map
    {
        int width;
        int height;

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Map() { }
        public Map(int Width, int Height)
        {
            width = Width;
            height = Height;
        }
        public string[,] CreateMap() // Tạo ra một map mới Random thường
        {
            var rnd = new Random();
            var newMap = new string[width, height];
            for (int i = 0; i < newMap.GetLength(0); i++)
            {
                for (int t = 0; t < newMap.GetLength(1); t++)
                {
                    //int landType = rnd.Next(1, 3);
                    //if(landType == 1)
                    //{
                    //    newMap[i, t] = "⬛";
                    //} 
                    //else if(landType == 2)
                    //{
                    //    newMap[i, t] = " ";
                    //}
                }
            }
            return newMap;
        }
        public LandType[,] RdnWalker(int tunelLength) // Tạo ra một map mới Random theo Random Walker
        {
            LandType[,] walker = new LandType[width, height];
            var rnd = new Random();
            int x = width / 2;
            int y = height / 2;
            int x1 = rnd.Next(1, width - 1);
            int y1 = rnd.Next(1, height - 1);
            walker[x, y] = new LandType(1);
            walker[x1, y1] = new LandType(1);
            // Tạo ra đất liền
            for (int i = 0; i < tunelLength; i++)
            {
                int direct = rnd.Next(1, 5);
                if (direct == 1 && y != walker.GetLength(0) - 2)
                    y++;
                if (direct == 2 && x != walker.GetLength(1) - 2)
                    x++;
                if (direct == 3 && y != 1)
                    y--;
                if (direct == 4 && x != 1)
                    x--;
                walker[x, y] = new LandType(1);
            }
            // Tạo ra đảo
            for (int i = 0; i < 2000; i++)
            {
                int direct = rnd.Next(1, 5);
                if (direct == 1 && y1 != walker.GetLength(0) - 2)
                    y1++;
                if (direct == 2 && x1 != walker.GetLength(1) - 2)
                    x1++;
                if (direct == 3 && y1 != 1)
                    y1--;
                if (direct == 4 && x1 != 1)
                    x1--;
                walker[x1, y1] = new LandType(1);
            }
            // Tạo ra biển 
            var newMap = new string[width, height];
            for (int i = 0; i < newMap.GetLength(0); i++)
            {
                for (int t = 0; t < newMap.GetLength(1); t++)
                {
                    if (walker[i, t] == null)
                        walker[i, t] = new LandType(2);
                }
            }
            // Tạo ra rừng
            for (int i = 0; i < newMap.GetLength(0); i++)
            {
                for (int t = 0; t < newMap.GetLength(1); t++)
                {
                    int forest = rnd.Next(0, 10);
                    if (forest == 0 && walker[i, t].Type == 1)
                        walker[i, t] = new LandType(3);
                }
            }
            // Tạo ra tòa thành
            for (int i = 0; i < newMap.GetLength(0); i++)
            {
                for (int t = 0; t < newMap.GetLength(1); t++)
                {
                    int castle = rnd.Next(0, 1000);

                    if (castle == 0 && walker[i, t].Type != 2)
                    {
                        walker[i, t] = new LandType(4);
                        walker[i + 1, t] = new LandType(4);
                        walker[i - 1, t] = new LandType(4);
                        walker[i, t + 1] = new LandType(4);
                        walker[i, t - 1] = new LandType(4);
                        walker[i - 1, t - 1] = new LandType(4);
                        walker[i + 1, t - 1] = new LandType(4);
                        walker[i + 1, t + 1] = new LandType(4);
                        walker[i - 1, t + 1] = new LandType(4);
                    }
                }
            }
            // Tạo ra cầu 
            for (int i = 0; i < newMap.GetLength(0); i++)
            {
                for (int t = 0; t < newMap.GetLength(1); t++)
                {
                    if (walker[i, t].Type == 1)
                    {
                        if (walker[i - 1, t].Type == 2
                            && walker[i + 1, t].Type == 2)
                        {
                            walker[i, t] = new LandType(2);
                        }
                        if (walker[i, t + 1].Type == 2
                            && walker[i, t - 1].Type == 2)
                        {
                            walker[i, t] = new LandType(2);
                        }
                    }
                }
            }
            return walker;
        }
    }
}

