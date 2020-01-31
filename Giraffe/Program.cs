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
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song lithium = new Song("Lithium", "Nirvana", 225);

            Console.WriteLine(Song.songCount);
            Console.WriteLine(lithium.song);
            Console.WriteLine(holiday.getSongCount());
        }
    }
}
