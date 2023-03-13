using System;
using System.Linq;

namespace ArrayChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter size of the array: ");

            int arraySize = int.Parse(Console.ReadLine());

            int[] nums = new int[arraySize];

            Console.WriteLine("\nEnter numbers: ");

            for (int i = 0; i < arraySize; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe numbers are :");

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine($"\n\nThe sum is {nums.Sum()}");

            Console.WriteLine($"\nThe count of negative numbers is {nums.Where(n => n < 0).Count()}");

            Console.WriteLine($"\nThe maximum is {nums.Max()}");

            Console.WriteLine($"\nThe minimum is {nums.Min()}");

            Console.WriteLine($"\nThe count of even numbers is {nums.Where(n => n % 2 == 0).Count()}");

            Console.WriteLine($"\nThe count of odd numbers is {nums.Where(n => n % 2 != 0).Count()}");

            Array.Reverse(nums);

            Console.WriteLine("\nThe reverse of the array is: ");

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }

            Array.Reverse(nums);

            Console.WriteLine();

            while (true)
            {
                Console.Write("\nEnter the number you want to search (Enter Exit to exit searching): ");

                string input = Console.ReadLine();

                if (input == "Exit") break;

                if (nums.Contains(int.Parse(input)))
                {
                    Console.WriteLine("Found");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

            

            while (true)
            {
                if (nums.Length == 0) break;

                Console.Write("\nEnter the number you want to delete (Enter Exit to exit deleting): ");

                string input = Console.ReadLine();

                if (input == "Exit") break;

                int num = int.Parse(input);

                if (nums.Contains(num))
                {
                    int index = Array.IndexOf(nums, num);
                    nums = nums.Where((val, ind) => ind != index).ToArray();


                    foreach (int n in nums)
                    {
                        Console.Write(n + " ");
                    }

                }
                else
                {
                    Console.WriteLine("This number does not exist in the array");
                }


                Console.WriteLine();
            }





        }
    }
}
