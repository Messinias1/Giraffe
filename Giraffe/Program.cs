using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            var num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        }
    }
}
