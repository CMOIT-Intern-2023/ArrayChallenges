using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    internal class Program
    {
        static double ValidateInput(string input)
        {
            double filtered_input;

            while (!Double.TryParse(input, out filtered_input))
            {
                Console.WriteLine("Failed. You can only input integers.");
                Console.Write("Enter number again: ");
                input = Console.ReadLine();
            }

            return filtered_input;

        }

        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Enter numbers of inputs: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input number/s: ");
                List<double> arr = new List<double>();
                double sum = 0;
                string input;
                double filtered_input;
                for (int i = 0; i < num; i++)
                {
                    input = Console.ReadLine();
                    filtered_input = ValidateInput(input);
                    arr.Add(filtered_input);
                    sum += filtered_input;

                }

                int c = arr.Count(x => x < 0);
                int even = arr.Count(x => x % 2 == 0);
                int odd = arr.Count(x => x % 2 != 0);
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Count of negative numbers: " + c);
                Console.WriteLine("Min :" + arr.Min());
                Console.WriteLine("Max :" + arr.Max());
                Console.WriteLine("Count of even numbers: " + even);
                Console.WriteLine("Count of odd numbers: " + odd);
                arr.Reverse();
                Console.Write("Reverse: ");

                foreach (double a in arr)
                {
                    Console.Write(a);
                    Console.Write(" ");
                }

                Console.Write("\nSearch a number: ");
                string search = Console.ReadLine();
                double filtered_search = ValidateInput(search);
                if (arr.Contains(filtered_search))
                {
                    Console.WriteLine("Found");
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                Console.Write("Enter number you want to delete: ");
                string del = Console.ReadLine();
                double filtered_del = ValidateInput(del);
                if (arr.Contains(filtered_del))
                {
                    arr.Remove(filtered_del);
                    Console.Write("Deleted! Numbers left: ");
                    foreach (double a in arr)
                    {
                        Console.Write(a);
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.WriteLine("Number not found in the list.");
                }

                Console.WriteLine("\nDo you want to start again? (y/n)");

                string decision = Console.ReadLine();
                if (decision.Equals('n'))
                {
                    flag = false;
                }
            } while (true);
        }
    }
}
