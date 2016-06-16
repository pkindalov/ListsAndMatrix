using System;
using System.Collections.Generic;
using System.Linq;


namespace LargestIncreasingSubsequence
{
    class LargestIncreasingSubsequence
    {
        static void Main()
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] lengths = new int[sequence.Length];
            int[] previousIndexes = new int[sequence.Length];

            int maxLength = 0;
            int maxIndex = -1;
            for (int index = 0; index < sequence.Length; index++)
            {
                lengths[index] = 1;
                previousIndexes[index] = -1;
                for (int previousIndex = 0; previousIndex < index; previousIndex++)
                {
                    if (sequence[index] > sequence[previousIndex] && lengths[previousIndex] + 1 > lengths[index])
                    {
                        lengths[index] = lengths[previousIndex] + 1;
                        previousIndexes[index] = previousIndex;
                    }
                }

                if (lengths[index] > maxLength)
                {
                    maxLength = lengths[index];
                    maxIndex = index;
                }
            }

            var lis = new List<int>();

            while (maxIndex != -1)
            {
                lis.Add(sequence[maxIndex]);
                maxIndex = previousIndexes[maxIndex];
            }

            lis.Reverse();
            lis.ToArray();
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
