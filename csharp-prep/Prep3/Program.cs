using System;						
								
class Program															
{								
	static void Main(string[] args)							
	{							
		Console.WriteLine("Ciao Prep3 World!");	

		//invite to play and retrieve a number 1/100					
		Console.WriteLine("Lets play the magic number game, shall we?");						
		Console.WriteLine("I will pick a number and you can guess what it is.");						
		Console.WriteLine("The number will be between 1 and 100.");											
								
		// set up to play again
		string plyAgn = "yes";
		while (plyAgn == "yes")
		{
			//computer picks random number
			Random randomGenerator = new Random();
			int mgcNmbr = randomGenerator.Next(1, 101);					
								
			int guesses = 0; //to count guesses

			//quess a number						
			Console.Write("Pick a number: ");						
			int guess = int.Parse(Console.ReadLine());						
								
			//loop with responce of higher and lower						
			while (guess != mgcNmbr)
			{
				guesses++; // to track guesses 

				if (guess < mgcNmbr)						
					Console.WriteLine("Go higher");					
				else 						
					Console.WriteLine("Go lower");					

				//responce for wrong answer
				Console.WriteLine("Woops, nope. Try again: ");
				guess = int.Parse(Console.ReadLine());		
			}

			guesses++; // count total guesses 

			//End message and count of attempts 
			Console.WriteLine("Wow! You Guessed it!");	
			Console.WriteLine($"It took you {guesses} guesses.");

			Console.Write("Would you like to play again?: ");
			plyAgn = Console.ReadLine().ToLower();
		}
		
		Console.WriteLine("Thanks for playing! Bye for now.");	
    }
}	