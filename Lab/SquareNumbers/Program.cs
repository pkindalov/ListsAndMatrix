using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> squares = new List<long>();
            nums.Sort();
            nums.Reverse();
            for (int i = 0; i < nums.Count; i++)
            {
                //if (nums[i] % Math.Sqrt(nums[i]) == 0 || nums[i] == 0)
                if (nums[i] % Math.Sqrt(nums[i]) == 0)
                {
                    squares.Add((nums[i]));
                }
            }
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
