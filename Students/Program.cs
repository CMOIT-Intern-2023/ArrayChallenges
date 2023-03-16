using System;
using System.Collections.Generic;
using System.Drawing;
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
                Console.Write("\nEnter number again: ");
                input = Console.ReadLine();
            }

            return filtered_input;

        }

        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                bool isD = true;
                List<double> arr = new List<double>();
                List<string> inputs = new List<string>();
                double sum = 0;

                while (isD)
                {

                    Console.Write("Input number/s with space between them: ");
                    string input = Console.ReadLine();
                    string[] subs = input.Split(' ');

                    try
                    {
                        double[] arr1 = Array.ConvertAll(subs, Double.Parse);
                        foreach (double s in arr1)
                        {
                            arr.Add(s);
                            sum += s;
                        }

                        isD = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Failed. Enter again! \n");


                    }
                }

                int c = arr.Count(x => x < 0);
                int even = arr.Count(x => x % 2 == 0);
                int odd = arr.Count(x => x % 2 != 0);
                Console.WriteLine("\nSum: " + sum);
                Console.WriteLine("\nCount of negative numbers: " + c);
                Console.WriteLine("\nMin :" + arr.Min());
                Console.WriteLine("\nMax :" + arr.Max());
                Console.WriteLine("\nCount of even numbers: " + even);
                Console.WriteLine("\nCount of odd numbers: " + odd);
                arr.Reverse();
                Console.Write("\nReverse: ");

                foreach (double a in arr)
                {
                    Console.Write(a);
                    Console.Write(" ");

                }
                Console.WriteLine("");

                bool isFound = true;

                do
                {
                    Console.Write("\nSearch a number: ");
                    string search = Console.ReadLine();
                    double filtered_search = ValidateInput(search);
                    if (arr.Contains(filtered_search))
                    {
                        Console.WriteLine("Found");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not Found. Enter again! \n");
                        isFound = false;
                    }
                } while (!isFound);

                do
                {
                    Console.Write("\nEnter number you want to delete: ");
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
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not Found. Enter again!\n ");
                        isFound = false;
                    }
                } while (!isFound);

                Console.Write("\n\nDo you want to start again? (y/n): ");

                string decision = Console.ReadLine();
                Console.WriteLine("");
                if (decision.Equals('n'))
                {
                    flag = false;
                }
            } while (!flag);
        }
    }
}
