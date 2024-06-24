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
    public partial class FormMusic : Form
    {
        public FormMusic()
        {
            InitializeComponent();
            dataGridViewAllSong.DataSource = ListeningManager.GetSpecificListenings<Song>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
