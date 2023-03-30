using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // float[] voti = new float[5] { 20, 30, 25, 21, 28 };
            List<int> voti = new List<int>() {10,4,7,6} ;
            voti.Add(9);
            int cont = 0;
            float somma = 0;

            for (cont = 0; cont < voti.Count; cont++)
            {
                somma = somma + voti[cont];
                // o anche  somma += voti[indice];
                Console.WriteLine(somma);
            }
            Console.WriteLine(somma / cont); //posso usare anche la lunghezza dell'indice array.lenght

            float somma1 = 0;
            foreach (int voto  in voti)
            {
                somma1 += voto;
            }
            Console.WriteLine(somma);
            Console.ReadLine();
        }
    }
}
