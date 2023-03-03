using System.Linq;
using System.Collections.Generic;
namespace ArrayLooping;
class Program
{
    static void Main(string[] args)
    {
        // master
        Console.WriteLine("Please enter the size of array");
        Console.WriteLine("Please enter the size of array. Pleaseeeeeee.");
        Console.WriteLine("Please enter the size of array. Pleaseeeeeee.");
        Console.WriteLine("Please enter the size of array. Pleaseeeeeee.");
        Console.WriteLine("Please enter the size of array. Pleaseeeeeee.");
        Console.WriteLine("Please enter the size of array. Pleaseeeeeee.");
        int arraySize =Convert.ToInt32(Console.ReadLine());

        double[] inputNumber = new double[arraySize];

        Console.Write("You can enter numbers \n");

        for (int i = 0; i < inputNumber.Length; i++)
        {
            Console.Write("Enter a number: ");
            inputNumber[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("You entered " + inputNumber[i] + "\n");


        }

        double sum = inputNumber.Sum();
        Console.WriteLine("\nThe sum of elements is : " + sum);

        Console.Write("The negative values are : ");

        int numCount = 0;
        var negCount = 0;
        while (numCount < inputNumber.Length)
        {
            if (inputNumber[numCount] < 0)
            {
                double negativeValues = inputNumber[numCount];
                Console.Write(negativeValues + ",");
                negCount++;
            }
            numCount++;
        }

        Console.WriteLine("\nCount of negative value is " + negCount);

        Console.Write("\nThe even numbers are ");

        var loopCount = 0;
        var evenCount = 0;
        foreach (double evenNumbers in inputNumber)
        {
            double resultEven = inputNumber[loopCount] % 2;
            if (resultEven == 0.00)
            {

                Console.Write(evenNumbers + ",");
                evenCount++;
            }
            loopCount++;
        }
        Console.WriteLine("\nThe number of even numbers is " + evenCount);

        Console.Write("\nThe odd numbers are ");

        var forLoopCount = 0;
        var oddCount = 0;
        foreach (double oddNumbers in inputNumber)
        {
            double resultOdd = inputNumber[forLoopCount] % 2;
            if (resultOdd >= 1.00)
            {

                Console.Write(oddNumbers + ",");
                oddCount++;
            }
            forLoopCount++;
        }

        var inputNumlist = new List<double>();
        inputNumlist.AddRange(inputNumber);


        inputNumlist.RemoveAt(3);

        Console.WriteLine("\nThe number of odd numbers is " + oddCount);
        Console.WriteLine("The maximum value is " + inputNumber.Max());
        Console.WriteLine("The minimim value is " + inputNumber.Min());
        Console.Write("The reverse order of array is : ");
        Array.Reverse(inputNumber);

        foreach (double r in inputNumber)
        {
            Console.Write(r + ",");
        }
        Console.ReadLine();
    }
}

