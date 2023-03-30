using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD --> Create, Read, Update, Delete

            //Strutte per contenere i dati
            List<IElementoLibreria> libreria = new List<IElementoLibreria>();

            /*libreria.Add(new LibroCartaceo("libroA", "AutoreA", 10, 500));
            libreria.Add(new LibroDigitale("libroB", "AutoreB", 20, 1024));
            Libro l = new LibroCartaceo("libroC", "Autorec", 30, 600);
            libreria.Add(l);
            foreach (Libro libro in libreria)
            {
                libro.getInfo();
                    if libro.GetType() == typeof(LibroCartaceo);
            }
            */

            while (true) // espressione booleana per iniziare un ciclo infinito finchè
                         // non decido che ho terminato il mio lavoro (nel nostro caso
                         // con il breack sul valore 9
            {
                //Console.Clear();
                Console.WriteLine("1- Inserimento nuovo libro");
                Console.WriteLine("2- Stampa elenco libro");
                Console.WriteLine("3- Stampa numero di libri");
                Console.WriteLine("4- Ricerca libro");
                Console.WriteLine("5- Stampa libri in ordine alfabetico di autore");
                Console.WriteLine("\n9- Esci");

                string scelta = Console.ReadLine();

                if (scelta == "1")
                {
                    Console.Write("Inserire il titolo: ");
                    string titolo = Console.ReadLine();
                    Console.Write("Inserire l'autore: ");
                    string autore = Console.ReadLine();
                    float prezzoFloat;
                    string prezzo;

                    do
                    {
                        Console.Write("Inserire il prezzo: ");
                        prezzo = Console.ReadLine();

                    }
                    while (!float.TryParse(prezzo, out prezzoFloat)); //tryparse mi richiede il
                                                                      //dato finchè non inserisco quello corretto
                    libreria.Add(new LibroCartaceo(titolo, autore, prezzoFloat));
                }

                if (scelta == "2")
                {
                    foreach (IElementoLibreria l in libreria) Console.WriteLine(l.getInfo());
                }

                if (scelta == "3")
                {
                    Console.WriteLine("n. libri nella libreria: " { libreria.Count} libri);
                }

                if (scelta == "4")
                {
                    Console.WriteLine("inserisci il testo da cercare: ");
                    string ricerca = Console.ReadLine().ToLower();
                    bool trovato = false
                    foreach (Libro l in libreria)
                    {
                        if (l.Contanis(ricerca))
                        {
                            Console.WriteLine(l.getInfo());
                            trovato = true;
                        }
                    }
                        if (trovato == false)
                    {
                        Console.WriteLine("Nessun libro trovato!");
                    }
                }

                if (scelta == "5")
                {
                }
                

                if (scelta == "9") break; 
                }

                Console.WriteLine("Terminato!");
                Console.ReadLine();
            }
        }
    }
}
