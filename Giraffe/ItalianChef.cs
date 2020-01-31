using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Italian Chef Makes Chicken Parm");
        }
        public void MakePasta()
        {
            Console.WriteLine("The Italian Chef Makes Pasta");
        }
    }
}
