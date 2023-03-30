using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi

{       //lavoro dentro una CLASSE PROGRAM
        /* enum DayOfWeek
        { Monday, Tuesday, Wednesday, ecc 
        } */

    internal class Program
    { 
        static void Main(string[] args)  // MAIN è un METODO DELLA CLASSE PROGRAM
        {

           /*DayOfWeek oggi = DayIfWeek.Monday;  
           OPPURE
            System.DayOfWeek oggi = System.DayIfWeek.Monday; */

            /* DateTime oggi = new DateTime(2023, 3, 23);
             Console.WriteLine(oggi.ToString("dddd dd MMMM yyyy"));
             Console.WriteLine($"oggi è il {oggi.DayOfYear}° giorno dell'anno");*/

            Console.WriteLine("premi invio per iniziare");
            Console.ReadLine(); 
            DateTime start = DateTime.Now;
            Console.WriteLine(start);

            Console.WriteLine("premi invio per fermare");
            Console.ReadLine();
            DateTime stop = DateTime.Now;
            Console.WriteLine(stop);
    
            TimeSpan intervallo = stop.Subtract(start);
           
            //calcolare quanto tempo è passato
         
            Console.WriteLine($"sono passati {Math.Round( intervallo.TotalSeconds,2)} secondi");

            Console.ReadLine();

        }
    }
}
