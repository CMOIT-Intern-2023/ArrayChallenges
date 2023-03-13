using System;
using System.Collections.Generic;
using System.Linq;

namespace test_loop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();

            Console.WriteLine("Enter total number");
            int num = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter number:" +i );

                int input = Int32.Parse(Console.ReadLine());
                numbers.Add(input);

            }

            int sum = 0;

            foreach (int n in numbers)
            {
                sum += n;

            }

            Console.WriteLine("Sum of array elements: " + sum);

            numbers.Min();
            numbers.Max();
            Console.WriteLine("maximum elements: " + numbers.Max());
            Console.WriteLine("minimum elements: " + numbers.Min());

            int neg = 0;

            int even = 0;
            int odd = 0;


            foreach (int n in numbers)
            {
                if (n < 0)
                {
                    neg++;
                }


                if (n % 2 == 0)
                {
                    even++;
                }

                if (n % 2 != 1)
                {
                    odd++;
                }

            }

            Console.WriteLine("Count of negative: " + neg);
            Console.WriteLine("Count of even: " + even);
            Console.WriteLine("Count of odd: " + odd);

            Console.WriteLine("Reserve list");

            // Array

            numbers.Reverse();
            

            foreach (var item in numbers)
            {

                Console.Write(" " + item);


            }

            Console.WriteLine("\nEnter number to find in array");
            int search = Int32.Parse(Console.ReadLine());
            bool hasfive = numbers.Contains(search);

            if (hasfive)
            {
                Console.WriteLine("Element fount in array");
            }
            else
            {
                Console.WriteLine("Element not fount in array");
            }

            Console.WriteLine("Enter number to remove");
            int rme = Int32.Parse(Console.ReadLine());

            numbers.Remove(rme);

            foreach ( var rm in numbers )
            {
                Console.Write(" " + rm);
            }





        }
        

    }
}
