using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class FoodCreator
    {
        int mapWidth;
        int mapHeigth;
        char sym;

        Random rand = new Random();

        public FoodCreator(int mapWidth, int mapHeigth, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeigth = mapHeigth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            return new Point(rand.Next(2,mapWidth-2), rand.Next(2, mapHeigth - 2), sym);
        }
    }
}
