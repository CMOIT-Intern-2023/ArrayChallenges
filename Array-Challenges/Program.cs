using System;
using System.Linq;

namespace Array_Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Your Numbers Array: ");
            int[] ary = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            Console.Write("Input a number to search and delete: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Your Array => " + string.Join(" ", ary) + "\n");

            Console.WriteLine("Sum of Numbers: " + ary.Sum());

            Console.WriteLine("Count of Negative Numbers: " + ary.Count(x => x < 0));

            Console.WriteLine("Max Number: " + ary.Max() + " \nMin Number: " + ary.Min());

            Console.WriteLine("Count of Even: " + ary.Count(x => x % 2 == 0) + " \nCount of Odd: " + ary.Count(x => x % 2 != 0));

            Console.WriteLine("Reverse Ary: " + string.Join(" ", ary.Reverse()));

            Console.WriteLine($"Search {num}: {ary.Contains(num)} ");

            Console.WriteLine($"Delete {num}: {string.Join(" ", ary.Where(x => x != num))} ");
        }
    }
}
