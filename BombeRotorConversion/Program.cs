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
            int valueIn;

            while(true)
            {
                Console.Write("Base 10 value in: ");

                if(int.TryParse(Console.ReadLine(), out valueIn))
                {
                    Console.WriteLine(Converter.GenerateLetterString(valueIn));
                }
            }
        }
    }
}