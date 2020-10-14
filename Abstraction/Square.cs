using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    
    //inheritance- parnemam visas ipasibas un metodes, ja kadu ipasibu mantot negribam, private vmesto public, togda dostupna budet toljko v etom klasse
   public class Square : Rectangle
    {
        // public int Side1; uzhe ne nado
        public Square(int side1)
            : base(side1, side1)//vizvatj konstruktor
        {
            //  Side1 = side1;

        }
        // public int Area () tozhe ne nado
        // {
        //    return Side1 * Side1;

        //}
    }
}


   
