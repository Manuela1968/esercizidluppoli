using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clessidra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CLESSIDRA   spazi / asterischi
             *  *****
             *   ***
             *    *
             *   ***
             *  *****
             * */

            int n = 7;
            int spazi = 0;
            int aster = n;

            for (int i = 0; i < n; i++)
            {
                // stampo gli spazi e gli asterischi
                for (int j = 0; j < spazi; j++) Console.Write(" ");
                for (int j = 0; j < aster; j++) Console.Write("*");
              

                if (i < n / 2)
                {
                    spazi++;
                    aster -= 2;

                }
                else
                {
                    spazi--;
                    aster += 2;
                }

            }
            Console.ReadLine();


        }
    }
}
