using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsForms_Homework_3
{
    public partial class Form1 : Form
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<CarEnthusiast>));

        List<CarEnthusiast> carEnthusiasts = new List<CarEnthusiast>();
        public string Path { get; set; }

        bool fileModified = false;

        List<string> selectedOwners = new List<string>();


        public Form1()
        {
            InitializeComponent();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = string.Empty;
            openFileDialog.Filter = "All files(*.*) |*.*|xml files(*.xml) |*.xml";

            MessageBox.Show("Create or choose a file", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var ser = new StreamReader(openFileDialog.FileName))
                {
                    carEnthusiasts = (List<CarEnthusiast>)xmlSerializer.Deserialize(ser);
                    UpdateListBox();
                }
            }
        }


        private void newUserButton_Click(object sender, EventArgs e)
        {
            CarEnthusiast enthusiast = new CarEnthusiast();
            NewEnthusiastForm newEnthusiastForm = new NewEnthusiastForm(enthusiast);
            newEnthusiastForm.ShowDialog();
            SaveUserInfo(enthusiast);
            carEnthusiastsListBox.Items.Clear();
            UpdateListBox();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                CarEnthusiast ce = new CarEnthusiast();

                ce.CarMark = carMarkTextBox.Text;
                ce.ProductionYear = Int32.Parse(productionYearTextBox.Text);
                ce.EngineNumber = engineNumberTextBox.Text;
                ce.BodyNumber = bodyNumberTextBox.Text;
                ce.Color = colorTextBox.Text;
                ce.CarLicensePlateNumber = carLicencePlateNumberTextBox.Text;
                ce.Owner = ownerTextBox.Text;

                carEnthusiasts[carEnthusiastsListBox.SelectedIndex] = ce;
                carEnthusiastsListBox.Items.Clear();
                UpdateListBox();

                fileModified = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void carEnthusiastsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carEnthusiastsListBox.SelectedIndex >= 0 && carEnthusiastsListBox.SelectedIndex <= carEnthusiasts.Count)
            {
                carMarkTextBox.Text = (carEnthusiastsListBox.SelectedItem as CarEnthusiast).CarMark;
                productionYearTextBox.Text = (carEnthusiastsListBox.SelectedItem as CarEnthusiast).ProductionYear.ToString();
                engineNumberTextBox.Text = (carEnthusiastsListBox.SelectedItem as CarEnthusiast).EngineNumber;
                bodyNumberTextBox.Text = (carEnthusiastsListBox.SelectedItem as CarEnthusiast).BodyNumber;
                colorTextBox.Text = (carEnthusiastsListBox.SelectedItem as CarEnthusiast).Color;
                carLicencePlateNumberTextBox.Text = (carEnthusiastsListBox.SelectedItem as CarEnthusiast).CarLicensePlateNumber;
                ownerTextBox.Text = (carEnthusiastsListBox.SelectedItem as CarEnthusiast).Owner;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (carEnthusiastsListBox.SelectedIndex >= 0 && carEnthusiastsListBox.SelectedIndex <= carEnthusiasts.Count)
            {
                carEnthusiasts.RemoveAt(carEnthusiastsListBox.SelectedIndex);
                carEnthusiastsListBox.Items.Clear();
                UpdateListBox();
            }

            fileModified = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileModified) UpdateUserFile();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int averageAge = 0;

            foreach (CarEnthusiast c in carEnthusiasts)
            {
                averageAge += c.ProductionYear;
            }

            averageAge /= carEnthusiasts.Count;
            
            
            
            bool first = true;
            string color = "";
            int count = 0;

            if (searchCarMarkTextBox.Text != String.Empty)
            {
                foreach (CarEnthusiast c in carEnthusiasts)
                {
                    if (c.CarMark == searchCarMarkTextBox.Text && !first && c.Color == color && c.ProductionYear > averageAge) 
                    {
                        foundOwnerNames.Items.Add(c.Owner);
                        count++;
                        selectedOwners.Add(c.Owner);
                    }

                    else if (c.CarMark == searchCarMarkTextBox.Text && first && c.ProductionYear > averageAge)
                    {
                        color = c.Color;
                        foundOwnerNames.Items.Add(c.Owner);
                        first = false;
                        count++;
                        selectedOwners.Add(c.Owner);
                    }

                }

                countTextBox.Text = count.ToString();
            }


        }

        private void saveResultsButton_Click(object sender, EventArgs e)
        {
            SaveProgramResults();
        }


        private void SaveUserInfo(CarEnthusiast enthusiast)
        {
            carEnthusiasts.Add(enthusiast);
            UpdateUserFile();
        }

        private void UpdateUserFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFileDialog.FileName))
                {
                    xmlSerializer.Serialize(sw, carEnthusiasts);
                }
            }
        }

        private void UpdateListBox()
        {
            foreach (CarEnthusiast c in carEnthusiasts)
            {
                carEnthusiastsListBox.Items.Add(c);
            }
        }

        private void SaveProgramResults()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);

                foreach (string item in selectedOwners)
                {
                    sw.Write($"{item}\n");
                }

                sw.Write($"\n{countTextBox.Text}");
                sw.Close();
            }
        }


    }
}
