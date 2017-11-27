using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombeRotorConversion
{
    class Converter
    {
        private static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string GenerateLetterString(int input)
        {
            string outString = "";

            int numOfChars = (int)Math.Ceiling(Math.Log(input, chars.Length));

            if (numOfChars == 0)
            {
                numOfChars = 1;
            }

            byte[] letterValues = new byte[numOfChars];

            for (int n = 0; n < input; n++)
            {
                letterValues[0] += 1;

                for(int i = 0; i < numOfChars; i++)
                {
                    if (letterValues[i] > 26)
                    {
                        letterValues[i] = 1;
                        letterValues[i+1] += 1;
                    }
                }
            }

            foreach (int value in letterValues)
            {
                outString = chars[value - 1] + outString;
            }

            return outString;
        }
    }
}
