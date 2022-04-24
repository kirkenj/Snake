using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Wall : IHitable, IDrawable
    {
        public Wall (int width, int heigth, char borderChar)
        {
            Lines = new()
            {
                new Line(new Point(0, 0, borderChar), 80, Arrangement.Horisontal),
                new Line(new Point(0, 0, borderChar), 25, Arrangement.Vertical),
                new Line(new Point(0, heigth - 1, borderChar), 80, Arrangement.Horisontal),
                new Line(new Point(width - 1, 0, borderChar), 25, Arrangement.Vertical)
            };
        }
        List<ILine> Lines { get; set; }
        public void Draw() => Lines.ForEach(line => line.Draw());
        public bool IsHit(Point point)
        {
            foreach (ILine line in Lines)
            {
                if (line.IsHit(point))
                    return true;
            }

            return false;
        }
    }
}
