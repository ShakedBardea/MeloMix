using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Listening.Backend.Model
{
    [Serializable]
    public class Comedy : Podcast
    {
        public bool IsComedian { get; set; }
        

        public Comedy(string name, string publicationDate, string time, string language,  string type, string creator, string targetGroup, bool isComedian)
            : base(name, publicationDate, time, language, type, creator, targetGroup)
        {
            IsComedian = isComedian;
        }
    }
}
