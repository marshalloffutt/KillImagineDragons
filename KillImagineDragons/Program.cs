using System;
using System.Collections.Generic;
using System.Linq;

namespace KillImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            var allSongs = new List<Song>();

            allSongs.Add(new Song("Title Fight", "Shed"));
            allSongs.Add(new Song("Les Savy Fav", "The Sweat Descends"));
            allSongs.Add(new Song("Rainer Maria", "Tinfoil"));
            allSongs.Add(new Song("Iceage", "White Rune"));
            allSongs.Add(new Song("At the Drive-In", "Chanbara"));
            allSongs.Add(new Song("Imagine Dragons", "It's Time"));
            allSongs.Add(new Song("Mission of Burma", "Academy Fight Song"));
            allSongs.Add(new Song("Hüsker Dü", "Something I Learned Today"));
            allSongs.Add(new Song("Imagine Dragons", "Radioactive"));
            allSongs.Add(new Song("Parquet Courts", "Total Football"));
            allSongs.Add(new Song("Unwound", "Lady Elect"));
            allSongs.Add(new Song("Ted Leo & The Pharmacists", "Biomusicology"));

            var goodSongs = allSongs.Where(Song => Song.Artist != "Imagine Dragons").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }

            Console.ReadKey();
        }
    }
}
