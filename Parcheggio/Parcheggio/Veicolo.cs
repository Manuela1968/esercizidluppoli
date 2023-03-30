using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio
{
    internal class Veicolo
    {
        public string targa;
        public DateTime start = DateTime.Now;
        public DateTime stop = DateTime.Now;

        public TimeSpan intervallo
        {
            get
            {
                return stop.Subtract(start);
            }
            set { }
        }
        
       
        public Veicolo(string targa, DateTime start, DateTime stop, TimeSpan intervallo) : this(targa, start, stop)
        {
            this.intervallo = intervallo;
        }
        public Veicolo(string targa, DateTime start, DateTime stop) :this(targa,start)
        {
            this.targa = targa;
            this.start = start;
            this.stop = stop;
        }
        public Veicolo(string targa, DateTime start) 
        {
            this.targa = targa;
         
    }
        public string getInfo() 
        {
            return $" veicolo : {targa} - ora di entrata {start} -  ora di uscita{stop} - {intervallo}";
        }
    } 
    


}
