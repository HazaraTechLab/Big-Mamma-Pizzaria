using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Big_Mamma_Pizzaria
{
    internal class drikke
    {
        public string name;
        public int price;
       
       public drikke(string aname, int aprice)
        {
            name = aname;
            price = aprice;
        }
        public override string ToString()
        {
            return $"name:{name}, price:{price}";
        }
    }
    
    
}
