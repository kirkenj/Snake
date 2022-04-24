namespace Snake
{
    internal class Point : IPoint, IDrawable
    {
        private int _x;
        private int _y;
        public Point() { }
        public Point(Point p) 
        { 
            X = p.X;
            Y = p.Y;
            Sym = p.Sym;
        }
        public Point(int x, int y, char sym)
        {
            if (x < 0)
                throw new ArgumentOutOfRangeException(nameof(x));
            if (y < 0)
                throw new ArgumentOutOfRangeException(nameof(y));
            _x = x;
            _y = y;
            Sym = sym;  
        }
        public char Sym { get; set; } = '\0';
        public int X { get { return _x; }  set { if (value > 0) _x = value; } }
        public int Y { get { return _y; } set { if (value > 0) _y = value; } }
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.up)
            {
                Y -= offset;
            }
            else if (direction == Direction.down)
            {
                Y += offset;
            }
            else if (direction == Direction.left)
            {
                X-= offset;
            }
            else
            {
                X += offset;
            }
        }
        public bool IsHit(Point point) => X == point.X && Y == point.Y;
        public void Clear(char setChar = ' ')
        {
            Sym = setChar;
            Draw();
        }
        public override string ToString() => X + ", " + Y + ", " + Sym;
    }
}
