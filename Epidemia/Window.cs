using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Epidemia
{
    public partial class Window : Form
    {

        public List<Button> bedButtons = new List<Button>();
        public List<Button> humanButtons = new List<Button>();
        public List<Button> vaccineButtons = new List<Button>();
        public List<Button> testButtons = new List<Button>();


        public Window()
        {
            InitializeComponent();
        }

        private void startSimulationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Epidemia.population = Convert.ToInt32(populationtb.Text);
                Epidemia.bedsAmount = Convert.ToInt32(bedsamounttb.Text);
                Epidemia.respiratorsAmount = Convert.ToInt32(respiratoramounttb.Text);
                Epidemia.testsSupply = Convert.ToInt32(testsupplytb.Text);
                Epidemia.vaccinesSupply = Convert.ToInt32(vaccinessupplytb.Text);
                Epidemia.canVirusMutate = canVirusMutatechb.Checked;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Jedna z wartości wprowadzonych do pól tekstowych jest niepoprawna", "Niepoprawne wartości", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            initiateButtons();
            var epidemia = new Epidemia();
            epidemia.Start();
        }

        private void initiateButtons()
        {
            for (int i = 0; i < Epidemia.bedsAmount; i++)
            {
                Button tempButton = new Button();
                tempButton.Text = "";
                tempButton.Image = Properties.Resources._041_hospital_bed1;
                tempButton.Width = 50;
                tempButton.Height = 50;
                tempButton.FlatStyle = FlatStyle.Flat;
                tempButton.FlatAppearance.BorderSize = 0;
                tempButton.Dock = DockStyle.Fill;
                bedButtons.Add(tempButton);
                this.bedsTable.Controls.Add(tempButton);
            }

            for (int i = 0; i < Epidemia.respiratorsAmount; i++)
            {
                Button tempButton = new Button();
                tempButton.Text = "";
                tempButton.Image = Properties.Resources._006_lungs;
                tempButton.Width = 50;
                tempButton.Height = 50;
                tempButton.FlatStyle = FlatStyle.Flat;
                tempButton.FlatAppearance.BorderSize = 0;
                tempButton.Dock = DockStyle.Fill;
                bedButtons.Add(tempButton);
                this.bedsTable.Controls.Add(tempButton);
            }


            for (int i = 0; i < Epidemia.vaccinesSupply; i++)
            {
                Button tempButton = new Button();
                tempButton.Text = "";
                tempButton.Image = Properties.Resources._028_vaccine;
                tempButton.Width = 50;
                tempButton.Height = 50;
                tempButton.FlatStyle = FlatStyle.Flat;
                tempButton.FlatAppearance.BorderSize = 0;
                tempButton.Dock = DockStyle.Fill;
                vaccineButtons.Add(tempButton);
                this.vaccinesTable.Controls.Add(tempButton);
            }

            for (int i = 0; i < Epidemia.testsSupply; i++)
            {
                Button tempButton = new Button();
                tempButton.Text = "";
                tempButton.Image = Properties.Resources._033_vaccine;
                tempButton.Width = 50;
                tempButton.Height = 50;
                tempButton.FlatStyle = FlatStyle.Flat;
                tempButton.FlatAppearance.BorderSize = 0;
                tempButton.Dock = DockStyle.Fill;
                testButtons.Add(tempButton);
                this.labTable.Controls.Add(tempButton);
            }

            for (int i = 0; i < Epidemia.population; i++)
            {
                Button tempButton = new Button();
                tempButton.Text = "";
                tempButton.Image = Properties.Resources._013_stayhome;
                tempButton.Width = 50;
                tempButton.Height = 50;
                tempButton.FlatStyle = FlatStyle.Flat;
                tempButton.FlatAppearance.BorderSize = 0;
                tempButton.Dock = DockStyle.Fill;
                humanButtons.Add(tempButton);
                this.populationTable.Controls.Add(tempButton);
            }
        }
    }
}
