using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicli
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ciclo precondizionato : stampare i 10 n SUCCESSIVI il numero dato

            //inizializzazione
            const int daStampare = 2;
            int n = 74;
            int cont = 0;

            while (cont < daStampare)
            {
                //corpo
                n = n + 1;
                Console.WriteLine(n);
                //incremento
                cont = cont + 1;
            }

            for (int j = 0; j < daStampare; j++)
            { 
                n++;
                Console.WriteLine(n);
                Console.ReadLine();
            }
        

        //ciclo precondizionato : stampare i 10 anni bisestili SUCCESSIVI all'anno dato

        //inizializzazione

        int daStampare1 = 10;
        int anno = 1968;
        int i = 0;

            while (i < daStampare1)

            {   // verifico se anno è bisestile: se è bisestile LO STAMPO 
                // incremento l'anno
                // incremento contatore
                // corpo
                // se non è bisestile incremento solo l'anno

                    bool bisestile = (anno % 4 == 0 && anno % 100 != 0) || (anno % 400 == 0);
                    if(bisestile)
                {
                        Console.WriteLine(anno);  
                        n = n + 1;
                }
                
                anno++;
                i++;
            }
           
            Console.WriteLine(anno);

        Console.ReadLine();
        }
    }
}
