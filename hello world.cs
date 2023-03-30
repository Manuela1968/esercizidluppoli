using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //creo variambili
            string messaggio = "Hello World2";
            int numero = 10;
            numero = numero * 2;
            Console.WriteLine(numero);

            //calcolo area
            float raggio = 12.5f;
            const double PiGreco = 3.14;
            double area = raggio * raggio * PiGreco;
            Console.WriteLine(area);

            //Questa istruzione stampa su console
            Console.WriteLine("Hello World1");
            Console.WriteLine(messaggio);

            //istruzione per attendere il tasto ENTER
            //..... continua commento precedente OPPURE
            /* commento nultiriga*/
           
            int n = 100;
            bool variabileSePari ;
            variabileSePari = n % 2 == 0;
            Console.WriteLine(n);
            Console.WriteLine("il numero inserito è pari?");
            Console.WriteLine(variabileSePari);
           
            int eta = 17;
            bool verificaEta = eta >= 18;
            Console.WriteLine(eta); 
            Console.WriteLine("La persona è maggiorenne?");
            Console.WriteLine(verificaEta);
      
            eta = 20;
            verificaEta = eta >= 18;
            Console.WriteLine(eta);
            Console.WriteLine("La persona è maggiorenne?");
            Console.WriteLine(verificaEta);
            Console.ReadLine();

        }
    }
}
