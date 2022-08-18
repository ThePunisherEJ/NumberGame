using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int theNumber =17 ;
           
            Console.WriteLine("|||Welcome to the game, you have 4 trys to guess a number" + 
                  " " +   "between 0 and 35|||");
            for (int i = 0; i<=3;)
            {
                
                Console.WriteLine("Guess the number");
                string userNumber = Console.ReadLine();
                int num = int.Parse(userNumber);
                
            

                if (num == theNumber)
                {
                    Console.WriteLine("Well done! the correct number is {0}", theNumber);
                    Console.WriteLine("-------------------------------------------");
                    break;
                    
                   
                }
                else if(num != theNumber)
                {
                    i++;
                    Console.WriteLine("Nope, that's not it! , try again mate");
                   
                }
                if (i == 1)
                {
                    Console.WriteLine("You have 3 tries left");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                }
                else if (i == 2)
                {
                    Console.WriteLine("You have 2 tries left");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                }
                else if (i == 3)
                {
                    Console.WriteLine("You have 1 try left ");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - -");

                }
                else if (i == 4)
                {
                    Console.WriteLine("That was your last try mate, better luck next time :-)");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                }


            }
            Console.Read();
        }
    }
}
