using Project_Listening.Backend;
using Project_Listening.Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Listening.Frontend.Forms
{
    public partial class FormPodcasts : Form
    {
        public FormPodcasts()
        {
            InitializeComponent();
            dataGridViewAllPodcast.DataSource = ListeningManager.GetSpecificListenings<Podcast>();
        }
    }
}
