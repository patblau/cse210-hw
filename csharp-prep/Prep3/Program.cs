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
		Console.WriteLine("The number will be between 1 and 100.");											
								
		//quess a number						
		Console.Write("Pick a number: ");						
		int guess = int.Parse(Console.ReadLine());						
								
		//loop with responce of higher and lower						
		while (guess != mgcNumbr)
        {
            if (guess < mgcNmbr)						
			    Console.WriteLine("Go higher");					
		    else 						
			    Console.WriteLine("Go lower");					
		   						
		Console.WriteLine("Wow! You Guessed it!");					
	    }

        //responce for wrong answer
        Console.WriteLine("Woops, nope. Try again: ");							
    }
}	