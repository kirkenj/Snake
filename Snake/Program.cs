using Snake;


const char borderChar = '#';
const char snakeChar = '*';
const char foodChar = '$';


List<Line> borders = new List<Line>();
Point p4 = new Point(3, 3, snakeChar);
var sn = new Snake.Snake(p4, 3, Direction.right);
borders.Add(new Line(new Point(0, 0, borderChar), 80, Arrangement.Horisontal));
borders.Add(new Line(new Point(0, 0, borderChar), 25, Arrangement.Vertical));
borders.Add(new Line(new Point(0, 24, borderChar), 80, Arrangement.Horisontal));
borders.Add(new Line(new Point(79, 0, borderChar), 25, Arrangement.Vertical));
borders.ForEach(b => b.Draw());
FoodCreator FoodCreator = new FoodCreator(80,15, foodChar);
var food = FoodCreator.CreateFood();
food.Draw();

while (true)
{
    if (sn.Eat(food))
    {
        food = FoodCreator.CreateFood();
        food.Draw();
    }
    else
    {
        sn.Move();
    }

    Thread.Sleep(100);
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Escape)
        {
            break;
        }
        sn.HandleKey(key.Key);
    }

}


