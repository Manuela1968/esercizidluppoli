using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace classi_creazione
{
    internal class Libro
    {
        // CAMPI
        public string titolo;
        public string autore;
        public float prezzo;
        public DateTime creazione;

        // COSTRUTTORI
        public Libro(string titolo, string autore, float prezzo) : this(titolo, autore)
        {
            // posso fare un controllo sul prezzo IF (prezzo <=0)
            //                                    this.prezzo = 9999
            //                                    ELSE this.prezzo = prezzo
            this.prezzo = prezzo; 
        }
        public Libro(string titolo, string autore) : this(titolo)
        {
            this.titolo = titolo.Trim();
            this.autore = autore;
        }
        public Libro(string titolo) // :this()
        {
            this.titolo = titolo.Trim();
            creazione = DateTime.Now; // ---> va sempre nell'ultimo costruttore che ho creato OPPURE
        }
        /* public Libro() 
        {
            creazione = DateTime.Now; 
        }  .. SE LO CREO AUTONOMO */
    }
}
