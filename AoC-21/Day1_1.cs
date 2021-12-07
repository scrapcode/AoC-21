using System;
using System.IO;

namespace AoC_21
{
    class Day1_1
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("inputs/input1.txt");

            int prev = 0;
            int totalIncrease = 0;
            int curr;

            foreach (string line in lines)
            {
                curr = Int32.Parse(line);

                if (prev == 0)
                {
                    prev = curr;
                    continue;
                }

                if (curr > prev)
                    totalIncrease++;

                prev = curr;
            }

            Console.Out.WriteLine($"Answer: {totalIncrease}");
        }
    }
}
