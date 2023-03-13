using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr2 = new int[10];
            string condition;
            int[] arr3 = new int[10];
            int i, n, max, min;

            while(true)
            {

                Console.Write("Input the number of elements to be stored in the array :");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    // n = Convert.ToInt32(Console.ReadLine());



                    int[] a = new int[n];
                    Console.Write("Input {0} elements in the array :\n", n);

                    for (i = 0; i < n; i++)
                    {
                        Console.Write("element - {0} : ", i);
                        a[i] = Convert.ToInt32(Console.ReadLine());
                    }


                    int sum = a.Sum();

                    Console.Write($"Sum of all elements stored in the array is : {sum} \n\n");

                    Console.WriteLine("------------------------------------------------ ");

                    Console.WriteLine("All negative elements in array are: ");
                    for (i = 0; i < n; i++)
                    {
                        //Printing negative elements
                        if (a[i] < 0)
                        {
                            Console.WriteLine(a[i]);
                        }
                    }



                    max = a.Max();
                    min = a.Min();





                    Console.WriteLine("Maximum and Minimum");
                    Console.WriteLine("------------------------------------");
                    Console.Write($"Maximum element is : {max}\n");
                    Console.Write($"Minimum element is : {min}\n\n");

                    //reverse
                    Console.WriteLine("------------------------------------");

                    Console.Write("\n\nThe values store into the array in reverse are :\n");
                    for (i = n - 1; i >= 0; i--)
                    {
                        Console.Write("{0} ", a[i]);
                    }
                    Console.Write("\n\n");
                    ///delete 
                    int[] deleteArray;
                    Console.WriteLine("------------------------------------");

                    Console.WriteLine("Enter element to delete");
                    int item = Convert.ToInt32(Console.ReadLine());
                    // int index= a.IndexOf(item);
                    deleteArray = a.Where(val => val != item).ToArray();




                    foreach (int itemss in deleteArray)
                    {
                        Console.Write(" " + itemss);
                    }




                    Console.WriteLine("\n------------------------------------");

                    ///search
                    Console.WriteLine("\nEnter element to search");
                    int search = Convert.ToInt32(Console.ReadLine());
                    bool isExist = a.Contains(search);
                    if (isExist)
                    {
                        Console.WriteLine("Element found in the array");
                    }
                    else
                    {
                        Console.WriteLine("Element not found in the array");
                    }






                    //even odd count
                    int[] arr1 = new int[10];

                    int j = 0; int k = 0;

                    for (i = 0; i < n; i++)
                    {
                        if (a[i] % 2 == 0)
                        {
                            arr2[j] = a[i];
                            j++;

                        }
                        else
                        {
                            arr3[k] = a[i];
                            k++;
                        }
                    }

                    Console.Write("\nThe Even elements are : \n");
                    for (i = 0; i < j; i++)
                    {
                        Console.Write("{0} ", arr2[i]);
                    }

                    Console.Write("\nThe Odd elements are :\n");
                    for (i = 0; i < k; i++)
                    {
                        Console.Write("{0} ", arr3[i]);
                    }
                    
                     Console.WriteLine("\n\nDo you want to Run Again? Y/N");
                condition= Console.ReadLine(); 
                if(condition!="Y" && condition!="y"){
                    break;

                }

                     
                }



                else
                {
                    Console.WriteLine("Invalid input. Try again.\n");
                }
              
            }


            









        }
    }
}






















