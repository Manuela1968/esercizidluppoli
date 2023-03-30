using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayDiVoti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            


            // voti
            float[] voti = new float[5] { 20, 30, 25, 21, 28 };
            int cont = 0;
            float somma = 0;
            
            for (cont = 0; cont < voti.Length; cont++)
               {
                somma = somma + voti[cont];
                Console.WriteLine(somma);
               }
            Console.WriteLine(somma / cont); //posso usare anche la lunghezza dell'indice array.lenght
     
            }
    }
}
