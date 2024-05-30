using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

class Programm
{
    static void Main()
    {
        int a;
        int b;
        int c;
        Console.WriteLine("Welcome! Choose the mod:");
        Console.WriteLine("1. Limited tries;");
        Console.WriteLine("2. Unlimited tries.");
        a = Convert.ToInt32(Console.ReadLine());
        if (a == 1)
        {
            Console.WriteLine("Write number of tries:");
            a = Convert.ToInt32(Console.ReadLine());
            c = 0;
            Console.WriteLine("Write max number:");
            b = Convert.ToInt32(Console.ReadLine());
            b = GetRandom(b);
            Game(a, b, c);
        }
        else if (a == 2)
        {
            a = Convert.ToInt32(double.PositiveInfinity);
            c = 1;
            Console.WriteLine("Write max number:");
            b = Convert.ToInt32(Console.ReadLine());
            b = GetRandom(b);
            Game(a, b, c);
        }
        else
        {
            Main();
        }
    }
    static int GetRandom(int n)
    {
        Random rnd = new Random();
        int value = rnd.Next(0, n+1);
        return (value);
    }
    static void GameOver(int b)
    {
        Console.WriteLine("Game over.");
        Console.WriteLine($"The number is {b}.");
        Console.WriteLine("Try again?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        if (Convert.ToInt16(Console.ReadLine()) == 1)
        {
            Main();
        }
        else if (Convert.ToInt16(Console.ReadLine()) == 0)
        {
            Environment.Exit(0);
        }
        else 
        {
            Console.WriteLine("Incorrect value. Try again.");
            GameOver(b);
        }
    }
    static void GameWin(int b)
    {
        Console.WriteLine("You're right!");
        Console.WriteLine($"The number is {b}.");
        Console.WriteLine("Try again?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        if (Convert.ToInt16(Console.ReadLine()) == 1)
        {
            Main();
        }
        else if (Convert.ToInt16(Console.ReadLine()) == 0)
        {
            Process.GetCurrentProcess().Kill();
        }
        else
        {
            Console.WriteLine("Incorrect value. Try again.");
            GameWin(b);
        }
    }
    static void Game(int a, int b, int c)
    {
        int i;
        int number;
        Console.WriteLine("Tip: if you want to leave the game, write -1.");
        if (c == 0)
        {
            for (i = 0; i != a; i++)
            {
                if (a - i != 1)
                {
                    Console.WriteLine($"{a - i} tries left");
                }
                else
                {
                    Console.WriteLine("One try left");
                }
                Console.WriteLine("Write your guess number:");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                {
                    GameOver(b);
                }
                else if (number == b)
                {
                    GameWin(b);
                }
                Console.WriteLine("Wrong number!");
                if (number > b)
                {
                    Console.WriteLine("Your number is bigger that random one!");
                }
                else
                {
                    Console.WriteLine("Your number is smaller that random one!");
                }
            }
            GameOver(b);
        }
        else
        {
            while (true)
            {
                Console.WriteLine("Write your guess number:");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                {
                    GameOver(b);
                }
                else if (number == b)
                {
                    GameWin(b);
                }
                Console.WriteLine("Wrong number!");
                if (number > b)
                {
                    Console.WriteLine("Your number is bigger that random one!");
                }
                else
                {
                    Console.WriteLine("Your number is smaller that random one!");
                }
            }
        }
        
    }
}