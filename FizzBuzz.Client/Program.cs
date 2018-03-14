using System;

namespace Fizzbuzz.Client
{
    class Program
    {
        static int Input_Beginning()
        {
            string input;
            int output;
            Console.WriteLine("\nEnter the beginning.");
            input = Console.ReadLine();

            while(!int.TryParse(input, out output))
            {
                Console.WriteLine("Invalid input. Enter an integer.");
                Console.WriteLine("\nEnter the beginning.");
                input = Console.ReadLine();
            }
            
            return output;
        }

        static int Input_Ending()
        {
            string input;
            int output;
            Console.WriteLine("\nEnter the ending.");
            input = Console.ReadLine();

            while(!int.TryParse(input, out output))
            {
                Console.WriteLine("Invalid input. Enter an integer.");
                Console.WriteLine("\nEnter the ending.");
                input = Console.ReadLine();
            }
            return output;
        }
        static void FizzBuzz()
        {
            int beginning, ending, countFizz = 0, countBuzz = 0, countFizzBuzz = 0;
            
            beginning = Input_Beginning();
            ending = Input_Ending();

            while(beginning > ending)
            {
                Console.WriteLine("Invalid input. Beginning should not be larger than ending.");
                beginning = Input_Beginning();
                ending = Input_Ending();
            }
                for(int i = beginning; i <= ending; i++)
                {
                    if(i % 3 == 0 && i % 5 == 0)
                    {
                        countFizzBuzz++;
                        Console.WriteLine("FizzBuzz");
                    }
                    else if(i % 3 == 0)
                    {
                        countFizz++;
                        Console.WriteLine("Fizz");
                    }
                    else if(i % 5 == 0)
                    {
                        countBuzz++;
                        Console.WriteLine("Buzz");
                    }
                    else{
                        Console.WriteLine($"{i}");
                    }
                }
                
                Console.WriteLine($"\nFizz {countFizz}, Buzz {countBuzz}, FizzBuzz {countFizzBuzz}.");
        
        }
        static void Main(string[] args)
        {
            FizzBuzz();
        }
    }
}
