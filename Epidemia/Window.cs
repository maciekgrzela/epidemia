using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Epidemia
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            Epidemia.Form = this;
        }

        private void startSimulationBtn_Click(object sender, EventArgs e)
        {
            if(startSimulationBtn.ForeColor != System.Drawing.Color.Red)
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

                var epidemia = new Epidemia();
                Epidemia.Stopped = false;
                epidemia.Start();
            }
        }

        private void stopSimulationBtn_Click(object sender, EventArgs e)
        {
            if(Epidemia.Stopped == false)
            {
                Epidemia.Stopped = true;
                startSimulationBtn.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Zakończono działanie symulatora", "Koniec symulacji", MessageBoxButtons.OK);
            }
        }
    }
}
