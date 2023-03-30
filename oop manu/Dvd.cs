using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Dvd : IElementoLibreria
    {
        string titolo;

        public Dvd(string titolo);
        {
            this.titolo = titolo;
        }

        public bool Certains(string ricerca);
        {
            return titolo.ToLower().Contanis(ricerca.ToLower(();
        }

        public string getInfo();
        {
            return titolo; 
        }
    }
}
