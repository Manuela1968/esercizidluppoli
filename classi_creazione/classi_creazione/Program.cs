using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi_creazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  Libro l1 = new Libro();
            l1.titolo = "La divina commedia";
            l1.autore = "Dante Alighieri";
            l1.prezzo = 18.99f; */

            Libro l1 = new Libro("la Divina Commedia","Dante Alighieri", 18.99f);
            
            Console.WriteLine($"{l1.titolo} di {l1.autore} prezzo {l1.prezzo}");
            Console.ReadLine();

            Libro l2 = new Libro("I promessi sposi", "Alessandro Manzoni");
            Console.WriteLine($"{l2.titolo} di {l2.autore} prezzo {l2.prezzo} \n data creazione: {l2.creazione}");

            Console.ReadLine();

        }
    }
}
