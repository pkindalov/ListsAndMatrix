using System;
using System.Linq;


namespace BombNumbers
{
    class BombNumbers
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bombNumber = input[0];
            int bombPower = input[1];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int leftEnd = Math.Max(0, i - bombPower);
                    int rightEnd = Math.Min(numbers.Length - 1, i + bombPower);

                    for (int j = leftEnd; j <= rightEnd; j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
