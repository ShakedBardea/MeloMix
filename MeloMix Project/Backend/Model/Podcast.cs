using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Listening.Backend.Model
{
    [Serializable]
    public abstract class Podcast : Listening
    {
        public string Type { get; set; }
        public string Creator{ get; set; }
        public string TargetGroup{ get; set; }

        protected Podcast(string name, string publicationDate, string time, string language,string type, string creator, string targetGroup)
            : base(name,publicationDate,time, language)
        {
            Type = type;
            Creator = creator;
            TargetGroup = targetGroup;
        }
    }
}
