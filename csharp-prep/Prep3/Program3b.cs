using System;
using System.Linq.Expressions;
using System.Reflection;								
using System.Runtime.InteropServices;								
								
class Program								
{								
	static void Main(string[] args)							
	{							
		Console.WriteLine("Ciao Prep3 World!");	

        //computer picks random number
        Random randomGenerator = new Random();
        int mgcNumbr = randomGenerator.Next(1, 101);					
								
		//invite to play and retrieve a number 1/100					
		Console.WriteLine("Lets play the magig number game, shall we?");						
		Console.WriteLine("I will pick a number and you can guess what it is.");						
		Console.Write("To play retrieve a magical number: ");						
		int mgcNmbr = int.Parse(Console.ReadLine());						
								
		//have them quess a number						
		Console.Write("Take a guess: ");						
		int guess = int.Parse(Console.ReadLine());						
								
		//loop with responce of higher and lower						
		while (guess != mgcNumbr)
        {
            if (guess < mgcNmbr)						
			    Console.WriteLine("Higher");					
		    else 						
			    Console.WriteLine("Lower");					
		    else						
			    Console.WriteLine("Wow! You Guessed it!");					
	    }

        //responce for wrong answer
        Console.Write("Woops, no. Try again: ");							
    }
}								