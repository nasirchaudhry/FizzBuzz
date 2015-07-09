using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace FizzBuzz started
namespace FizzBuzz
{
    /// <summary> 
    /// This program will print a message for every number from 1 to 100. It'll print the numbers normally.
    /// For the number divisible by 3 it'll print "Fizz", for 5 it'll print "Buzz" and the numbers divisible by both
    /// program will print "FizzBuzz"
    /// </summary>
     
    //class program started
    class Program
    {
        //main method started
        static void Main(string[] args)
        {            
            //for loop to put the conditions to execute code
            for (int i = 1; i <= 100; i++)
            {                       
                if (i % 3 == 0 && i % 15 == 0) 
                {
                    Console.WriteLine( " FizzBuzz ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine( " Buzz ");
                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine( " Fizz ");                    
                }
                else 
                {
                    Console.WriteLine(i);
                }
            }//end for loop
        }//end main method
    }//end class program
}//end namespace FizzBuzz