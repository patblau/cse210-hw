using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Howdy there Prep2 World!");

        //ask for the grade percentage
        Console.WriteLine("What is your grade percentage? ");
        string grdPrcntg = Console.ReadLine();
        int prcntg = int.Parse(grdPrcntg);
        string grd = "";
        
       //define grades using separate print statements
       //change veribles into letter grades
        if(prcntg >= 90)
            grd = "A";
        else if(prcntg >= 80)
            grd = "B";
        else if(prcntg >= 70)
            grd = "C";
        else if(prcntg >= 60)
            grd = "D";
        else
            grd = "F";

        //include "+ (>=7)" or "- (<3)" to the grade
        // use modulus operator %
        int lastDigit = prcntg % 10;
        string sgn = "";

        //create a sign variable
        if (lastDigit >=7)
            sgn = "+";
        else if (lastDigit <3)
            sgn = "-";

        //no signs for A or F   
        if (grd == "A" || grd == "F+")
        sgn = "";

        //print grade
        Console.WriteLine($"\nYour grade is {grd}{sgn}");  

        //Need 70% to pass, state if passed or not
        if (prcntg >= 70) 
            Console.WriteLine("Hey, contrats! You did it. You passed the course.");
        else      
            Console.WriteLine("Not quite passing yet, but you are making progress. Don’t give up!");
        }
    }
}