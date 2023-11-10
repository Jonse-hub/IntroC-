using System;
using System.Collections.Generic;
using System.Text;

namespace EX29WPFMusicLibrary
{
    class Playlist
    {
        string name = "";

        List<Track> tracks = new List<Track>();

        public string Name { get => name; set => name = value; }
        internal List<Track> Tracks { get => tracks; set => tracks = value; }


        public Playlist(string name) 
        {
            Name = name;
        }

        public void AddTrack(Track t)
        {

            Tracks.Add(t);
        }
        public void RemoveTrack(Track t)
        {
            Tracks.Remove(t);
        }
        public Track FindShortestTrack()
        {
            // Tracks[0].Min + tracks[0].Sec;
            float ShortestFloat = float.Parse($"{Tracks[0].Min}.{Tracks[0].Sec}");

            Track shortest = Tracks[0];

            for (int i = 1; i < Tracks.Count; i++)
            {
                if (float.Parse($"{Tracks[i].Min}.{Tracks[i].Sec}") < ShortestFloat)
                {
                    ShortestFloat = float.Parse($"{Tracks[i].Min}.{Tracks[i].Sec}");
                    shortest = Tracks[i];
                }

            }
            return shortest;

        }

        

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
