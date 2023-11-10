using System;
using System.Collections.Generic;
using System.Text;

namespace EX29WPFMusicLibrary
{
    class Track
    {
        string artist = "";
        string title = "";
        byte min = 0;
        byte sec = 0;

        public string Artist { get => artist; set => artist = value; }
        public string Title { get => title; set => title = value; }
        public byte Min { get => min; set => min = value; }
        public byte Sec { get => sec; set => sec = value; }


        public Track(string artist, string title, byte min, byte sec)
        {
            Artist = artist;
            Title = title;
            Min = min;
            Sec = sec;
        }

        public override string ToString()
        {
            if (Sec < 10) { return $"{Title}: {Artist} ({Min}:0{Sec})"; }
            else // if (Sec >= 10)
            {
                return $"{Title}: {Artist} ({Min}:{Sec})";
            }

        }
    }
    
}
