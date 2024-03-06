using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Big_Mamma_Pizzaria
{
    internal class ordrer
   {
    private string ordrer1;
    private string ordrer2;
    private string ordrer3;
    
    public void order(string aordrer1, string aordrer2, string aordrer3) 
        {
        ordrer1 = aordrer1;
        ordrer2 = aordrer2;
        ordrer3 = aordrer3;
        }
        public override string ToString()
        {
            return $"ordrer1:{ordrer1}, ordrer2:{ordrer2}, ordrer3:{ordrer3}";
        }
    }


}





