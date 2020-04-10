using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epidemia.Classes
{
    class Human
    {
        public Human(Guid identifier, bool hasVirus, HealthCondition healthCondition)
        {
            this.identifier = identifier;
            this.hasVirus = hasVirus;
            this.healthCondition = healthCondition;
        }
        public Guid identifier { get; set; }
        public bool hasVirus { get; set; }
        public HealthCondition healthCondition { get; set; }
        public bool tested { get; set; }

        public void makeTest(Test test) { }
        private Mutex allowToFindBed;

        public void live()
        {
            bool isAlive = true;
            while (isAlive)
            {
                switch (this.healthCondition)
                {
                    case HealthCondition.HEALTHY:
                        // może zrobić test
                        // jeżeli jego test okaże się pozytywny, może wziąć szczepionkę
                        // może się stać zainfekowany (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.INFECTED:
                        // może zainfekować innych (za sprawą wątku postępu choroby)
                        // może stać się chory (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.ILL:
                        Hospital hospital = Hospital.Instance;
                        List<Bed> beds = hospital.Beds;
                        if (allowToFindBed.WaitOne())
                        {
                            Console.WriteLine("Pacjent {0} szuka łóżka", this.identifier);
                            foreach (var bed in beds)
                            {
                                if (!bed.isOccupied)
                                {
                                    bed.isOccupied = true;
                                    allowToFindBed.ReleaseMutex();
                                    if (bed.mutex.WaitOne())
                                    {
                                        Console.WriteLine("Pacjent {0} zajmuje łóżko {1}", this.identifier, bed.identifier);
                                        Thread.Sleep(1000);
                                        this.healthCondition = HealthCondition.HEALTHY;
                                        this.hasVirus = false;
                                        bed.mutex.ReleaseMutex();
                                        break;
                                    }
                                }
                            }
                        }
                        // infekuje innych (za sprawą wątku postępu choroby)
                        // może iść do szpitala
                        // może stać się terminalnie chory (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.TERMINALLY_ILL:
                        // infekuje innych
                        // może iść do szpitala
                        // może umrzeć (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.DEAD:
                        isAlive = false;
                        break;
                }
            }
        }
    }
}
