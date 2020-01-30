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
            Console.Write("Hello please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            string age = Console.ReadLine();

            Console.WriteLine("hey " + name + " you are " + age + " years old.");
        }
    }
}
