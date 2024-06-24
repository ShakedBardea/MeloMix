using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Listening.Backend.Model
{
    [Serializable]
    public class Educational : Podcast
    {
        public string Topic { get; set; }
        public bool IsCreatorSpecialization { get; set; }


        public Educational(string name, string publicationDate, string time, string language, string type, string creator, string targetGroup, string topic, bool isCreatorSpecialization)
            : base(name, publicationDate, time, language,type, creator, targetGroup)
        {
            Topic = topic;
            IsCreatorSpecialization= isCreatorSpecialization;
        }
    }
}
