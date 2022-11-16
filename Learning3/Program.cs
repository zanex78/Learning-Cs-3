int option;

Console.Write("Please type 1, 2 or 3 for option 1, 2 or 3: ");
option = Convert.ToInt16(Console.ReadLine());

if (option == 1)
{
    Console.WriteLine("Welcome! Tickets are 5$. Pleas insert cash.");
    int cash = Convert.ToInt32(Console.ReadLine());

    if (cash < 5)
    {
        Console.WriteLine("That's not enough money.");
    }
    else if (cash == 5)
    {
        Console.WriteLine("Here is your ticket.");
    }
    else
    {
        int change = cash - 5;
        Console.WriteLine("Here is your ticket and " + change + " dollars in change.");
    }
}
else if (option == 2)
{
    int age;
    int height;
    
    Console.Write("Please input your age: ");
    age = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Please input your height: ");
    height = Convert.ToInt32(Console.ReadLine());

    if (age >= 18 || height >= 160)
    {
        Console.WriteLine("You can enter!");
    }
    else
    {
        Console.WriteLine("You don't meet the requirements.");
    }
    
}
else if (option == 3)
{
    string? t_or_f;
    
    Console.WriteLine("10 * 2 + 3 = 30");
    Console.Write("True of False?: ");
    t_or_f = Convert.ToString(Console.ReadLine());

    if (t_or_f == "False" || t_or_f == "false")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Congratulations!!! Your answer is correct!!!");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Congratulations!!! Your answer is correct!!!");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Congratulations!!! Your answer is correct!!!");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Congratulations!!! Your answer is correct!!!");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Congratulations!!! Your answer is correct!!!");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Congratulations!!! Your answer is correct!!!");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Congratulations!!! Your answer is correct!!!");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Congratulations!!! Your answer is correct!!!");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Congratulations!!! Your answer is correct!!!");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
    else if (t_or_f == "True" || t_or_f == "true")
    {
        Console.WriteLine("Sorry, your answer is incorrect. Better luck next time!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("You have chosen an invalid option!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
else
{
    // Wait before closing.
    Console.Clear();
    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();
}