using System.Linq;
namespace ArrayLooping;
class Program
{
    static void Main(string[] args)
    {
        int[] inputNumber = new int[5];

        Console.Write("You can enter 5 integer numbers \n");
            
        for(int i=0; i< inputNumber.Length; i++)
        {
            Console.Write("Enter a number: ");
            inputNumber[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("You entered " + inputNumber[i] + "\n");

                
        }

        double sum = inputNumber.Sum();
        Console.WriteLine("The sum of elements is : " + sum);
        
        Console.Write("The negative values are : ");

        foreach(int negativeNum in inputNumber)
        {
            if(negativeNum<0)
            {
                Console.Write(negativeNum + ", ");
            }
        }
        Console.ReadLine();
    }
}

