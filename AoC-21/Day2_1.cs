using System;
using System.IO;

namespace AoC_21
{
    class Day2_1
    {
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("inputs/input2.txt");

            int x, y;
            x = y = 0;

            foreach(string line in lines)
            {
                string[] movement = line.Split(" ");

                if(movement[0] == "up")
                    y -= Int32.Parse(movement[1]);
                else if(movement[0] == "down")
                    y += Int32.Parse(movement[1]);
                else if(movement[0] == "forward")
                    x += Int32.Parse(movement[1]);
            }

            Console.Out.WriteLine($"Answer: {x * y}");
        }
    }
}
