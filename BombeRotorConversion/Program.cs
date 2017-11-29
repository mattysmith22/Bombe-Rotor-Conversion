using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombeRotorConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            long valueIn;

            while(true)
            {
                Console.Write("Base 10 value in: ");

                if(long.TryParse(Console.ReadLine(), out valueIn))
                {
                    Console.Clear();
                    Console.WriteLine(Converter.GenerateLetterString(valueIn, true));
                }
            }
        }
    }
}