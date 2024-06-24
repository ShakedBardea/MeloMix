using Project_Listening.Backend.Enums;
using Project_Listening.Backend.Model;
using Project_Listening.Frontend.UserControls;
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
using Project_Listening.Backend;

namespace Project_Listening.Frontend.Forms
{
    public partial class FormAddPodcast : Form
    {
        private BindingList<Comedy> comedys=new BindingList<Comedy>();
        private BindingList<Educational> educationals= new BindingList<Educational>();

        public FormAddPodcast()
        {
            InitializeComponent();
            comboType.Items.Add("Comedy");
            comboType.Items.Add("Educational");
            comboTargetGroup.DataSource = Enum.GetValues(typeof(eTarget));
            this.FormClosing += new FormClosingEventHandler(ListeningManager.saveListening);
            panelAddPodcast.Controls.Clear();
        }
        private void comboType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            panelAddPodcast.Controls.Clear();
            if (comboType.SelectedItem.ToString() == "Educational")
            {
                BindingList<Educational> educational = ListeningManager.GetSpecificListenings<Educational>();
                dataGridViewPodcast.DataSource = ListeningManager.GetSpecificListenings<Podcast>();
                dataGridViewPodcast.DataSource = educational;
                panelAddPodcast.Controls.Add(new UserControlAddEducational()); 
            }
            else if (comboType.SelectedItem.ToString() == "Comedy")
            {
                BindingList<Comedy> comedys = ListeningManager.GetSpecificListenings<Comedy>();
                dataGridViewPodcast.DataSource = ListeningManager.GetSpecificListenings<Podcast>();
                dataGridViewPodcast.DataSource = comedys;
                panelAddPodcast.Controls.Add(new UserControlAddComedy());
            }

        }

        private void buttonAddPodcast_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                MessageBox.Show("Form validation successful!");
                string type = comboType.Text;
                string name = textBoxName.Text;
                string publicationDate = dateTimePickerPodcast.Value.ToString();
                string time = maskedTextBoxTime.Text;
                string language = textBoxLanguage.Text;
                string nameCreator = textBoxCreatorName.Text;
                string target = comboTargetGroup.Text;
                if (comboType.SelectedItem.ToString() == "Educational")
                {
                    TextBox topicTextBox = panelAddPodcast.Controls.Find("textBoxTopic", true).First() as TextBox;
                    CheckBox checkBoxIsCreatorSpecialization = panelAddPodcast.Controls.Find("checkBoxIsCreatorSpecialization", true).First() as CheckBox;
                    string topic = topicTextBox.Text;
                    bool hasSpecialization = checkBoxIsCreatorSpecialization.Checked;
                    Educational educational = new Educational(name, publicationDate, time, language, type, nameCreator, target, topic, hasSpecialization);
                    ListeningManager.AddListening(educational);
                    dataGridViewPodcast.DataSource = ListeningManager.GetSpecificListenings<Educational>();
                    educationals.Add(educational);
                }
                else if(comboType.SelectedItem.ToString() == "Comedy")
                {
                    CheckBox checkBoxIsComedian = panelAddPodcast.Controls.Find("checkBoxIsComedian", true).First() as CheckBox;
                    bool isComedian = checkBoxIsComedian.Checked;
                    Comedy comedy = new Comedy(name, publicationDate, time, language, type, nameCreator, target,isComedian);
                    ListeningManager.AddListening(comedy);
                    dataGridViewPodcast.DataSource = ListeningManager.GetSpecificListenings<Comedy>();
                    comedys.Add(comedy);
                } 
                
                ClearForm();   
            }

        }

        private void buttonClearPodcast_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            panelAddPodcast.Controls.Clear();
            comboType.ResetText();
            textBoxName.Clear();
            dateTimePickerPodcast.Value = DateTime.UtcNow;
            maskedTextBoxTime.Clear();
            textBoxLanguage.Clear();
            textBoxCreatorName.Clear();
            comboTargetGroup.Text = "None";
            dataGridViewPodcast.DataSource = ListeningManager.GetSpecificListenings<Podcast>();
        }
        private bool IsValidForm()
        {
            // Type check
            if (comboType.SelectedItem== null)
            {
                MessageBox.Show("Please select the Type of the Podcast", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Name check
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please write the Name of the Podcast", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Timer check
            if (!maskedTextBoxTime.MaskCompleted)
            {
                MessageBox.Show("Please write your Podcast Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Language check
            if (textBoxLanguage.Text =="")
            {
                MessageBox.Show("Please write the Language of the Podcast", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(!Regex.IsMatch(textBoxLanguage.Text, @"^[a-zA-Z  ]+$"))
            {
                MessageBox.Show("Language contains only letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Creator name check
            if (textBoxCreatorName.Text == "")
            {
                MessageBox.Show("Please write the Creator Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Regex.IsMatch(textBoxCreatorName.Text, @"^[a-zA-Z  ]+$"))
            {
                MessageBox.Show("Language contains only letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Target group check
            if (comboTargetGroup.SelectedItem.ToString()=="None")
            {
                MessageBox.Show("Please select the Target Group from the comboBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Educational Podcast check
            if(comboType.SelectedItem.ToString() == "Educational")
            {
                TextBox topicTextBox = panelAddPodcast.Controls.Find("textBoxTopic", true).First() as TextBox;
                if(topicTextBox.Text == "")
                {
                    MessageBox.Show("Topic Of the podcast is not filled, please write", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if(!Regex.IsMatch(topicTextBox.Text, @"^[a-zA-Z  ]+$"))
                {
                    MessageBox.Show("Topic Of the podcast contains only letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                    
            }
         return true;
        }

        private void dataGridViewPodcast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAddPodcast_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewPodcast_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUpdatePod_Click(object sender, EventArgs e)
        {
            string type = comboType.Text;
            string name = textBoxName.Text;
            DateTime publicationDate = dateTimePickerPodcast.Value;
            string time = maskedTextBoxTime.Text;
            string language = textBoxLanguage.Text;
            string creator = textBoxCreatorName.Text;
            string target = comboTargetGroup.Text;

            if (type == "Educational")
            {
                TextBox topicTextBox = panelAddPodcast.Controls.Find("textBoxTopic", true).First() as TextBox;
                CheckBox checkBoxIsCreatorSpecialization = panelAddPodcast.Controls.Find("checkBoxIsCreatorSpecialization", true).First() as CheckBox;
                string topic = topicTextBox.Text;
                bool hasSpecialization = checkBoxIsCreatorSpecialization.Checked;
            }
            else if (type == "Comedy")
            {
                CheckBox checkBoxIsComedian = panelAddPodcast.Controls.Find("checkBoxIsComedian", true).First() as CheckBox;
                bool isComedian = checkBoxIsComedian.Checked;
            }
            int selectedRowIndex = dataGridViewPodcast.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPodcast.Rows[selectedRowIndex];
            selectedRow.Cells["Type"].Value = type;
            selectedRow.Cells["Creator"].Value = creator;
            selectedRow.Cells["TargetGroup"].Value = target;
            selectedRow.Cells["Name"].Value = name;
            selectedRow.Cells["PublicationDate"].Value = publicationDate;
            selectedRow.Cells["Time"].Value = time;
            selectedRow.Cells["Language"].Value = language;
            if (type == "Educational")
            {
                TextBox topicTextBox = panelAddPodcast.Controls.Find("textBoxTopic", true).First() as TextBox;
                CheckBox checkBoxIsCreatorSpecialization = panelAddPodcast.Controls.Find("checkBoxIsCreatorSpecialization", true).First() as CheckBox;
                string topic = topicTextBox.Text;
                bool hasSpecialization = checkBoxIsCreatorSpecialization.Checked;
                selectedRow.Cells["TargetGroup"].Value=topic;
                selectedRow.Cells["IsCreatorSpecialization"].Value = hasSpecialization;
            }
            else if (type == "Comedy")
            {
                CheckBox checkBoxIsComedian = panelAddPodcast.Controls.Find("checkBoxIsComedian", true).First() as CheckBox;
                bool isComedian = checkBoxIsComedian.Checked;
                selectedRow.Cells["IsComedian"].Value = isComedian;
            }
            
        }

        private void dataGridViewPodcast_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewPodcast.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewPodcast.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewPodcast.Rows[selectedRowIndex];
                comboType.Text = selectedRow.Cells["Type"].Value.ToString();
                if (comboType.Text == "Educational")
                {
                    textBoxCreatorName.Text = selectedRow.Cells["Creator"].Value.ToString();
                    comboTargetGroup.Text = selectedRow.Cells["TargetGroup"].Value.ToString();
                    textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                    dateTimePickerPodcast.Value = DateTime.Parse(selectedRow.Cells["PublicationDate"].Value.ToString());
                    maskedTextBoxTime.Text = selectedRow.Cells["Time"].Value.ToString();
                    textBoxLanguage.Text = selectedRow.Cells["Language"].Value.ToString();
                    TextBox textBoxTopic = panelAddPodcast.Controls.Find("textBoxTopic", true).First() as TextBox;
                    textBoxTopic.Text = selectedRow.Cells["Topic"].Value.ToString();
                    CheckBox checkBoxIsCreatorSpecialization = panelAddPodcast.Controls.Find("checkBoxIsCreatorSpecialization", true).First() as CheckBox;
                    checkBoxIsCreatorSpecialization.Checked=(bool)selectedRow.Cells["IsCreatorSpecialization"].Value;


                }
                else if (comboType.Text == "Comedy")
                {
                    textBoxCreatorName.Text = selectedRow.Cells["Creator"].Value.ToString();
                    comboTargetGroup.Text = selectedRow.Cells["TargetGroup"].Value.ToString();
                    textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                    dateTimePickerPodcast.Value = DateTime.Parse(selectedRow.Cells["PublicationDate"].Value.ToString());
                    maskedTextBoxTime.Text = selectedRow.Cells["Time"].Value.ToString();
                    textBoxLanguage.Text = selectedRow.Cells["Language"].Value.ToString();
                    CheckBox checkBoxIsComedian = panelAddPodcast.Controls.Find("checkBoxIsComedian", true).First() as CheckBox;
                    checkBoxIsComedian.Checked = (bool)selectedRow.Cells["IsComedian"].Value;
                }
            }
        }

        private void buttomDeletePod_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("are you sure???", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (dataGridViewPodcast.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridViewPodcast.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewPodcast.Rows[selectedRowIndex];
                    if (!isValidRow(selectedRow))
                    {
                        dataGridViewPodcast.Rows.RemoveAt(selectedRowIndex);
                        MessageBox.Show("This row is not a valid row.");
                    }
                    else
                    {
                        string type = selectedRow.Cells["Type"].Value.ToString();
                        string podcastName = selectedRow.Cells["Name"].Value.ToString();
                        if (type == "Educational")
                        {
                            BindingList<Educational> educationals = ListeningManager.GetSpecificListenings<Educational>();
                            foreach (Educational educational in educationals)
                            {
                                if (educational.Name == podcastName)
                                {
                                    ListeningManager.Delete(educational);
                                    dataGridViewPodcast.Rows.RemoveAt(selectedRowIndex);
                                    break;
                                }
                            }
                        }
                        else if (type == "Comedy")
                        {
                            BindingList<Comedy> comedys = ListeningManager.GetSpecificListenings<Comedy>();
                            foreach (Comedy comedy in comedys)
                            {
                                if (comedy.Name == podcastName)
                                {
                                    ListeningManager.Delete(comedy);
                                    dataGridViewPodcast.Rows.RemoveAt(selectedRowIndex);
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
            if (row.Cells["Type"].Value == null)
            {
                return false;
            }
            return true;
        }
    }
}
