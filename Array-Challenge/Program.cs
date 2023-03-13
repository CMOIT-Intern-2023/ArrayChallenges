namespace Array_Challenge;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter numbers : ");
        string user_array = Console.ReadLine();
        int[] num_array = Array.ConvertAll(user_array.Split(" "), s => int.Parse(s));
        int neg_count = 0;
        Console.Write("Negative Numbers :");
        foreach (var num in num_array)
        {
            if (num < 0)
            {
                Console.Write(num + ", ");
                neg_count++;
            }
        }
        Console.WriteLine("\nSum : " + num_array.Sum());
        Console.WriteLine("Negative elements count : " + neg_count);
        Console.WriteLine("Maximum element : " + num_array.Max());
        Console.WriteLine("Minimum element : " + num_array.Min());
        var even_count = from num in num_array where num % 2 == 0 select num;
        Console.WriteLine("Even element count : " + even_count.Count());
        Console.WriteLine("Odd element count : " + (num_array.Count() - even_count.Count()));
        Console.Write("Reverse array : ");
        var reverse_arr = num_array.Reverse();
        foreach (var a in reverse_arr)
            Console.Write(a + ", ");
        int search_num;
        Console.WriteLine("\nType a number to search and remove : ");
        do
        {
            search_num = Convert.ToInt32(Console.ReadLine());
            if (num_array.Contains(search_num)) break;
            else Console.WriteLine("The number not found. Please type again");
        } while (true);
        int[] removed_array = num_array.Where(val => val != search_num).ToArray();
        Console.Write("Array with removed number : ");
        foreach (var a in removed_array)
            Console.Write(a + ", ");
    }
}

