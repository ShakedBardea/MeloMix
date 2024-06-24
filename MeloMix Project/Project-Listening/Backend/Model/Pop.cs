using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Listening.Backend.Model
{
    [Serializable]
    public class Pop : Song
    {
        public string GeographicAffiliation { get; set; }

        public Pop(string name,string publicationDate, string time,string language,  string gener, string artist, bool clip, string geographicAffiliation)
            : base(name, publicationDate, time, language,gener, artist,clip)
        {
            GeographicAffiliation = geographicAffiliation;
        }

    }
}