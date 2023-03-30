using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crivello_numeri_primi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 
            int n = 50;
            bool[] numeri = new bool[n + 1];
            numeri[0] = false; //il primo numero dell'array parte da 0 quindi il valore glielo mettiamo noi

            for (int i = 0; i < numeri.Length; i++) // riempio le caselle con tutti true come se fossero tutti 1°
            {
                numeri[i] = true;

            }
       

            for (int i = 2; i < n; i++) //ciclo esterno
                if (numeri[i] == true)
                {

                    for (int j = i + 1; j <= n; j++) //ciclo interno
                    {
                        if (numeri[j] == true && j % i == 0) /* vuol dire che è pari*/ numeri[j] = false;

                    }
                }

            List<int> numeriPrimi = new List<int>();
            for (int i = 0; i <= 0; i++)

                if (numeri[i] == true) numeriPrimi.Add(i);


            foreach (int numero in numeriPrimi) Console.WriteLine(numero);
            Console.ReadLine();

          
        }
    }
    }
  

