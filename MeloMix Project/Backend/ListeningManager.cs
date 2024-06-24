using Project_Listening.Backend.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Listening.Backend
{
    public class ListeningManager
    {
        private static BindingList<Listening> listenings= new BindingList<Listening>();
        static ListeningManager()
        {
            listenings = FileUtiles.LoadListeningFromFile();
        }

        public static void saveListening(object sender, FormClosingEventArgs e)
        {
            FileUtiles.SaveListeningToFile(listenings);
        }

        public static BindingList<Listening> GetListenings()
        {
            return listenings;
        }
        public static void AddListening(Listening listening )
        {
            listenings.Add(listening);
        }
        public static void Delete(Listening listening)
        {
            listenings.Remove(listening);
            
        }

        public static BindingList<T> GetSpecificListenings<T>() where T : Listening
        {
             BindingList<T> specificListenings = new BindingList<T>();
             foreach (Listening listening in listenings)
             {
                if (listening is T)
                {
                    specificListenings.Add(listening as T);
                }
             }
             return specificListenings;
        }
    }


}
