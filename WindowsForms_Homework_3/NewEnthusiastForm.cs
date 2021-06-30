using System;
using System.Windows.Forms;

namespace WindowsForms_Homework_3
{
    public partial class NewEnthusiastForm : Form
    {
        CarEnthusiast carEnthusiast = new CarEnthusiast();

        public NewEnthusiastForm(CarEnthusiast enthusiast)
        {
            InitializeComponent();

            carEnthusiast = enthusiast;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                carEnthusiast.CarMark = carMarkTextBox.Text;
                carEnthusiast.ProductionYear = Int32.Parse(productionYearTextBox.Text);
                carEnthusiast.EngineNumber = engineNumberTextBox.Text;
                carEnthusiast.BodyNumber = bodyNumberTextBox.Text;
                carEnthusiast.Color = colorTextBox.Text;
                carEnthusiast.CarLicensePlateNumber = carLicencePlateNumberTextBox.Text;
                carEnthusiast.Owner = ownerTextBox.Text;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
