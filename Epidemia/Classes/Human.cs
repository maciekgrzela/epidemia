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

        private Mutex allowToFindBed = new Mutex();
        private Mutex allowToMakeTest = new Mutex();
        private Mutex allowToInoculate = new Mutex();

        private static readonly object randomLock = new object();


        public void makeTest(ref List<Test> tests) 
        {
            if(tests.Count > 0)
            {
                double positive = StaticRandom.Rand();
                Console.WriteLine("Wartość positive: {0}", positive);

                tests[0].isPositive = positive < 0.3f ? true : false;
                if (tests[0].isPositive == true)
                {
                    this.hasVirus = true;
                    this.healthCondition = HealthCondition.INFECTED;
                }
                this.tested = true;
                tests.RemoveAt(0);
            }
        }

        public void inoculate(ref List<Vaccine> vaccines)
        {
            if(vaccines.Count > 0)
            {
                if (vaccines[0].isEffective)
                {
                    this.hasVirus = false;
                    this.tested = false;
                    this.inoculated = true;
                    this.healthCondition = HealthCondition.HEALTHY;
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
                        Hospital hospital1 = Hospital.Instance;
                        if (this.tested == true)
                        {
                            if (this.inoculated == false)
                            {
                                if (allowToInoculate.WaitOne())
                                {
                                    List<Vaccine> vaccines1 = hospital1.Vaccines;
                                    if (vaccines1.Count > 0)
                                    {
                                        this.inoculate(ref vaccines1);
                                        hospital1.Vaccines = vaccines1;
                                        Console.WriteLine("Pacjent {0} się zaszczepił", this.identifier);
                                    }
                                    allowToInoculate.ReleaseMutex();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Pacjent {0} jest zaszczepiony", this.identifier);
                            }
                        }
                        else
                        {
                            if (allowToMakeTest.WaitOne())
                            {
                                List<Test> tests1 = hospital1.Tests;
                                if (tests1.Count > 0)
                                {
                                    this.makeTest(ref tests1);
                                    Console.WriteLine("Pacjent {0} wykonał test. Wynik: {1}", this.identifier, this.hasVirus);
                                    hospital1.Tests = tests1;
                                }
                                allowToMakeTest.ReleaseMutex();
                            }
                        }
                        // może zrobić test - checked
                        // jeżeli jego test okaże się pozytywny, może wziąć szczepionkę - checked
                        // może się stać zainfekowany (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.INFECTED:
                        Console.WriteLine("Pacjent {0} jest zainfekowany", this.identifier);
                        // może zainfekować innych (za sprawą wątku postępu choroby)
                        // może stać się chory (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.ILL:
                        Hospital hospital2 = Hospital.Instance;
                        List<Bed> beds2 = hospital2.Beds;
                        if (allowToFindBed.WaitOne())
                        {
                            Console.WriteLine("Pacjent {0} szuka łóżka", this.identifier);
                            foreach (var bed in beds2)
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
                        // może iść do szpitala - checked
                        // może stać się terminalnie chory (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.TERMINALLY_ILL:
                        Console.WriteLine("Pacjent {0} jest terminalnie chory", this.identifier);
                        Hospital hospital3 = Hospital.Instance;
                        List<Bed> beds3 = hospital3.Beds;
                        if (allowToFindBed.WaitOne())
                        {
                            Console.WriteLine("Pacjent {0} szuka łóżka", this.identifier);
                            foreach (var bed in beds3)
                            {
                                if (!bed.isOccupied && bed.hasRespirator)
                                {
                                    bed.isOccupied = true;
                                    allowToFindBed.ReleaseMutex();
                                    if (bed.mutex.WaitOne())
                                    {
                                        Console.WriteLine("Pacjent {0} zajmuje łóżko z respiratorem {1}", this.identifier, bed.identifier);
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
                        // może iść do szpitala - checked
                        // może umrzeć (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.DEAD:
                        isAlive = false;
                        break;
                }
                Thread.Sleep(2000);
            }
        }
    }
}
