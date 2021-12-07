using System;
using System.IO;

namespace AoC_21
{
    class Day2_2
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("inputs/input2.txt");

            int x, y, aim;
            x = y = aim = 0;

            foreach(string line in lines)
            {
                string[] movement = line.Split(" ");
                string dir = movement[0];
                int qty = Int32.Parse(movement[1]);


                if (dir == "down")
                    aim += qty;
                else if (dir == "up")
                    aim -= qty;
                else if (dir == "forward")
                {
                    x += qty;
                    y += aim * qty;
                }
            }

            Console.Out.WriteLine($"Answer: {x * y}");
        }
    }
}
