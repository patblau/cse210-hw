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
        }

        // sum of list
        int sum = 0;
        foreach (int number in nmbrs)
            {
                sum += number;
            }
        
        // average of list
        double average = (double)sum / nmbrs.Count;
        
        // maximum of list
        int max = nmbrs(0);
        foreach (int number in nmbrs)
        {
            if (number > max)
                {
                    max = number;
                }        
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}