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
        public DiseaseProgress disease;
        public Thread diseaseProgress;
        public List<Human> people;
        public List<Thread> populationThreads = new List<Thread>();

        public Epidemia()
        {
            people = new List<Human>(Epidemia.population);
            for(int i = 0; i < Epidemia.population; i++)
            {
                people.Add(new Human(Guid.NewGuid(), false, HealthCondition.HEALTHY));
            }
            disease = new DiseaseProgress(Epidemia.vaccinesSupply, Epidemia.testsSupply, people);
        }

        public void Start()
        {
            Hospital hospital = Hospital.Instance;
            hospital.orderBeds(Epidemia.bedsAmount, Epidemia.respiratorsAmount);
            hospital.orderTests(Epidemia.testsSupply);
            hospital.orderVaccines(Epidemia.vaccinesSupply);

            Virus virus = Virus.Instance;
            virus.initialize(population / 10, true, population / 50);

            diseaseProgress = new Thread(new ThreadStart(disease.disease));
            diseaseProgress.Start();

            for (int i = 0; i < population; i++)
            {
                var thread = new Thread(new ThreadStart(people[i].live));
                populationThreads.Add(thread);
            }

            foreach (var thread in populationThreads)
            {
                thread.Start();
            }
        }
    }
}
