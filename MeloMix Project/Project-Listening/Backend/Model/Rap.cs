using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Listening.Backend.Model
{
    [Serializable]
    public class Rap : Song
    {
        public bool WithMelody{ get; set; }

        public Rap(string name, string publicationDate, string time, string language,string gener, string artist, bool clip, bool withMelody)
            : base(name, publicationDate, time, language ,gener, artist, clip)
        {
            WithMelody= withMelody;
        }
    }
}
