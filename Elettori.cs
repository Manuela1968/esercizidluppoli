using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creo una variabile 
            /*string messaggio = "Hello Word";
            int saldo = 12;

            saldo = saldo - 300;
            saldo = saldo - 10;
            Console.WriteLine(saldo); */


            double raggio = 12.5;
            const double piGrego = 3.14;

            int baseTriangolo = 13;
            int altezzaTriangolo = 7;
            double areaTriangolo = baseTriangolo * altezzaTriangolo / 2.0;


            double area = raggio * raggio * piGrego;
            Console.WriteLine(area);


            //Questa istruzione stampa su console 
            Console.WriteLine("Hello Word!"); 


            /*QUesta istruzione legge da tasteria fino a
            quando non premo il tasto enter*/
            Console.ReadLine();

            int x = 10;
            x = x + 1;

            x++; //x=x+1
            x--; //x=x-1
            x += 7; //x=x+7;
            x -= 7; //x=x-7
            x *= 7; //x=x*7
            x /= 7; //x=x/7


            bool variabileBooleane = false;

            int n = 100;

            bool ePari;
            ePari = n % 2 == 0;
            Console.WriteLine(ePari);

            const int eta = 22;
            const int MaggioreEta = 18;
            bool eMaggiorenne = eta >= MaggioreEta;




            


        }
    }
}
