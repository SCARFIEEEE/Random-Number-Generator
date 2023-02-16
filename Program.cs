using System;

class Program
{
    static void Main(string[] args)
    {
        Random randommain = new Random();

        int dice1 = randommain.Next(1, 6);
        int dice2 = randommain.Next(1, 6);
        int dice3 = randommain.Next(1, 6);

        Console.WriteLine("dice 1 = " + dice1);
        Console.WriteLine("dice 2 = " + dice2);
        Console.WriteLine("dice 3 = " + dice3);
        Console.ReadLine();

        //first dice

        if (dice1 == 1)
        {
            Console.WriteLine("the first dice has the lowest number");
        }

        else if (dice1 == 6)
        {
            Console.WriteLine();
            Console.WriteLine("The first dice has the highest number");
        }

        else
        {
            Console.WriteLine();
            Console.WriteLine("The first dice is higher than 1 but lower than 6");
        }

        //second dice

        if (dice2 == 1)
        {
            Console.WriteLine();
            Console.WriteLine("the second dice has the lowest number");
        }

        else if (dice2 == 6)
        {
            Console.WriteLine();
            Console.WriteLine("The second dice has the highest number");
        }

        else
        {
            Console.WriteLine();
            Console.WriteLine("The second dice is higher than 1 but lower than 6");
        }

        //third dice

        if (dice3 == 1)
        {
            Console.WriteLine();
            Console.WriteLine("the third dice has the lowest number");
        }

        else if (dice3 == 6)
        {
            Console.WriteLine();
            Console.WriteLine("The third dice has the highest number");
        }

        else
        {
            Console.WriteLine();
            Console.WriteLine("The third dice is higher than 1 but lower than 6");
        }

        //max 1
        Console.WriteLine();
        Console.WriteLine("Enter your lowest (max 1):");
        string randomuser1 = Console.ReadLine();
        int random1 = Convert.ToInt32(randomuser1);

        //max 1,000,000,000
        Console.WriteLine();
        Console.WriteLine("Enter your highest (max 1,000,000,000):");
        string randomuser2 = Console.ReadLine();
        int random2 = Convert.ToInt32(randomuser2);
    
        //What really is random?
        int randomuserinput = randommain.Next(random1, random2);

        Console.WriteLine();
        Console.WriteLine("Your random number is = " + randomuserinput);
    }
}