using System;
using System.IO;
using System.Linq;

namespace AoC_21
{
    class Day1_2
    {
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("inputs/input1.txt");
            int totalLines = lines.Count();
            int totalIncreases = 0;

            int[] windows = new int[totalLines - 2];
            int currWindow = 0;

            for (int i = 0; i < (totalLines - 2); i++)
                windows[currWindow++] = Int32.Parse(lines[i])
                                        + Int32.Parse(lines[i + 1])
                                        + Int32.Parse(lines[i + 2]);

            for (int i = 1; i < windows.Count(); i++)
                if (windows[i] > windows[i - 1])
                    totalIncreases++;

            Console.Out.WriteLine($"Answer: {totalIncreases}");
        }
    }
}
