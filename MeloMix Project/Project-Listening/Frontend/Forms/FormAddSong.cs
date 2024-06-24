using Project_Listening.Backend.Enums;
using Project_Listening.Frontend.UserControls;
using Project_Listening.Backend;
using Project_Listening.Frontend;
using Project_Listening.Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_Listening.Frontend.Forms
{

    public partial class FormAddSong : Form
    {
        private BindingList<Pop> pops = new BindingList<Pop>();
        private BindingList<Rap> raps = new BindingList<Rap>();

        public FormAddSong()
        {
            InitializeComponent();
            comboGener.DataSource = Enum.GetValues(typeof(eGeners));
            this.FormClosing += new FormClosingEventHandler(ListeningManager.saveListening);
            panelAddSong.Controls.Clear();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboGener_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAddSong.Controls.Clear();
            if (comboGener.SelectedItem.ToString() == "Pop")
            {
                BindingList<Pop> pops = ListeningManager.GetSpecificListenings<Pop>();
                dataGridViewSong.DataSource = ListeningManager.GetSpecificListenings<Song>();
                dataGridViewSong.DataSource = pops;
                panelAddSong.Controls.Add(new UserControlAddPop());
            }
            else if (comboGener.SelectedItem.ToString() == "Rap")
            {
                BindingList<Rap> raps = ListeningManager.GetSpecificListenings<Rap>();
                dataGridViewSong.DataSource = ListeningManager.GetSpecificListenings<Song>();
                dataGridViewSong.DataSource = raps;
                panelAddSong.Controls.Add(new UserControlAddRap());
            }
        }

        private void buttonClearSong_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            panelAddSong.Controls.Clear();
            comboGener.ResetText();
            textBoxName.Clear();
            dateTimePickerSong.Value = DateTime.UtcNow;
            maskedTextBoxSong.Clear();
            textBoxLanguage.Clear();
            textBoxArtistName.Clear();
            checkBoxHasClip.Checked = false;
            dataGridViewSong.DataSource = ListeningManager.GetSpecificListenings<Song>();
        }

        private void buttonAddSong_Click_1(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                MessageBox.Show("Form validation successful!");
                string gener = comboGener.Text;
                string name = textBoxName.Text;
                string publicationDate = dateTimePickerSong.Value.ToString();
                string time = maskedTextBoxSong.Text;
                string language = textBoxLanguage.Text;
                string nameArtist = textBoxArtistName.Text;
                bool hasClip = checkBoxHasClip.Checked;
                if (comboGener.SelectedItem.ToString() == "Pop")
                {
                    TextBox textBoxGeographicAffiliation = panelAddSong.Controls.Find("textBoxGeographicAffiliation", true).First() as TextBox;
                    string geographic = textBoxGeographicAffiliation.Text;
                    Pop pop = new Pop(name, publicationDate, time, language, gener, nameArtist, hasClip, geographic);
                    ListeningManager.AddListening(pop);
                    dataGridViewSong.DataSource = ListeningManager.GetSpecificListenings<Pop>();
                    pops.Add(pop);
                }
                else if (comboGener.SelectedItem.ToString() == "Rap")
                {
                    CheckBox checkBoxHasMelody = panelAddSong.Controls.Find("checkBoxHasMelody", true).First() as CheckBox;
                    bool hasMelody = checkBoxHasMelody.Checked;
                    Rap rap = new Rap(name, publicationDate, time, language, gener, nameArtist, hasClip, hasMelody);
                    ListeningManager.AddListening(rap);
                    dataGridViewSong.DataSource = ListeningManager.GetSpecificListenings<Pop>();
                    raps.Add(rap);
                }
                ClearForm();
            }

        }
        private bool IsValidForm()
        {
            // Type check
            if (comboGener.SelectedItem.ToString() == "None")
            {
                MessageBox.Show("Please select the Gener of the Song", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Name check
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please write the Name of the Song", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Timer check
            if (!maskedTextBoxSong.MaskCompleted)
            {
                MessageBox.Show("Please write your Song Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Language check
            if (textBoxLanguage.Text == "")
            {
                MessageBox.Show("Please write the Language of the Song", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Regex.IsMatch(textBoxLanguage.Text, @"^[a-zA-Z  ]+$"))
            {
                MessageBox.Show("Language contains only letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Artist name check
            if (textBoxArtistName.Text == "")
            {
                MessageBox.Show("Please write the Artist Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Pop Song check
            if (comboGener.SelectedItem.ToString() == "Pop")
            {
                TextBox GeographicAffiliationTextBox = panelAddSong.Controls.Find("textBoxGeographicAffiliation", true).First() as TextBox;
                if (GeographicAffiliationTextBox.Text == "")
                {
                    MessageBox.Show("Geographic Afflication is not filled, please write", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (!Regex.IsMatch(GeographicAffiliationTextBox.Text, @"^[a-zA-Z  ]+$"))
                {
                    MessageBox.Show("Geographic Afflication contains only letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            return true;

        }

        private void userControlPop1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewSong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAddSong_Load(object sender, EventArgs e)
        {

        }

        private void userControlAddPop1_Load(object sender, EventArgs e)
        {

        }

        private void buttomDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure???", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (dataGridViewSong.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridViewSong.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewSong.Rows[selectedRowIndex];
                    if (!isValidRow(selectedRow))
                    {
                        dataGridViewSong.Rows.RemoveAt(selectedRowIndex);
                        MessageBox.Show("This row is not a valid row.");
                    }
                    else
                    {
                        string gener = selectedRow.Cells["Gener"].Value.ToString();
                        string songName = selectedRow.Cells["Name"].Value.ToString();
                        if (gener == "Pop")
                        { 
                            BindingList<Pop> pops = ListeningManager.GetSpecificListenings<Pop>();
                            foreach (Pop pop in pops)
                            {
                                if (pop.Name == songName)
                                {
                                    ListeningManager.Delete(pop);
                                    dataGridViewSong.Rows.RemoveAt(selectedRowIndex);
                                    break;
                                }
                            }
                        }
                        else if (gener == "Rap")
                        {
                            BindingList<Rap> raps = ListeningManager.GetSpecificListenings<Rap>();
                            foreach (Rap rap in raps)
                            {
                                if (rap.Name == songName)
                                {
                                    ListeningManager.Delete(rap);
                                    dataGridViewSong.Rows.RemoveAt(selectedRowIndex);
                                    break;
                                }
                            }
                        }
                        MessageBox.Show("Delete Completed!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select row to delete!");
                }
                ClearForm();
            }
        }
        private bool isValidRow(DataGridViewRow row)
        {
            if (row.Cells["Gener"].Value == null)
            {
                return false;
            }
            return true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string gener = comboGener.Text;
            string artist = textBoxArtistName.Text;
            bool hasClip = checkBoxHasClip.Checked;
            string name = textBoxName.Text;
            DateTime publicationDate = dateTimePickerSong.Value;
            string time = maskedTextBoxSong.Text;
            string language = textBoxLanguage.Text;
            if (gener == "Pop")
            {
                TextBox GeographicAffiliationTextBox = panelAddSong.Controls.Find("textBoxGeographicAffiliation", true).First() as TextBox;
                string geographicA = GeographicAffiliationTextBox.Text;
            }
            else if (gener == "Rap")
            {
                CheckBox checkBoxHasMelody = panelAddSong.Controls.Find("checkBoxHasMelody", true).First() as CheckBox;
                bool hasMelody = checkBoxHasMelody.Checked;
            }
            int selectedRowIndex = dataGridViewSong.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewSong.Rows[selectedRowIndex];
            selectedRow.Cells["Gener"].Value = gener;
            selectedRow.Cells["Artist"].Value = artist;
            selectedRow.Cells["Clip"].Value = hasClip;
            selectedRow.Cells["Name"].Value = name;
            selectedRow.Cells["PublicationDate"].Value = publicationDate;
            selectedRow.Cells["Time"].Value = time;
            selectedRow.Cells["Language"].Value = language;
            if (gener == "Pop")
            {
                TextBox GeographicAffiliationTextBox = panelAddSong.Controls.Find("textBoxGeographicAffiliation", true).First() as TextBox;
                string geographicA = GeographicAffiliationTextBox.Text;
                selectedRow.Cells["GeographicAffiliation"].Value = geographicA;
            }
            else if (gener == "Rap")
            {
                CheckBox checkBoxHasMelody = panelAddSong.Controls.Find("checkBoxHasMelody", true).First() as CheckBox;
                bool hasMelody = checkBoxHasMelody.Checked;
                selectedRow.Cells["WithMelody"].Value = hasMelody;
            }
        }
        private void dataGridViewSong_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewSong.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewSong.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewSong.Rows[selectedRowIndex];
                comboGener.Text = selectedRow.Cells["Gener"].Value.ToString();
                if (comboGener.Text == "Pop")
                {
                    textBoxArtistName.Text = selectedRow.Cells["Artist"].Value.ToString();
                    checkBoxHasClip.Checked = (bool)selectedRow.Cells["Clip"].Value;
                    textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                    dateTimePickerSong.Value = DateTime.Parse(selectedRow.Cells["PublicationDate"].Value.ToString());
                    maskedTextBoxSong.Text = selectedRow.Cells["Time"].Value.ToString();
                    textBoxLanguage.Text = selectedRow.Cells["Language"].Value.ToString();
                    TextBox textBoxGeographicAffiliation = panelAddSong.Controls.Find("textBoxGeographicAffiliation", true).First() as TextBox;
                    textBoxGeographicAffiliation.Text= selectedRow.Cells["GeographicAffiliation"].Value.ToString();
                   
                }
                else if (comboGener.Text == "Rap")
                {
                    if (selectedRow.Cells["Artist"].Value != null)
                    {
                        textBoxArtistName.Text = selectedRow.Cells["Artist"].Value.ToString();
                    }
                    //textBoxArtistName.Text = selectedRow.Cells["Artist"].Value.ToString();
                    checkBoxHasClip.Checked = (bool)selectedRow.Cells["Clip"].Value;
                    textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                    dateTimePickerSong.Value = DateTime.Parse(selectedRow.Cells["PublicationDate"].Value.ToString());
                    maskedTextBoxSong.Text = selectedRow.Cells["Time"].Value.ToString();
                    textBoxLanguage.Text = selectedRow.Cells["Language"].Value.ToString();
                    CheckBox checkBoxHasMelody = panelAddSong.Controls.Find("checkBoxHasMelody", true).First() as CheckBox;
                    checkBoxHasMelody.Checked = (bool)selectedRow.Cells["WithMelody"].Value;
                }
            }
        }
    }
}

