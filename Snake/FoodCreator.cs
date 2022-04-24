using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class FoodCreator
    {
        readonly int mapWidth;
        readonly int mapHeigth;
        readonly char sym;
        readonly Random rand = new();
        public FoodCreator(int mapWidth, int mapHeigth, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeigth = mapHeigth;
            this.sym = sym;
        }
        public Point CreateFood() => new Point(rand.Next(2,mapWidth-2), rand.Next(2, mapHeigth - 2), sym);
    }
}
