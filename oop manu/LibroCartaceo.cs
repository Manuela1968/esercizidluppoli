using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class LibroCartaceo : Libro // LibroCartaceo è figlio di Libro e ne EREDITA tutto 
                                         // tranne i costruttori
    {
        public uint pagine { get; set; } 

        public LibroCartaceo(string titolo, string autore, float prezzo, uint pagine) : this(titolo,autore,prezzo)
                                                                                    // qui uso THIS perchè il numero
                                                                                    // di pagine ce l'ho solo qui
        {
            this.pagine = pagine;
        }

        public LibroCartaceo(string titolo, string autore, float prezzo) : base(titolo,autore,prezzo) // BASE richiama il
                                                                                                      // costruttore della MADRE
        {
        }

        public LibroCartaceo(string titolo, string autore) : base(titolo,autore)
        {
        }

        public LibroCartaceo(string titolo) : base(titolo)
        {
        }

        public LibroCartaceo() : base() // questo mi restituisce solo la data di creazione
        {
        }

        public override string getInfo() // OVERRIDE : EREDITO E MODIFICO il metodo "getInfo"
                                         // che è presente nella MADRE 
        {
            return base.getInfo() + $" {pagine} pagine";
        }
    }
}
