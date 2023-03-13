using System;
using System.Collections.Generic;
using System.Linq;

namespace arrayexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.WriteLine("Enter 9 numbers");

            int[] num = new int[9];
            for (i = 0; i < 9; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                sum += num[i];

            }
            Console.WriteLine("The negative numbers are");

            for (i = 0; i < 9; i++)
            {


                if (num[i] < 0)

                    Console.WriteLine(num[i] + "");
            }
            Console.WriteLine("The sum of the elements in the array is:" + sum);
            var neg = num.Count(num => num < 0);
            Console.WriteLine("The numbers of negative in the array is " + neg);
            Console.WriteLine("The maximum element is" + num.Max());
            Console.WriteLine("The minumum element is" + num.Min());
            var even = num.Count(num => num % 2 == 0);
            Console.WriteLine("The numbers of even numbers in the array are " + even);
            var odd = num.Count(num => num % 2 != 0);
            Console.WriteLine("The numbers of odd numbers in the array are " + odd);

            num.Reverse();
            foreach (var items in num)
                Console.WriteLine(items);
            Console.WriteLine("Search the number");
            Console.WriteLine(num.Contains(Convert.ToInt32(Console.ReadLine())));
            List<int> list = num.ToList<int>();
            Console.WriteLine("Enter the number you want to remove");
            list.Remove(Convert.ToInt32(Console.ReadLine()));
            foreach (var items in list)
                Console.WriteLine(items);


        }
    }
}
