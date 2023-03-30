using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string s = "*";
            int n = 7;

            for (int i = 0; i < n; i++)
            {
                // prima soluzione:fare un triangolo con le stelline con un solo for 

                //Console.WriteLine(s);
                //s = s + "*";

                //seconda soluzione: fare un triangolo con le stelline con for dentro for
                  for (int j = 0; j < i+1; j++)
                  {
                  Console.Write("*");  //--->Console.Write stampa tutto su una riga
                  }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
         
           
     }

     
      
   
