using System;
using System.Linq;

namespace ArrayChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking the count of numbers                            
            int arraySize = (int)InputAsker(prompt: "Enter size of the array: ", positiveOnly: true);


            // Creating the array to store the numbers
            int[] nums = new int[arraySize];


            // Asking the numbers
            Console.WriteLine("\nEnter numbers (integers only):");

            for (int i = 0; i < arraySize; i++)
            {
                nums[i] = (int)InputAsker(prompt: $"Number {i + 1}: ");
            }


            // Printing out the numbers
            Console.WriteLine("\nThe numbers are :");

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }


            // Printing out the total sum
            Console.WriteLine($"\n\nThe sum is {nums.Sum()}");


            // Printing out the count of negative numbers
            Console.WriteLine($"\nThe count of negative numbers is {nums.Where(n => n < 0).Count()}");


            // Printing out the maximum number
            Console.WriteLine($"\nThe maximum is {nums.Max()}");


            // Printing out the minimum number
            Console.WriteLine($"\nThe minimum is {nums.Min()}");


            // Printing out the count of even numbers
            Console.WriteLine($"\nThe count of even numbers is {nums.Where(n => n % 2 == 0).Count()}");


            // Printing out the count of odd numbers
            Console.WriteLine($"\nThe count of odd numbers is {nums.Where(n => n % 2 != 0).Count()}");


            // Reverse the array and printing out
            Array.Reverse(nums);

            Console.WriteLine("\nThe reverse of the array is: ");

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }


            // Reverse the array back
            Array.Reverse(nums);

            Console.WriteLine("\n");


            // Searching
            while (true)
            {


                int? input = InputAsker(prompt: "Enter the number you want to search (Enter Exit to exit searching): ", nullable: true);

                if (input == null) break;

                if (nums.Contains((int)input))
                {
                    Console.WriteLine("Found\n");
                }
                else
                {
                    Console.WriteLine("Not found\n");
                }
            }


            Console.WriteLine();

            // Deleting
            while (true)
            {
                if (nums.Length == 0) break;

                int? input = InputAsker(prompt: "Enter the number you want to delete (Enter Exit to exit deleting): ", nullable: true);

                if (input == null) break;

                if (nums.Contains((int)input))
                {
                    int index = Array.IndexOf(nums, (int)input);
                    nums = nums.Where((val, ind) => ind != index).ToArray();

                    foreach (int n in nums)
                    {
                        Console.Write(n + " ");
                    }

                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("This number does not exist in the array");
                }

                Console.WriteLine();
            }

        }


        // A helper method to ask and validate the input
        private static int? InputAsker(String prompt, bool nullable = false, bool positiveOnly = false)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    string inputString = Console.ReadLine();
                    int input;

                    if (nullable)
                    {
                        if (inputString == "Exit")
                        {
                            return null;
                        }
                    }

                    input = int.Parse(inputString);

                    if (positiveOnly && input <= 0)
                    {
                        throw new Exception("Please only enter a number greater than 0!\n");
                    }

                    return input;

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please only enter an integer!\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
