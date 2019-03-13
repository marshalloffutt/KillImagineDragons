using System;
using System.Collections.Generic;
using System.Text;

namespace KillImagineDragons
{
    class Song
    {
        public string Artist { get; }
        public string Name { get; }

        public Song(string artist, string name)
        {
            Artist = artist;
            Name = name;
        }
    }
}
