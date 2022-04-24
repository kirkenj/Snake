namespace Snake
{
    enum Arrangement
    {
        Horisontal = 1,
        Vertical = 2
    }
    internal class Line : Point, ILine, IDrawable
    {
        private int _length;
        public Arrangement Arrangement { get; set; }
        int ILine.Length { get => _length; set => _length = value > 0 ? value : _length; }
        public Line(Point point, int len, Arrangement arrangement = Arrangement.Horisontal)
        {
            X = point.X;
            Y = point.Y;
            _length = len;
            Sym = point.Sym;
            Arrangement = arrangement;
        }
        public new void Draw()
        {
            if (Arrangement == Arrangement.Horisontal)
            {
                for (int i = 0; i < _length; i++)
                {
                    Console.SetCursorPosition(X + i, Y);
                    Console.Write(Sym);
                }
            }
            else
            {
                for (int i = 0; i < _length; i++)
                {
                    Console.SetCursorPosition(X, Y + i);
                    Console.Write(Sym);
                }
            }
        }
        public new bool IsHit(Point point)
        {
            if (Arrangement == Arrangement.Horisontal)
            {
                for (int i = 0; i < _length; i++)
                {
                    if (point.X == X + i && point.Y == Y)
                        return true;
                }
            }
            else
            {
                for (int i = 0; i < _length; i++)
                {
                    if (point.X == X && point.Y == Y + i)
                        return true;
                }
            }

            return false;
        }
    }
}