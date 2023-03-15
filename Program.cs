using System;
using System.Linq;

class FirstChallenge
{
    public static void Main()
    {
        Console.WriteLine("How many numbers do you want to type in?");
        if (!int.TryParse(Console.ReadLine(), out int totalNumbers))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }
        else if (totalNumbers < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        int[] numbers = new int[totalNumbers];
        for (int i = 0; i < totalNumbers; i++)
        {
            Console.WriteLine($"Enter number {i + 1} of {totalNumbers}:");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }
            numbers[i] = number;
        }

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Your entered these numbers: " + string.Join(", ", numbers));

        var negNum = numbers.Where(n => n < 0).ToList();
        Console.WriteLine("\nNegative numbers are: " + string.Join(", ", negNum));

        var evenNum = numbers.Where(n => n % 2 == 0).ToList();
        var oddNum = numbers.Where(n => n % 2 != 0).ToList();
        Console.WriteLine($"\nCount of even numbers is {evenNum.Count}");
        Console.WriteLine($"Count of odd numbers is {oddNum.Count}");

        Console.WriteLine($"\nSum of all numbers is {numbers.Sum()}");

        Console.WriteLine($"\nCount of negative numbers is {negNum.Count}");

        Console.WriteLine($"\nMaximum number is {numbers.Max()}");
        Console.WriteLine($"Minimum number is {numbers.Min()}");

        int[] reversedNumbers = new int[totalNumbers];
        numbers.CopyTo(reversedNumbers, 0);
        Array.Reverse(reversedNumbers);
        Console.WriteLine("\nReverse array is: " + string.Join(", ", reversedNumbers));

        Console.WriteLine("\nWhat number do you want to search?");
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }
        bool isExist = numbers.Contains(target);
        Console.WriteLine(isExist ? "Element found in the array." : "Element not found in the given array.");

        Console.WriteLine("\nWhat number do you want to delete?");
        if (!int.TryParse(Console.ReadLine(), out target))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }
        if (numbers.Contains(target))
        {
            var numbersAfterDeletion = numbers.ToList();
            numbersAfterDeletion.Remove(target);
            Console.WriteLine($"Element {target} deleted.");
            Console.WriteLine($"New array is: {string.Join(", ", numbersAfterDeletion)}");
        }
        else Console.WriteLine("Element not found in the given array.");

        Console.WriteLine("--------------------------------");
    }
}
