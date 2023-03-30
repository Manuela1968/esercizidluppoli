using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal abstract class Libro : IElementoLibreria // ABSTRACT nu serve perchè nessuno potrà mai creare
                                  // un libro GENERICO
                                  // ma devo poter creare SOLO tipi di FIGLI (LibroDigitale o LibroCartaceo

    {
        //Campi
        public string titolo;
        public string autore;

        //Obiettivo > 0 (se si tenta di settare un valore <= 0 impostarlo a 9999)
        private float? prezzo = null; //questo è quello che uso solo io 

        public float? Prezzo // le {} mi dicono che Prezzo è una PROPRIETA' ciOè
                            // FA QUALCOSA e non è solo una variabile
        {
            get
            {
                return prezzo;    
            }
            set
            {
                if (value < 0)
                    prezzo = null;
                else
                    prezzo = value;
            }
        }

        //Obiettivo in sola lettura
        public DateTime creazione { get; }


        //Costruttori
        public Libro(string titolo, string autore, float prezzo) : this(titolo,autore)
        {
            //titolo --> La divina commedia
            //autore --> Dante alighieri
            //prezzo --> 19.99
            //this.titolo = titolo.Trim();
            //this.autore = autore;

            /*if (prezzo <= 0)
                this.prezzo = 9999;
            else
                this.prezzo = prezzo;*/
            Prezzo = prezzo;
        }

        public Libro(string titolo, string autore) : this(titolo)
        {
            this.autore = autore;
        }

        public Libro(string titolo) : this()
        {
            this.titolo = titolo.Trim(); // TRIM toglie gli spazi vuoti prima e dopo
        }

        public Libro()
        {
            this.creazione = DateTime.Now; // questo costruttore che non riceve altri dati ,
                                           // mi mette solo la data di creazione di un libro nuovo
        }
    
        //Metodi
        public virtual string getInfo() // VIRTUAL mi serve perchè poi potrò fare L'OVERRIDE negli oggetti figli 
        {
            return $"{titolo} - {autore} - Prezzo: {prezzo} - creato il {creazione}";
            //     $ string interpolation
        }

        public void aumentaPrezzo(float percentuale)
        {
            prezzo = prezzo * (1 + percentuale / 100);
        }

        public bool Contains(string ricerca)
        {
            ricerca = ricerca.ToLower

            return l.titolo.ToLower().Contanis(ricerca) || l.autore.ToLower().Contanis(ricerca);
            /* significa :
            if (l.titolo.ToLower().Contanis(ricerca) || l.autore.ToLower().Contanis(ricerca))
                return true
            else 
                trovato = true;*/
        }
    }
}
