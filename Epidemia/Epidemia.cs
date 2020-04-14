using Epidemia.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epidemia
{
    class Epidemia
    {
        public static int population { get; set; }
        public static int bedsAmount { get; set; }
        public static int respiratorsAmount { get; set; }
        public static int testsSupply { get; set; }
        public static int vaccinesSupply { get; set; }
        public static bool canVirusMutate { get; set; }

        public Thread diseaseProgress;
        public List<Thread> populationThreads = new List<Thread>();

        public Epidemia()
        {
        }

        public void Start()
        {
            Hospital hospital = Hospital.Instance;
            hospital.orderBeds(Epidemia.bedsAmount, Epidemia.respiratorsAmount);
            hospital.orderTests(Epidemia.testsSupply);
            hospital.orderVaccines(Epidemia.vaccinesSupply);

            Virus virus = Virus.Instance;
            virus.initialize(population / 10, true, population / 10000);

            diseaseProgress = new Thread(new ThreadStart(new DiseaseProgress(Epidemia.vaccinesSupply, Epidemia.testsSupply).disease));
            diseaseProgress.Start();

            for (int i = 0; i < population; i++)
            {
                var thread = new Thread(new ThreadStart(new Human(Guid.NewGuid(), false, HealthCondition.HEALTHY).live));
                populationThreads.Add(thread);
            }

            foreach (var thread in populationThreads)
            {
                thread.Start();
            }
        }
    }
}
