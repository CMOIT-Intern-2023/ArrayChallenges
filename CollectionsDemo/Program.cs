using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Challenge
            Console.WriteLine("Please input numbers with space between them (1 -1 3 8)");
            string[] input = Console.ReadLine().Trim().Split(' ');
            int negCount = 0;
            double totalSum = 0;
            string negString = "";
            double[] doubleArr;
            try
            {
                // converting input array to double 
                doubleArr = Array.ConvertAll(input, double.Parse);
                foreach (double d in doubleArr)
                {
                    totalSum += d;
                    if (d < 0)
                    {
                        negCount++;
                        negString = negString + " " + d;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("\n---Displaying all the Negative numbers in the input---");
            Console.WriteLine(negCount == 0 ? "No negative numbers in the input" : negString.Trim());

            Console.WriteLine("\n---Displaying the Sum of all numbers in the input---");
            Console.WriteLine(totalSum);

            Console.WriteLine("\n---Displaying the Count of negative numbers in the input---");
            Console.WriteLine(negCount);

            Console.WriteLine("\n---Maximum element in the input---");
            Console.WriteLine(doubleArr.Max());

            Console.WriteLine("\n---Minimum element in the input---");
            Console.WriteLine(doubleArr.Min());

            Console.WriteLine("\n---Count of even numbers in the input---");
            Console.WriteLine(doubleArr.Count(x => x % 2 == 0));

            Console.WriteLine("\n---Count of odd numbers in the input---");
            Console.WriteLine(doubleArr.Count(x => (x % 2 == 1) || (x % 2 == -1)));

            Console.WriteLine("\n---Reverse of the input---");
            Array.Reverse(doubleArr);
            foreach (var i in doubleArr)
                Console.Write($"{i} ");

            while (true)
            {
                Console.WriteLine("\n\n---Provide an element to search in the input---");
                try
                {
                    double search = Convert.ToDouble(Console.ReadLine().Trim());
                    Console.WriteLine("\n---Searched Result---");
                    if (doubleArr.Contains(search))
                    {
                        Console.WriteLine(search + " is found in the input at the index of " + Array.IndexOf(doubleArr, search));
                        break;
                    }
                    else
                        Console.WriteLine("No result found");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            while (true)
            {
                Console.WriteLine("\n---Provide an element to be deleted in the input---");
                try
                {

                    double delete = Convert.ToDouble(Console.ReadLine().Trim());
                    Console.WriteLine("\n---Deleted Result---");
                    if (doubleArr.Contains(delete))
                    {
                        var result = from r in doubleArr where r != delete select r;
                        foreach (var i in result)
                            Console.Write($"{i} ");
                        break;
                    }
                    else
                        Console.WriteLine("Element to be deleted was not found");
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
