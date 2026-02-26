using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá! Prep4 World!");
        
        List<int> nmbrs = new List<int>();	

		//Ask the user for a series of numbers	
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");						
        
        // append each number to a list. Stop when they enter 0.
        int usrNmbr = -1;
        while (unNmbr !-0)
        {
            Console.Write("Enter number: ");	
            usrNmbr = int.Parse(Console.ReadLine());	
             
            if (usrNmbr != 0)
            {	 	
                nmbrs.Add(usrNmbr);	
            }					

        // sum of list
        int sum = 0;
        foreach (int number in nmbrs)
            {
                sum += number;
            }
        Console.WriteLine($"The sum is: {sum}");
        

        
        // average of list
        // maximum of list
    }
}