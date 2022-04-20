using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rugby
{
    internal class Tools
    {
        //her er public metode så hele programmet kan se denne metetode 
        public static void PrintArray(string[] r)
        {
            //for motode hvor den counter hvor mange der er og siger der er 5
            //derfor udskriver den kun de 5 som stå i r
            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine(r[i]);
                
            }
            Console.WriteLine();
            //foreach loop
            foreach (string s in r)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            //counter til while løkken da det er vigtigt at man samlinger med noget i en while loop
            int counter =0;
            //while lopp hvor den køre så længe at counter er mindre en r length
            while (counter < r.Length)
            {
                Console.WriteLine(r[counter]);
                counter++;
            }
        }
    }
}
