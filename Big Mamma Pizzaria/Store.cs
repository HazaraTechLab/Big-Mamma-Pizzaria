using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mamma_Pizzaria
{
    internal class Store
    {
       public Store()
        {
            
        }
        public void Start()
        {
            Pizza pizza1 = new Pizza(22, "peperoni", "ost, peperoni, tomatsuce, dresing", 90);
            Pizza pizza2 = new Pizza(34, "Hawaii", "ost,skinke,tomatsuce", 80);
            Pizza pizza3 = new Pizza(66, "Sicilian", "mosaghala ost,hvidløg, hækkebeef", 75 );

            kunde kunde1 = new kunde("John", 48656788, "roskilde");
            kunde kunde2 = new kunde("Søren ", 33144667, "rosehaven");
            kunde kunde3 = new kunde("Peter", 33116667, "roskilde");

            ordrer order1 = new ordrer();
            ordrer ordrer2 = new ordrer();
            ordrer ordrer3 = new ordrer();

        }
        public override string ToString()
        {
            return $" ";
        }


    }
}
