using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Listening.Backend.Model
{
    [Serializable]
    public abstract class Song : Listening
    {
        public string Gener { get; set; }
        public string Artist { get; set; }
        public bool Clip { get; set; }

        protected Song(string name, string publicationDate, string time,string language,string gener, string artist, bool clip)
            : base(name, publicationDate, time, language)
        {
            Gener = gener;
            Artist = artist;
            Clip = clip;
        }
    }
}
