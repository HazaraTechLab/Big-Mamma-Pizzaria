using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mamma_Pizzaria
{
    internal class kunde
    {
      
        public string Name;
        public int PhuneNum;            
        public string Adress;

        public kunde(string Name, int PhuneNum, string Adress)
        {
            
            Name = Name;
            PhuneNum = PhuneNum;
            Adress = Adress;
        }
        public override string ToString()
        {
            return $"Name:{Name},PhuneNem:{PhuneNum},Adress:{Adress}";
        }
    }
}
