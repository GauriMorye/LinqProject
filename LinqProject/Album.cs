using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    public class Album
    {
        public Album(string name,string artist,string lang)
        {   
            AlbumName = name;
            Artist=artist;
            Language=lang;
            
        }
        public string AlbumName { get; set; }
        public string Artist { get; set; }

        public string Language { get; set; }

    }
}
