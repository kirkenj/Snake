using Snake;


const char borderChar = '#';
const char snakeChar = '*';
const char foodChar = '$';
Point p4 = new(15, 15, snakeChar);
Snake.Snake sn = new(p4, 5, Direction.right);
Wall walls = new(80, 25, borderChar);
FoodCreator FoodCreator = new (80,25, foodChar);
var food = FoodCreator.CreateFood();
food.Draw();
walls.Draw();
while (true)
{
    if (sn.IsHitTail() || walls.IsHit(sn.GetNextPoint()))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("GAME OVER");
        Console.ResetColor();
        break;
    }

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


