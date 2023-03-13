using System;
  
// namespace declaration
namespace Exercise {
      
    // Class declaration
    class Program {
          
        // Main Method
        static void Main(string[] args) {
         Console.Write("Enter number for array: "); 
         int num = Convert.ToInt32(Console.ReadLine());  
         int[] array = new int[num];
         double sum = 0;
         
         Console.WriteLine("Enter Number",num);
         for (int i = 0; i < num; i++)
         {
            array[i] =Convert.ToInt32(Console.ReadLine());
            sum += array[i];
         }
        
         Console.Write("The sum number is : ");
         Console.WriteLine(sum);

         Console.Write("Negative number in array are: ");
         for (int i = 0; i < num; i++)
         {
            if (array[i] < 0)
            {
                Console.Write(array[i] + " , " ); 
            }
         }
    Console.Write("\n");
            int count = 0;
          for (int i = 0; i < num; i++)
         {
            if (array[i] < 0)
            {
               count ++;
            }
         }
        Console.Write("Negative Count number is:" );
        Console.WriteLine(count);

        int max = array[0];
        int min =array[0];
        for (int i = 0; i < num; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
             if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.Write("maximum number is :");
        Console.WriteLine(max);
        Console.Write("minimum number is :");
        Console.WriteLine(min);

        int even = 0;
        int odd = 0;
        for (int i = 0; i < num; i++)
        {
            if (array[i] %2 == 0)
            {
                even++;
            }
            else
            {
                odd ++;
            }
        }
        Console.Write("count of even number is :");
        Console.WriteLine(even);
        Console.Write("count of odd number is :");
        Console.WriteLine(odd + "\n");
        Console.Write("Reverse Number are: ");
        Array.Reverse(array);
         foreach (var arr in array)
            {
                Console.WriteLine(arr);
            }

            
            Console.WriteLine("\n Enter number you want to search");
            int findNumber = Convert.ToInt32(Console.ReadLine());
            var number = array.ToList();

            if (number.Contains(findNumber))
            {
                Console.WriteLine("The number " + findNumber + " is exist in array");
            }
            else
            {
                Console.WriteLine("The number " + findNumber + "  is not exist in array");
            }

            Console.WriteLine("Enter Number to delete ");
            int numberOfDelete =  Convert.ToInt32(Console.ReadLine());
            // var numbers= new List<int>();
            //     numbers.AddRange(array);
            number.RemoveAt(numberOfDelete);
            Console.WriteLine("Deleted index number :" + numberOfDelete);
            Console.Write("New array is :");
            foreach (var newList in number)
            {
                Console.Write( newList + " ");
            }
    
        Console.WriteLine();

        }

    }
}
