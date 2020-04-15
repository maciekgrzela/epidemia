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
            this.tested = false;
            this.inoculated = false;
        }
        public Guid identifier { get; set; }
        public bool hasVirus { get; set; }
        public HealthCondition healthCondition { get; set; }
        public bool tested { get; set; }
        public bool inoculated { get; set; }

        private static readonly object allowToFindBed = new object();
        private static readonly object allowToMakeTest = new object();
        private static readonly object allowToInoculate = new object();
        private static readonly object changeHumanStatus = new object();
        private static readonly object varLock = new object();

        private int infectionTime = 10;
        private int illnessTime = 5;
        private int terminalIllnessTime = 3;

        public int InfectionTime
        {
            get
            {
                int returned;
                lock (varLock)
                {
                    returned = infectionTime;
                }
                return returned;
            }
            set
            {
                lock (varLock)
                {
                    infectionTime = value;
                }
            }
        }

        public int IllnessTime
        {
            get
            {
                int returned;
                lock (varLock)
                {
                    returned = illnessTime;
                }
                return returned;
            }
            set
            {
                lock (varLock)
                {
                    illnessTime = value;
                }
            }
        }

        public int TerminalIllnessTime
        {
            get
            {
                int returned;
                lock (varLock)
                {
                    returned = terminalIllnessTime;
                }
                return returned;
            }
            set
            {
                lock (varLock)
                {
                    terminalIllnessTime = value;
                }
            }
        }



        public void setHealthStatus(bool hasVirus, HealthCondition healthCondition, bool tested, bool inoculated)
        {
            lock (changeHumanStatus)
            {
                this.hasVirus = hasVirus;
                this.healthCondition = healthCondition;
                this.tested = tested;
                this.inoculated = inoculated;
            }
        }

        public void makeTest() 
        {
            Hospital hospital = Hospital.Instance;
            List<Test> tests = hospital.Tests;
            if(tests.Count > 0)
            {
                double positive = StaticRandom.Rand();
                tests[0].isPositive = positive < 0.3f ? true : false;
                Console.WriteLine("Pacjent {0} wykonał test. Wynik: {1}", this.identifier, tests[0].isPositive);
                if (tests[0].isPositive == true)
                {
                    this.setHealthStatus(true, HealthCondition.INFECTED, true, false);
                }else
                {
                    this.setHealthStatus(false, HealthCondition.HEALTHY, true, false);
                }
                tests.RemoveAt(0);
            }
        }

        public void inoculate()
        {
            Hospital hospital = Hospital.Instance;
            List<Vaccine> vaccines = hospital.Vaccines;
            if(vaccines.Count > 0)
            {
                if (vaccines[0].isEffective)
                {
                    this.setHealthStatus(false, HealthCondition.HEALTHY, true, true);
                    Console.WriteLine("Pacjent {0} się zaszczepił", this.identifier);
                }
                vaccines.RemoveAt(0);
            }
        }
        

        public void live()
        {
            bool isAlive = true;
            while (isAlive)
            {
                switch (this.healthCondition)
                {
                    case HealthCondition.HEALTHY:
                        if (this.tested == true)
                        {
                            if (this.inoculated == false)
                            {
                                lock (allowToInoculate)
                                {
                                    this.inoculate();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Pacjent {0} jest zaszczepiony", this.identifier);
                            }
                        }
                        else
                        {
                            lock (allowToMakeTest)
                            {
                                this.makeTest();
                            }
                        }
                        // może zrobić test - checked
                        // jeżeli jego test okaże się pozytywny, może wziąć szczepionkę - checked
                        // może się stać zainfekowany (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.INFECTED:
                        this.InfectionTime--;
                        Console.WriteLine("Pacjent {0} jest zainfekowany", this.identifier);
                        // może zainfekować innych (za sprawą wątku postępu choroby)
                        // może stać się chory (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.ILL:
                        this.IllnessTime--;
                        Guid bedIdentifier = Guid.Empty;
                        lock (allowToFindBed)
                        {
                            Hospital hospital2 = Hospital.Instance;
                            Console.WriteLine("Pacjent {0} szuka łóżka", this.identifier);
                            foreach(var bed in hospital2.Beds)
                            {
                                if (!bed.isOccupied)
                                {
                                    bed.isOccupied = true;
                                    bedIdentifier = bed.identifier;
                                }
                            }
                        }

                        if(bedIdentifier != Guid.Empty)
                        {
                            Console.WriteLine("Pacjent {0} zajmuje łóżko {1}", this.identifier, bedIdentifier);
                            Thread.Sleep(1000);
                            this.healthCondition = HealthCondition.HEALTHY;
                            this.hasVirus = false;
                            Hospital.Instance.Beds.Find(x => x.identifier == bedIdentifier).isOccupied = false;
                        }
                        // infekuje innych (za sprawą wątku postępu choroby)
                        // może iść do szpitala - checked
                        // może stać się terminalnie chory (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.TERMINALLY_ILL:
                        this.TerminalIllnessTime--;
                        Console.WriteLine("Pacjent {0} jest terminalnie chory", this.identifier);
                        Guid bedIdentifier2 = Guid.Empty;
                        lock (allowToFindBed)
                        {
                            Hospital hospital2 = Hospital.Instance;
                            Console.WriteLine("Pacjent {0} szuka łóżka", this.identifier);
                            foreach (var bed in hospital2.Beds)
                            {
                                if (!bed.isOccupied && bed.hasRespirator)
                                {
                                    bed.isOccupied = true;
                                    bedIdentifier = bed.identifier;
                                }
                            }
                        }

                        if (bedIdentifier2 != Guid.Empty)
                        {
                            Console.WriteLine("Pacjent {0} zajmuje łóżko {1}", this.identifier, bedIdentifier2);
                            Thread.Sleep(1000);
                            this.healthCondition = HealthCondition.HEALTHY;
                            this.hasVirus = false;
                            Hospital.Instance.Beds.Find(x => x.identifier == bedIdentifier2).isOccupied = false;
                        }
                        // infekuje innych (za sprawą wątku postępu choroby)
                        // może iść do szpitala - checked
                        // może umrzeć (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.DEAD:
                        Console.WriteLine("Pacjent umarł na śmierć");
                        isAlive = false;
                        break;
                }
                Thread.Sleep(StaticRandom.Rand(800,1200));
            }
        }
    }
}
