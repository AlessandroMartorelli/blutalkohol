using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blutalkohol
{
    internal class CLSBlutalkohol
    {
        //Attributes
        private double ergebnis = 0.0;
        private double faktor = 0.7;
        // Properties 
        public double Masse { get; set; }
        public double Volumen { get; set; }
        public double Prozent { get; set; }
        public string Geschlecht { get; set; }

        //Methods 
        public double Berechnen() 
        {
            if (Geschlecht == "m") faktor = 0.7;
            else if (Geschlecht == "f") faktor = 0.6;
            else faktor = 0.8; 

            double A = Volumen*(Prozent/100)*0.8;
            ergebnis = A / (Masse * faktor);
            return ergebnis;
            
        
        
        
        
        
        }

    }
}
