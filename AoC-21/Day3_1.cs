using System;
using System.IO;

namespace AoC_21
{
    class Day3_1
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines( "inputs/input3.txt" );

            int numBits = lines[0].Length;
            double[] sumOfBits = new double[numBits];
            double[] avgOfBits = new double[numBits];
            char[] tmpBits;
            int[] gamma = new int[numBits];
            int[] epsilon = new int[numBits];

            for ( int i = 0; i < lines.Length; i++ )
            {
                tmpBits = lines[i].ToCharArray();

                for ( int y = 0; y < tmpBits.Length; y++ )
                    sumOfBits[y] += Double.Parse( tmpBits[y].ToString() );
            }

            for( int x = 0; x < sumOfBits.Length; x++ )
                avgOfBits[x] = sumOfBits[x] / (double)lines.Length;

            for( int g = 0; g < numBits; g++ )
            {
                gamma[g] = (int) Math.Round( avgOfBits[g] );
                epsilon[g] = (int)((byte)gamma[g] ^ 1);
            }

            int answer = Convert.ToInt32( String.Join("", gamma), 2 ) 
                       * Convert.ToInt32( String.Join("", epsilon), 2 );

            Console.Out.WriteLine( $"Answer: {answer}" );
        }
    }
}
