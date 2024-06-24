using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Listening.Backend.Model
{
    [Serializable]
    public abstract class Listening
    {
        public string Name { get; set; }
        public string PublicationDate { get; set; }
        public string Time { get; set; }
        public string Language { get; set; }
        protected Listening(string name, string publicationDate, string time, string language)
        {
            Name = name;
            PublicationDate = publicationDate;
            Time = time;
            Language = language;
        }
    }
}
