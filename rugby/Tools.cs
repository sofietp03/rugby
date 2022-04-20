using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rugby
{
    internal class Tools
    {

        public static void PrintArray(string[] r)
        {
            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine(r[i]);
                
            }
            Console.WriteLine();
            foreach (string s in r)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            int counter =0;
            while (counter < r.Length)
            {
                Console.WriteLine(r[counter]);
                counter++;
            }
        }
    }
}
