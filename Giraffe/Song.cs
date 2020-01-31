using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Song
    {
        public string song;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string aSong, string aArtist, int aDuration)
        {
            song = aSong;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
