using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    enum Direction
    {
        up = 0,
        down = 1,
        left = 2,
        right = 3
    }

    

    internal class Snake : ISnake, IDrawable
    {
        private Direction direction;

        public List<Point> Points { get; } = new List<Point>();

        public Direction Direction { get => direction; 
            set 
            { 
                if (direction == Direction.up && value != Direction.down)
                {
                    direction = value;
                }
                else if (direction == Direction.down && value != Direction.up)
                {
                    direction = value;
                }
                else if (direction == Direction.left && value != Direction.right)
                {
                    direction = value;
                }
                else if (direction == Direction.right && value != Direction.left)
                {
                    direction = value;
                }
            }
        }
        
        public bool Eat(Point food)
        {
            var head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.Sym = head.Sym;
                Points.Add(food);
                food.Clear(Points.First().Sym);
                return true;
            }

            return false;
        }

        internal void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                Direction = Direction.left;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                Direction = Direction.right;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                Direction = Direction.up;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                Direction = Direction.down;
            }
        }

        public Snake(Point tail, int length, Direction direction)
        {
            Direction = direction;
            for (int i = 0; i < length; i++)
            {
                var p = new Point(tail);
                p.Move(i, direction);
                Points.Add(p);
            }
        }

        public void Move()
        {
            var p = Points.First();
            var h = GetNextPoint();
            Points.Remove(p);
            Points.Add(h);
            h.Draw();
            p.Clear();
        }

        private Point GetNextPoint()
        {
            Point head = Points.Last();
            Point nextPoint = new(head);
            nextPoint.Move(1, Direction);
            return nextPoint;
        }

        public void Draw()
        {
            foreach (var drawable in Points)
            {
                drawable.Draw();
            }
        }
    }
}
