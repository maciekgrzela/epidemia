using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epidemia.Classes
{
    class DiseaseProgress
    {
        private readonly int vaccinesSuply;
        private readonly int testsSupply;
        private List<Human> people;

        public DiseaseProgress(int vaccinesSuply, int testsSupply, List<Human> people)
        {
            this.vaccinesSuply = vaccinesSuply;
            this.testsSupply = testsSupply;
            this.people = people;
        }

        public void disease()
        {
            bool disease = true;
            while (disease)
            {
                if (Epidemia.Stopped == true)
                {
                    disease = false;
                }else
                {
                    int infectOtherCount = 0;
                    int newVaccinesAreReady = 0;
                    int newTestsAreReady = 0;
                    Hospital hospital = Hospital.Instance;
                    Virus virus = Virus.Instance;

                    if (newVaccinesAreReady <= 0)
                    {
                        hospital.orderVaccines(this.vaccinesSuply);
                    }

                    if (newTestsAreReady <= 0)
                    {
                        hospital.orderTests(this.testsSupply);
                    }

                    foreach (var human in people)
                    {
                        switch (human.healthCondition)
                        {
                            case HealthCondition.HEALTHY:
                                if (human.inoculated == false && StaticRandom.Rand() < 0.3f)
                                {
                                    human.setHealthStatus(true, HealthCondition.INFECTED, false, false);
                                    Epidemia.Form.Invoke(new Action(() =>
                                    {
                                        if (human.inoculated == false)
                                        {
                                            Epidemia.Form.populationTable.Controls.Find(human.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._003_difficulty_breathing;
                                        }
                                    }));
                                }
                                break;
                            case HealthCondition.INFECTED:
                                if (human.InfectionTime <= 0)
                                {
                                    human.recoverTimes();

                                    double recoveryProb = StaticRandom.Rand();
                                    if (recoveryProb < 0.15f)
                                    {
                                        human.setHealthStatus(false, HealthCondition.HEALTHY, false, false);
                                        Epidemia.Form.Invoke(new Action(() => {
                                            Epidemia.Form.populationTable.Controls.Find(human.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources.medical_mask;
                                        }));
                                    }
                                    else
                                    {
                                        human.setHealthStatus(true, HealthCondition.ILL, false, false);
                                        Epidemia.Form.Invoke(new Action(() =>
                                        {
                                            Epidemia.Form.populationTable.Controls.Find(human.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources.sick;
                                        }));
                                    }
                                }
                                else
                                {
                                    double infectPropb = StaticRandom.Rand();
                                    if (human.tested == false)
                                    {
                                        if (infectPropb < 0.3f)
                                        {
                                            infectOtherCount++;
                                        }
                                    }
                                    else
                                    {
                                        if (infectPropb < 0.15f)
                                        {
                                            infectOtherCount++;
                                        }
                                    }

                                }
                                break;
                            case HealthCondition.ILL:
                                if (human.IllnessTime <= 0)
                                {
                                    human.recoverTimes();
                                    double recoveryProb = StaticRandom.Rand();
                                    if (recoveryProb < 0.1f)
                                    {
                                        human.setHealthStatus(false, HealthCondition.HEALTHY, false, false);
                                        Epidemia.Form.Invoke(new Action(() => {
                                            Epidemia.Form.populationTable.Controls.Find(human.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources.medical_mask;
                                        }));
                                    }
                                    else
                                    {
                                        human.setHealthStatus(true, HealthCondition.TERMINALLY_ILL, human.tested, false);
                                        Epidemia.Form.Invoke(new Action(() =>
                                        {
                                            Epidemia.Form.populationTable.Controls.Find(human.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._034_fever;
                                        }));
                                    }
                                }
                                else
                                {
                                    double infectPropb = StaticRandom.Rand();
                                    if (human.tested == false)
                                    {
                                        infectOtherCount++;
                                    }
                                    else
                                    {
                                        if (infectPropb < 0.5f)
                                        {
                                            infectOtherCount++;
                                        }
                                    }
                                }
                                break;
                            case HealthCondition.TERMINALLY_ILL:
                                if (human.TerminalIllnessTime <= 0)
                                {
                                    human.recoverTimes();
                                    human.setHealthStatus(true, HealthCondition.DEAD, human.tested, false);
                                    Epidemia.Form.Invoke(new Action(() =>
                                    {
                                        Epidemia.Form.populationTable.Controls.Find(human.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources.coffin;
                                    }));
                                }
                                else
                                {
                                    double infectPropb = StaticRandom.Rand();
                                    if (human.tested == false)
                                    {
                                        infectOtherCount++;
                                    }
                                    else
                                    {
                                        if (infectPropb < 0.5f)
                                        {
                                            infectOtherCount++;
                                        }
                                    }
                                }
                                break;
                            case HealthCondition.DEAD:
                                break;
                        }
                    }

                    virus.infect(ref people, infectOtherCount);

                    if (virus.IsMutable)
                    {
                        virus.mutate(ref people);
                    }


                    infectOtherCount = 0;
                    if (newVaccinesAreReady > 0)
                    {
                        newVaccinesAreReady--;
                    }
                    else
                    {
                        newVaccinesAreReady = 10;
                    }
                    if (newTestsAreReady > 0)
                    {
                        newTestsAreReady--;
                    }
                    else
                    {
                        newTestsAreReady = 5;
                    }
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
