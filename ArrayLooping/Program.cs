using System.Linq;
using System.Collections.Generic;
namespace ArrayLooping;
class Program
{
    static void Main(string[] args)
    {
        bool userDesireContinue= true;
        while(userDesireContinue)
        {
            
        Console.WriteLine("Please enter the size of array");
       
        int arraySize =Convert.ToInt32(Console.ReadLine());

        double[] inputNumber = new double[arraySize];

        Console.Write("You can enter numbers \n");

        for (int i = 0; i < inputNumber.Length; i++)
        {
            bool success = true;
            
            while(success)
            {
            int value;
            string arrayValue=Console.ReadLine();
            Console.Write("Enter a number: ");
            if(int.TryParse(arrayValue, out value))
            {
                inputNumber[i] = value;
                success= false;
                    
            }
            else
                success= true;
            }
            
            Console.WriteLine("You entered " + inputNumber[i] + "\n");
            Console.WriteLine("Please enter a number");
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


        //inputNumlist.RemoveAt(3);

        Console.WriteLine("\nThe number of odd numbers is " + oddCount);
        Console.WriteLine();
        Console.WriteLine("The maximum value is " + inputNumber.Max());
        Console.WriteLine();
        Console.WriteLine("The minimim value is " + inputNumber.Min());
        Console.WriteLine();
        Console.Write("The reverse order of array is : ");
        Array.Reverse(inputNumber);

        foreach (double r in inputNumber)
        {
            Console.Write(r + ",");
        }
        Console.WriteLine("\nPlease enter the number you want to search");
        double searchNum = Convert.ToInt32(Console.ReadLine());
        if (inputNumlist.Contains(searchNum))
        {
            Console.WriteLine("Your search was found");
        }
        else
        {
            Console.WriteLine("Your search was not found");
        }
        

        Console.WriteLine("Enter the index number you want to delete");
        int indexNo = Convert.ToInt32(Console.ReadLine());
        if(indexNo < inputNumber.Length)
        {
            inputNumlist.RemoveAt(indexNo);
            foreach(var r in inputNumlist)
            {
                Console.Write(r + " , ");
            }
        
        }
        Console.WriteLine("Do you want to run the program? Y for yes, N for no");
        char userDesire =Convert.ToChar(Console.ReadLine());
        if(userDesire=='Y')
        {
            userDesireContinue=true;
        }  
        else
        {
            userDesireContinue=false;
        }
        }
        }
  
        // Console.WriteLine("Do you want to run the program? Y for yes, N for no");
        // char userDesire =Convert.ToChar(Console.ReadLine());
        // master
        
    
}

