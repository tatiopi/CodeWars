using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           int resultado =  DigitalRoot(942);
        }

        // Mi metodo
        /*public static int DigitalRoot(long n)
        {
            string numberToString = n.ToString();
            int resultNumber = 0;
            for (var i = 0; i < numberToString.Length; i++)
            {
                resultNumber = resultNumber + Convert.ToInt32((numberToString[i].ToString()));
            }

            if (resultNumber > 9 )
            {
                resultNumber = DigitalRoot(resultNumber);
            }

            return resultNumber;
        }
        */

        public static int DigitalRoot(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }

    }


}
