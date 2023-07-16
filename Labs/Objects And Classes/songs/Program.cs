using System;
using System.Linq;
using System.Collections.Generic;

namespace songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songAtributes = Console.ReadLine().Split('_');
                string typeList = songAtributes[0];
                string songName = songAtributes[1];
                string time = songAtributes[2];

                Song song = new Song(typeList, songName, time);

                songs.Add(song);
            }

            string printCondition = Console.ReadLine();

            if (printCondition == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == printCondition)
                    {
                        Console.WriteLine(song.Name);
                    } 
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}