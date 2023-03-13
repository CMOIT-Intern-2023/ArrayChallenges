using System;
using System.Collections.Generic;
using System.Linq;

class FirstChallenge
{
    public static void Main()
    {
        Console.WriteLine("How many numbers do you want to type in?");
        int totalNumbers = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[totalNumbers];
        List<int> negNum = new List<int>();
        List<int> evenNum = new List<int>();
        List<int> oddNum = new List<int>();
        float sum = 0f;

        Console.WriteLine($"Enter {totalNumbers} whole numbers");
        for (int i = 0; i < totalNumbers; i++)
        {
            try
            {
                sum += numbers[i];
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i] < 0) negNum.Add(numbers[i]);
                if (numbers[i] % 2 == 0) evenNum.Add(numbers[i]);
                else oddNum.Add(numbers[i]);
            }
            catch
            {
                Console.WriteLine("Hey...you must type whole number only");
                Environment.Exit(0);
            }
        }

        Console.WriteLine("--------------------------------");

        // Numbers
        Console.WriteLine("Your entered these numbers");
        foreach (var number in numbers) Console.Write(number + " ");
        Console.WriteLine("\n--------------------------------");

        // Negative numbers
        Console.WriteLine("Negative numbers are ");
        foreach (var number in negNum) Console.Write(number + " ");
        Console.WriteLine("\n--------------------------------");

        // Sum of all numbers
        Console.WriteLine("Sum of all numbers is \n" + numbers.Sum());
        Console.WriteLine("--------------------------------");

        // Count of negative numbers
        Console.WriteLine("Count of negative numbers is \n" + negNum.Count);
        Console.WriteLine("--------------------------------");

        // Max & Min
        Console.WriteLine("Maximum number is " + numbers.Max());
        Console.WriteLine("Minimum number is " + numbers.Min());
        Console.WriteLine("--------------------------------");

        // Even number count and Odd number count
        Console.WriteLine("Count of even numbers is " + evenNum.Count);
        Console.WriteLine("Count of odd numbers is " + oddNum.Count);
        Console.WriteLine("--------------------------------");

        // Reverse of array
        Array.Reverse(numbers);
        Console.WriteLine("Reverse array is ");
        foreach (var number in numbers) Console.Write(number + " ");
        Console.WriteLine("\n--------------------------------");

        // Search element
        Console.WriteLine("What number do you want to search");
        int target = Convert.ToInt32(Console.ReadLine());
        bool isExist = numbers.Contains(target);
        if (isExist)
        {
            Console.WriteLine("Element found in the array");
        }
        else
        {
            Console.WriteLine("Element not found in the given array");
        }
        Console.WriteLine("--------------------------------");

        // Delete
        Console.WriteLine("What number do you want to delete");
        target = Convert.ToInt32(Console.ReadLine());
        isExist = numbers.Contains(target);
        if (isExist)
        {
            var numbersList = numbers.ToList();
            numbersList.Remove(target);
            Console.WriteLine("Element deleted.");
            foreach (var number in numbersList) Console.Write(number + " ");
            Console.WriteLine("\n--------------------------------");
        }
        else
        {
            Console.WriteLine("Element not found in the given array");
            Console.WriteLine("--------------------------------");
        }
    }
}