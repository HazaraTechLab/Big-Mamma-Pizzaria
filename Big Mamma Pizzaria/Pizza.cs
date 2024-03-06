using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Big_Mamma_Pizzaria
{
    internal class Pizza
    {
        public int Num;
        public string Name;
        public string Description;
        public int Price;


        public Pizza(int aNum, string aName, string aDescription, int aPrice)
        {
            Num = aNum;
            Name = aName;
            Description = aDescription;
            Price = aPrice;
        }
        public override string ToString()
        {
            return $"Num:{Num},Name:{Name},description:{Description},price:{Price}";
        }
    }
}
