// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lets play Coordinate game!");


Random random = new Random();

bool continue1 = true;

while (continue1)
{
    int x = random.Next(-3, 3);
    int y = random.Next(-3, 3);
    {
        if (x == 0 && y == 0)
        {
            Console.WriteLine("The enemy is Here you lost!");
            Console.ReadKey();
            break;
            
        }
        else if (x < 0 && y > 0)
            Console.WriteLine("NW");
        else if (x < 0 && y == 0)
            Console.WriteLine("W");
        else if (x < 0 && y < 0)
            Console.WriteLine("SW");

        else if (x == 0 && y > 0)
            Console.WriteLine("N");
        else if (x == 0 && y < 0)
            Console.WriteLine("S");
        else if (x > 0 && y > 0)
            Console.WriteLine("NE");
        else if (x > 0 && y < 0)
            Console.WriteLine("NE");
        else if (x > 0 && y == 0)
            Console.WriteLine("E");
        else
        {
            Console.WriteLine("Enemy is vanished, You won");
        }
        Console.WriteLine("If you want to continue press 'y'");
        string userAsk = Console.ReadLine().ToLower();
        if (userAsk != "y")
            continue1 = false;
    }
}
    
    
   
    




