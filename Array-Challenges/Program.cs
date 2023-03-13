using System;
using System.Linq;

namespace Array_Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string[] splittedString;
            double[] numArrays;

            do
            {
                // Asking the user input
                Console.WriteLine("Please input numbers:");

                userInput = Console.ReadLine().Trim();
                Console.WriteLine("=============================================================\n");
                char[] delimiters = { ',', ' ' };

                splittedString = userInput.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                // Empty number array for user input
                numArrays = new double[splittedString.Length];

                // Converting user inputs to int array
                try
                {
                    if (splittedString.Length == 0)
                    {
                        throw new Exception();
                    }

                    for (int i = 0; i < splittedString.Length; i++)
                    {
                        numArrays[i] = double.Parse(splittedString[i]);

                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Please input numbers only.\n");
                }
            } while (true);

            // The sum of array elements
            Console.WriteLine("Sum of array elements ==> {0}\n", numArrays.Sum());
            Console.WriteLine("=============================================================\n");

            // Printing out negative numbers
            double[] negativeNumbers = numArrays.Where(x => x < 0).ToArray();
            Console.WriteLine("Total numbers of negative numbers are ==> {0}\n", negativeNumbers.Length);
            Console.WriteLine("=============================================================\n");

            // Printing out maximum element in array
            Console.WriteLine("Maximun element in array ==> {0}\n", numArrays.Max());
            Console.WriteLine("=============================================================\n");
            // Printing out minium element in array
            Console.WriteLine("Minimum element in array ==> {0}\n", numArrays.Min());
            Console.WriteLine("=============================================================\n");

            // Printing  out even numbers
            Console.WriteLine("Total count of even numbers are ==> {0}\n", numArrays.Where(x => x % 2 == 0).ToArray().Length);
            Console.WriteLine("=============================================================\n");

            // Printing out odd numbers
            Console.WriteLine("Total count of odd numbers are ==> {0}\n", numArrays.Where(x => x % 2 != 0).ToArray().Length);
            Console.WriteLine("=============================================================\n");

            // Printing out reverse array
            Console.WriteLine("The reverse array is ==> {0}\n", string.Join(" ", numArrays.Reverse().ToArray()));
            Console.WriteLine("=============================================================\n");

            // Searching an element
            double query = isInputValid("Please input the value of the element you want to search: ");
            Console.WriteLine("");

            if (numArrays.Contains(query)) Console.WriteLine($"It contains {query}\n");
            else Console.WriteLine($"It does not contains {query}\n");
            Console.WriteLine("=============================================================\n");

            // Deleting an element
            while (true)
            {

                double delete = isInputValid("Please input the value of the element you want to delete: ");
                Console.WriteLine("");


                if (numArrays.Contains(delete))
                {
                    Console.WriteLine("The deleted array is ==> {0}\n", string.Join(" ", numArrays.Where(x => x != delete).ToArray()));
                    Console.WriteLine("=============================================================\n");
                    break;
                }
                else
                {
                    Console.WriteLine("The input is not in the array.Try again!\n");
                    Console.WriteLine("=============================================================\n");
                    continue;
                }
            }
        }
        // Credit of the following method goes to Phone Zaw.
        public static double isInputValid(string message)
        {
            do
            {
                try
                {
                    Console.Write(message);
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please input numbers only");
                }
            } while (true);
        }

    }
}


