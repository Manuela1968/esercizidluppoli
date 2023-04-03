using System;
using System.Collections;
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
            DateTime start = DateTime.Now;
            DateTime? stop = null;
            string scelta ; 

            do
            {
                // Console.Clear();
                Console.WriteLine(start);
                Console.WriteLine("1- Inserimento targa e orario nuovo veicolo in ingresso");
                Console.WriteLine("2- lista veicoli nel parcheggio");
                Console.WriteLine("3- pagamento veicolo  ");
                Console.WriteLine("\n9- Esci");

                scelta = Console.ReadLine();
               

                if (scelta == "1")
                {
                    Console.Write("Inserire la TARGA: ");
<<<<<<< HEAD
                    string targa = Console.ReadLine(); 
                    Console.Write($"veicolo entrato : " + targa + " alle ore " +  start + " \n(premi ENTER per continuare) ");
                    veicoli.Add(new Veicolo(targa, start, stop));
                 
=======
                    string targa = Console.ReadLine();
 
                    veicoli.Add(new Veicolo(targa, start));
                    Console.WriteLine(targa, start);
                    Console.ReadLine();
                  
                    //modifica di prova
                  
>>>>>>> a3af27a2519670c65171dbfd07c409bcd72220b9
                }

                if (scelta == "2")
                {
                    foreach (Veicolo auto in veicoli)
                    {
                        Console.WriteLine(auto.targa);
                    }
                    Console.WriteLine("elenco veicoli nel parcheggio (Premi enter per continuare)");
                }

                else if (scelta == "3")
                {
                    Console.Write("inserire la targa ricercata: ");
                    string ricerca = Console.ReadLine();
                    bool trovato = false;
                    foreach (Veicolo auto in veicoli)
                    {
                        if (auto.targa.ToLower().Contains(ricerca))
                        {   trovato = true;
                            auto.stop = DateTime.Now;
                            TimeSpan intervallo = (DateTime)auto.stop - auto.start;
                            Console.Write(intervallo);
                            double ore = Math.Ceiling(intervallo.TotalHours);
                            Console.Write(ore);
                           
                            if (ore > 1)
                            {   
                                Console.WriteLine(auto.getInfo() + " \nImporto da pagare:\n " + ore * 2 + " € \n");
                                veicoli.Remove(auto);
                                break;
                            }
                            else if (ore <= 1)
                            {  
                                Console.WriteLine(auto.getInfo()  + " \nImporto da pagare: 2 € ");
                                veicoli.Remove(auto);
                                break;
                            }
                        }
                    }
                    if (trovato == false)
                    {
                       Console.WriteLine("\nNessun veicolo trovato\n\nPremai enter per continuare...");
                    }

                }
                Console.ReadLine();
                Console.Clear();

            } 
            while (scelta == "1" || scelta == "2" || scelta == "3");

        }
    }
    
}
