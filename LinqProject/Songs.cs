using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    public class Songs
    {
        public Songs(int songId, string songName, string artist, double duration)
        {
            SongId = songId;
            SongName = songName;
            Artist = artist;
            this.duration = duration;
        }

        public int SongId { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }
        public double duration { get; set; }

    }
}
