using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC_21
{
    class Day3_2
    {
        public int Execute()
        {
            string[] lines = File.ReadAllLines("inputs/input3.txt");

            var oxy = Convert.ToInt32( Filter(lines, true)[0], 2 );
            var c02 = Convert.ToInt32( Filter(lines, false)[0], 2 );

            return oxy * c02;
        }

        private string[] Filter(string[] linesArray, bool mostCommon)
        {
            for (int pos = 0; ; pos++)
            {
                linesArray = FilterByPosition(linesArray, pos, mostCommon);

                if (linesArray.Length == 1)
                {
                    return linesArray;
                }
            }
        }

        private string[] FilterByPosition(string[] linesArray, int pos, bool mostCommon)
        {
            int counter = linesArray.Count(x => x[pos] == '1');

            int half = (int)Math.Ceiling(linesArray.Length / 2f);

            char bitToKeep;

            if( (mostCommon && counter >= half) ||
                (!mostCommon && counter < half) )
            {
                bitToKeep = '1';
            }
            else
            {
                bitToKeep = '0';
            }

            return linesArray.Where(x => x[pos] == bitToKeep).ToArray();
        }
    }
}
