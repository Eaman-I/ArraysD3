using System;

namespace ArraysD3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto populate an array with 25 elements to meet deliverable requirments
            int maxcount = 25;
            int[] countup = new int[maxcount];
            int pop_countup = 0;
            // for loop to iterate through array
            for(int i = 0; i < maxcount; i++)
            {
                countup[i] = pop_countup;
                Console.WriteLine("Element Value = " + i);
            }

            Console.WriteLine("The program has generated and displayed an array of size 25 elements.");
            Console.WriteLine("To change the size of elements in the array press Enter. To close press any key twice.");
            
            // catch block to verify user input
            try
            {

                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Please enter the desired size of the array."); // asks user for input

                    // reads user input then executes array to specified size
                    string input = Console.ReadLine();
                    maxcount = int.Parse(input);
                    for (int i = 0; i < maxcount; i++)
                    {
                        countup[i] = pop_countup;
                        Console.WriteLine("Element Value = " + i);
                    }

                    // Displays program completion message. Asks user to exit or not.
                    Console.WriteLine("The program has generated and displayed an array of size " + maxcount + " elements.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey(true);

                }
                else // If user does not press Enter. closes program once user presses any key twice
                {
                    Console.ReadKey(true);
                }
            }

            catch
            {
                Console.WriteLine("Pleas input integer values only. Press any key to exit and try again.");
                Console.ReadKey(true);
            }
            
        }
    }
}
