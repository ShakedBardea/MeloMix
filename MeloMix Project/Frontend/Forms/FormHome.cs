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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        private void buttonAddSong_Click_1(object sender, EventArgs e)
        {
            FormAddSong fSong = new FormAddSong();
            fSong.ShowDialog();
        }

        private void buttonAddPodcast_Click_1(object sender, EventArgs e)
        {
            FormAddPodcast fPodcast = new FormAddPodcast();
            fPodcast.ShowDialog();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void buttonPodcast_Click(object sender, EventArgs e)
        {
            FormPodcasts fPodcast = new FormPodcasts();
            fPodcast.ShowDialog();
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            FormMusic fMusic= new FormMusic();
            fMusic.ShowDialog();
        }
    }
}
