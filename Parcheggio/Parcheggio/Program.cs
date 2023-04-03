using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veicolo> veicoli = new List<Veicolo>();
            while (true)
            {
                // Console.Clear();
                Console.WriteLine("1- Inserimento targa e orario nuovo veicolo in ingresso");
                Console.WriteLine("2- lista veicoli nel parcheggio");
                Console.WriteLine("3- pagamento veicolo  ");

                Console.WriteLine("\n9- Esci");

                string scelta = Console.ReadLine();

                if (scelta == "1")
                {
                    Console.Write("Inserire la TARGA: ");
                    string targa = Console.ReadLine();
 
                    veicoli.Add(new Veicolo(targa, start));
                    Console.WriteLine(targa, start);
                    Console.ReadLine();
                  
                    //modifica di prova
                  
                }
            }
        }
    }
}
