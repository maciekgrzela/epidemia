using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            initiateButton();
        }

        private void initiateButton()
        {
            this.button = new Button();
            this.button.Text = "";
            this.button.BackgroundImage = Properties.Resources._013_stayhome;
            this.button.Width = 50;
            this.button.Height = 50;
            this.button.FlatStyle = FlatStyle.Flat;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.Dock = DockStyle.Fill;
            this.button.Name = this.identifier.ToString();
            this.button.BackgroundImageLayout = ImageLayout.Center;
            Epidemia.Form.Invoke(new Action(() => Epidemia.Form.populationTable.Controls.Add(this.button)));
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

        private int infectionTime = 6;
        private int illnessTime = 8;
        private int terminalIllnessTime = 4;
        private Button button;

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
                /*double positive = StaticRandom.Rand();
                tests[0].isPositive = positive < 0.3f ? true : false;
                Console.WriteLine("Pacjent {0} wykonał test. Wynik: {1}", this.identifier, tests[0].isPositive);
                if (tests[0].isPositive == true)
                {
                    this.setHealthStatus(true, HealthCondition.INFECTED, true, false);
                    Epidemia.Form.populationTable.Controls.Find(this.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._003_difficulty_breathing;
                }
                else
                {
                    this.setHealthStatus(false, HealthCondition.HEALTHY, true, false);
                    Epidemia.Form.populationTable.Controls.Find(this.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._013_stayhome;
                }
                Epidemia.Form.Invoke(new Action(() => {
                    Epidemia.Form.labTable.Controls.RemoveAt(0);
                }));
                tests.RemoveAt(0);
                */
                if (this.healthCondition==HealthCondition.HEALTHY){
                    tests[0].isPositive=false;
                    Console.WriteLine("Pacjent {0} wykonał test. Wynik: {1}", this.identifier, tests[0].isPositive);
                    this.setHealthStatus(false, HealthCondition.HEALTHY, true, false);
                    Epidemia.Form.populationTable.Controls.Find(this.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._013_stayhome;
                } else {
                    tests[0].isPositive=true;
                    Console.WriteLine("Pacjent {0} wykonał test. Wynik: {1}", this.identifier, tests[0].isPositive);
                    this.setHealthStatus(this.hasVirus, this.healthCondition, true, false);
                }
                Epidemia.Form.Invoke(new Action(() => {
                    Epidemia.Form.labTable.Controls.RemoveAt(0);
                }));
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
                Epidemia.Form.Invoke(new Action(() => {
                    Epidemia.Form.vaccinesTable.Controls.RemoveAt(0);
                }));
                vaccines.RemoveAt(0);
            }
        }

        public void recoverTimes()
        {
            this.InfectionTime = 6;
            this.IllnessTime = 10;
            this.TerminalIllnessTime = 4;
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
                                if(Monitor.TryEnter(allowToInoculate, new TimeSpan(0,0,1)))
                                {
                                    try
                                    {
                                        this.inoculate();
                                    }finally
                                    {
                                        Monitor.Exit(allowToInoculate);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Pacjent {0} jest zaszczepiony", this.identifier);
                                Epidemia.Form.Invoke(new Action(() =>
                                {
                                    Epidemia.Form.populationTable.Controls.Find(this.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._013_stayhome;
                                }));
                            }
                        }
                        else
                        {
                            if(Monitor.TryEnter(allowToMakeTest, new TimeSpan(0, 0, 1)))
                            {
                                try
                                {
                                    this.makeTest();
                                }finally
                                {
                                    Monitor.Exit(allowToMakeTest);
                                }
                            }
                        }
                        // może zrobić test - checked
                        // jeżeli jego test okaże się pozytywny, może wziąć szczepionkę - checked
                        // może się stać zainfekowany (za sprawą wątku postępu choroby) - checked
                        break;
                    case HealthCondition.INFECTED:
                        this.InfectionTime--;
                        Console.WriteLine("Pacjent {0} jest zainfekowany", this.identifier);
                        Epidemia.Form.Invoke(new Action(() => {
                            Epidemia.Form.populationTable.Controls.Find(this.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._003_difficulty_breathing;
                        }));
                        if(this.tested==false){
                            if(Monitor.TryEnter(allowToMakeTest, new TimeSpan(0, 0, 1)))
                            {
                                try
                                {
                                    this.makeTest();
                                }finally
                                {
                                    Monitor.Exit(allowToMakeTest);
                                }
                            }
                        }
                        // może zainfekować innych (za sprawą wątku postępu choroby) - checked
                        // może stać się chory (za sprawą wątku postępu choroby) - checked
                        break;
                    case HealthCondition.ILL:
                        this.IllnessTime--;
                        Epidemia.Form.Invoke(new Action(() => {
                            Epidemia.Form.populationTable.Controls.Find(this.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._003_difficulty_breathing;
                        }));
                        if(this.tested==false){
                            if(Monitor.TryEnter(allowToMakeTest, new TimeSpan(0, 0, 1)))
                            {
                                try
                                {
                                    this.makeTest();
                                }finally
                                {
                                    Monitor.Exit(allowToMakeTest);
                                }
                            }
                        }
                        Guid bedIdentifier = Guid.Empty;
                        if(Monitor.TryEnter(allowToFindBed, new TimeSpan(0,0,1)))
                        {
                            try
                            {
                                Hospital hospital2 = Hospital.Instance;
                                Console.WriteLine("Pacjent {0} szuka łóżka", this.identifier);
                                foreach (var bed in hospital2.Beds)
                                {
                                    if (!bed.isOccupied && !bed.hasRespirator)
                                    {
                                        bed.isOccupied = true;
                                        bedIdentifier = bed.identifier;
                                        Epidemia.Form.Invoke(new Action(() => {
                                            Epidemia.Form.bedsTable.Controls.Find(bed.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._041_hospital_bed_red;
                                        }));
                                        break;
                                    }
                                }
                            }finally
                            {
                                Monitor.Exit(allowToFindBed);
                            }
                        }

                        if(bedIdentifier != Guid.Empty)
                        {
                            Console.WriteLine("Pacjent {0} zajmuje łóżko {1}", this.identifier, bedIdentifier);
                            Thread.Sleep((12-this.illnessTime)*350); //czas zdrowienia zależy od tego jak długo pacjent czekał na miejsce w szpitalu
                            this.setHealthStatus(false, HealthCondition.HEALTHY, false, false);
                            Hospital.Instance.Beds.Find(x => x.identifier == bedIdentifier).isOccupied = false;
                            Epidemia.Form.Invoke(new Action(() => {
                                Epidemia.Form.bedsTable.Controls.Find(bedIdentifier.ToString(), true)[0].BackgroundImage = Properties.Resources._041_hospital_bed1;
                                Epidemia.Form.populationTable.Controls.Find(this.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._013_stayhome;
                            }));
                        }

                        // infekuje innych (za sprawą wątku postępu choroby)
                        // może iść do szpitala - checked
                        // może stać się terminalnie chory (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.TERMINALLY_ILL:
                        this.TerminalIllnessTime--;
                        Epidemia.Form.Invoke(new Action(() => {
                            Epidemia.Form.populationTable.Controls.Find(this.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._034_fever;
                        }));
                        if(this.tested==false){
                            if(Monitor.TryEnter(allowToMakeTest, new TimeSpan(0, 0, 1)))
                            {
                                try
                                {
                                    this.makeTest();
                                }finally
                                {
                                    Monitor.Exit(allowToMakeTest);
                                }
                            }
                        }
                        Console.WriteLine("Pacjent {0} jest terminalnie chory", this.identifier);
                        Guid bedIdentifier2 = Guid.Empty;
                        if (Monitor.TryEnter(allowToFindBed, new TimeSpan(0, 0, 1)))
                        {
                            try
                            {
                                Hospital hospital2 = Hospital.Instance;
                                Console.WriteLine("Pacjent {0} szuka łóżka", this.identifier);
                                foreach (var bed in hospital2.Beds)
                                {
                                    if (!bed.isOccupied && bed.hasRespirator)
                                    {
                                        bed.isOccupied = true;
                                        bedIdentifier2 = bed.identifier;
                                        Epidemia.Form.Invoke(new Action(() => {
                                            Epidemia.Form.bedsTable.Controls.Find(bedIdentifier2.ToString(), true)[0].BackgroundImage = Properties.Resources._041_hospital_bed_red;
                                        }));
                                        break;
                                    }
                                }
                            }
                            finally
                            {
                                Monitor.Exit(allowToFindBed);
                            }
                        }

                        if (bedIdentifier2 != Guid.Empty)
                        {
                            Console.WriteLine("Pacjent {0} zajmuje łóżko {1}", this.identifier, bedIdentifier2);
                            Thread.Sleep((17-this.TerminalIllnessTime)*350);  //czas zdrowienia zależy od tego jak długo pacjent czekał na miejsce w szpitalu
                            this.healthCondition = HealthCondition.HEALTHY;
                            this.hasVirus = false;
                            Epidemia.Form.Invoke(new Action(() => {
                                Epidemia.Form.bedsTable.Controls.Find(bedIdentifier2.ToString(), true)[0].BackgroundImage = Properties.Resources._006_lungs;
                                Epidemia.Form.populationTable.Controls.Find(this.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._013_stayhome;
                            }));
                            Hospital.Instance.Beds.Find(x => x.identifier == bedIdentifier2).isOccupied = false;
                        }
                        // infekuje innych (za sprawą wątku postępu choroby)
                        // może iść do szpitala - checked
                        // może umrzeć (za sprawą wątku postępu choroby)
                        break;
                    case HealthCondition.DEAD:
                        Console.WriteLine("Pacjent umarł na śmierć");
                        Epidemia.Form.Invoke(new Action(() => {
                            Epidemia.Form.populationTable.Controls.Find(this.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources.coffin;
                        }));
                        isAlive = false;
                        break;
                }
                Thread.Sleep(StaticRandom.Rand(800,1200));
            }
        }
    }
}
