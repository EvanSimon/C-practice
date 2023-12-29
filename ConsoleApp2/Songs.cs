using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Songs
    {
        public string Artist { get; set; }
        public string Title  { get; set; }
        public double Duration { get; set; }

        public SongType Type  { get; set; }

        public Songs(string artist, string title, double duration, SongType type)
        {
            Artist = artist;
            Title = title;
            Duration = duration;
            Type = type;
        }
    }

    public enum SongType
    {
        Christmas,
        Rock,
        Rap,
        Jazz,
        Classical,

    }
}
