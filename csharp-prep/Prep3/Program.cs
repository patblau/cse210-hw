using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ciao Prep3 World!");

        //invite to play and retrieve a number
        Console.WriteLine("Lets play the magig number game, shall we?");
        Console.WriteLine("I will pick a number and you can guess what it is.");
        Console.Write("Retrieve a magical number: ");

        int mgcNmbr = int.Parse(Console.ReadLine());

        //respond higher and lower
        if (guess < mgcNmbr)
            Console.WriteLine("Higher");
        else if (guess > mgcNmbr)
            Console.WriteLine("Lower");
        else
            Console.WriteLine("Wow! You Guessed it!");

        
    }
}