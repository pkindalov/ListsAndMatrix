using System;
using System.Linq;


namespace SumReversedNumbers
{
    class Program
    {
        static void Main()
        {
            string[] nums = Console.ReadLine().Trim().Split(' ').ToArray();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                char[] numbers = nums[i].ToCharArray();
                Array.Reverse(numbers);
                sum += int.Parse(string.Join("", numbers));
            }
            Console.WriteLine(sum);
        }
    }
}
