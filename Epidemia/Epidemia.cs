using Epidemia.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemia
{
    public partial class Epidemia : Form
    {

        private int population { get; set; }
        private int bedsAmount { get; set; }
        private int respiratorsAmount { get; set; }
        private int testsSupply { get; set; }
        private int vaccinesSupply { get; set; }
        private bool canVirusMutate { get; set; }

        public Epidemia()
        {
            InitializeComponent();
        }

        private void startSimulationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.population = Convert.ToInt32(populationtb.Text);
                this.bedsAmount = Convert.ToInt32(bedsamounttb.Text);
                this.respiratorsAmount = Convert.ToInt32(respiratoramounttb.Text);
                this.testsSupply = Convert.ToInt32(bedsamounttb.Text);
                this.vaccinesSupply = Convert.ToInt32(vaccinessupplytb.Text);
                this.canVirusMutate = canVirusMutatechb.Checked;
            }catch(Exception exception)
            {
                MessageBox.Show("Jedna z wartości wprowadzonych do pól tekstowych jest niepoprawna", "Niepoprawne wartości", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Hospital hospital = Hospital.Instance;
            hospital.orderBeds(this.bedsAmount, this.respiratorsAmount);
            hospital.orderTests(this.testsSupply);
            hospital.orderVaccines(this.vaccinesSupply);

            DiseaseProgress progress = new DiseaseProgress();
            var diseaseProgressThread = new Thread(new ThreadStart(progress.disease));
            diseaseProgressThread.Start();

            var population = createPopulation();
            var peopleThreads = new List<Thread>();
            foreach (var human in population)
            {
                var humanThread = new Thread(new ThreadStart(human.live));
                peopleThreads.Add(humanThread);
                humanThread.Start();
            }

            foreach (var thread in peopleThreads)
            {
                thread.Join();
            }

            diseaseProgressThread.Join();

            if(this.population == 0)
            {
                MessageBox.Show("Cała populacja została zabita przez wirusa :(", "Smutno nam", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private List<Human> createPopulation()
        {
            var population = new List<Human>(this.population);
            Random rnd = new Random();
            var initiallyIll = rnd.Next((this.population / 2) + (this.population / 4), this.population);
            for(int i = 0; i < this.population; i++)
            {
                if(i < initiallyIll)
                {
                    population.Add(new Human(Guid.NewGuid(), true, HealthCondition.INFECTED));
                }else
                {
                    population.Add(new Human(Guid.NewGuid(), false, HealthCondition.HEALTHY));
                }
            }
            return population;
        }
    }

    public class DiseaseProgress
    {
        private static readonly object accessLock = new object();
        public void disease()
        {
            // infekuje osobników w populacji
            // pogarsza stan zdrowia osobników
            // uśmierca określonego osobnika
            // dostarcza szczepionki
            // dostarcza testy
            // usypia na określony czas
        }
    }
}
