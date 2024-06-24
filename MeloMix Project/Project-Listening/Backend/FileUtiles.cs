using Project_Listening.Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Project_Listening.Backend
{
    public class FileUtiles
    {
        public static void SaveListeningToFile(BindingList<Listening> listenings)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("listenings.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, listenings);
                binaryFile.Flush();
            }
        }

        public static BindingList<Listening> LoadListeningFromFile()
        {
            BindingList<Listening> listenings;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("listenings.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    listenings = (BindingList<Listening>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch (Exception ex)
            {
                listenings = new BindingList<Listening>();
            }
            return listenings;
        }
    }
}
