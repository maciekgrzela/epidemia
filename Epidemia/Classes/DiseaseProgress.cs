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
            while (true)
            {
                int infectOtherCount = 0;
                int newVaccinesAreReady=0;
                int newTestsAreReady=0;
                Hospital hospital = Hospital.Instance;
                Virus virus = Virus.Instance;
                Console.WriteLine("Empidemia sie rozwija");
                Console.WriteLine("Stan zasobow: Vaccines:{0}, Tests:{1}", hospital.Vaccines.Count, hospital.Tests.Count);

                if(newVaccinesAreReady<=0)
                {
                    hospital.orderVaccines(this.vaccinesSuply);
                    Console.WriteLine("Dokonano zakupu szczepionek");
                }

                if(newTestsAreReady<=0)
                {
                    hospital.orderTests(this.testsSupply);
                    Console.WriteLine("Dokonano zakupu testów");
                }
                // szpital musi czekać aż szczepionki i testy zostaną wyprodukowane

                foreach(var human in people)
                {
                    switch (human.healthCondition)
                    {
                        case HealthCondition.HEALTHY:
                            if (!human.inoculated)
                            {
                                double infectPropb = StaticRandom.Rand();
                                if(infectPropb < 0.3f)
                                {
                                    Console.WriteLine("Pacjent {0} sie zaraził", human.identifier);
                                    human.setHealthStatus(true, HealthCondition.INFECTED, false, false);
                                    Epidemia.Form.Invoke(new Action(() =>
                                    {
                                        Epidemia.Form.populationTable.Controls.Find(human.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._003_difficulty_breathing;
                                    }));
                                }
                            }
                            break;
                        case HealthCondition.INFECTED:
                            Console.WriteLine("Wartość infectionTime: {0}", human.InfectionTime);
                            if(human.InfectionTime <= 0)
                            {
                                human.recoverTimes();

                                double recoveryProb = StaticRandom.Rand();
                                if(recoveryProb<0.15f){
                                    human.setHealthStatus(false, HealthCondition.HEALTHY, false, false);
                                    Epidemia.Form.Invoke(new Action(() => {
                                    Epidemia.Form.populationTable.Controls.Find(human.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._013_stayhome;
                                    }));
                                }
                                else {
                                Console.WriteLine("Pacjent {0} zachorował", human.identifier);
                                human.setHealthStatus(true, HealthCondition.ILL, false, false);
                                Epidemia.Form.Invoke(new Action(() =>
                                {
                                    Epidemia.Form.populationTable.Controls.Find(human.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._003_difficulty_breathing;
                                }));
                                }
                            }
                            else
                            {
                                double infectPropb = StaticRandom.Rand();
                                if(human.tested==false){
                                    if (infectPropb < 0.3f)
                                    {
                                        Console.WriteLine("Pacjent {0} zaraża innych", human.identifier);
                                        infectOtherCount++;
                                    }
                                } else {
                                    if (infectPropb < 0.15f)
                                    {
                                        Console.WriteLine("Pacjent {0} zaraża innych", human.identifier);
                                        infectOtherCount++;
                                    }
                                    //jeśli chory został przetestowany jest świadomy swojego zakażenia, prawdopodobieństwo zakażenia innych spada o połowę
                                }
                                
                            }
                            break;
                        case HealthCondition.ILL:
                            if(human.IllnessTime <= 0)
                            {
                                human.recoverTimes();
                                double recoveryProb = StaticRandom.Rand();
                                if(recoveryProb<0.1f){
                                    human.setHealthStatus(false, HealthCondition.HEALTHY, false, false);
                                    Epidemia.Form.Invoke(new Action(() => {
                                    Epidemia.Form.populationTable.Controls.Find(human.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources._013_stayhome;
                                    }));
                                }
                                else {
                                Console.WriteLine("Pacjent {0} potrzebuje respiratora", human.identifier);
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
                                if(human.tested==false){
                                    Console.WriteLine("Pacjent {0} zaraża innych", human.identifier);
                                    infectOtherCount++;
                                } else{
                                    if (infectPropb < 0.5f)
                                    {
                                        Console.WriteLine("Pacjent {0} zaraża innych", human.identifier);
                                        infectOtherCount++;
                                    }
                                }
                                 //jeśli chory został przetestowany jest świadomy swojej choroby, prawdopodobieństwo zakażenia innych spada o połowę
                            }
                            break;
                        case HealthCondition.TERMINALLY_ILL:
                            if(human.TerminalIllnessTime <= 0)
                            {
                                human.recoverTimes();
                                Console.WriteLine("Pacjent {0} umarł na śmierć", human.identifier);
                                human.setHealthStatus(true, HealthCondition.DEAD, human.tested, false);
                                Epidemia.Form.Invoke(new Action(() =>
                                {
                                    Epidemia.Form.populationTable.Controls.Find(human.identifier.ToString(), true)[0].BackgroundImage = Properties.Resources.coffin;
                                }));
                            }
                            else
                            {
                                double infectPropb = StaticRandom.Rand();
                                if(human.tested==false){
                                    Console.WriteLine("Pacjent {0} zaraża innych", human.identifier);
                                    infectOtherCount++;
                                } else{
                                    if (infectPropb < 0.5f)
                                    {
                                        Console.WriteLine("Pacjent {0} zaraża innych", human.identifier);
                                        infectOtherCount++;
                                    }
                                }
                                 //jeśli chory został przetestowany jest świadomy swojej choroby, prawdopodobieństwo zakażenia innych spada o połowę
                            }
                            break;
                        case HealthCondition.DEAD:
                            break;
                    }
                }

                for(int i = 0; i < infectOtherCount; i++)
                {
                    virus.infect(ref people);
                }

                if (virus.IsMutable)
                {
                    virus.mutate(ref people);
                }


                // Bed.cs - nic sie nie dzieje - checked
                // Human.cs - HEALTHY - other - może zostać zainfekowany - checked
                // Human.cs - HEALTHY - tested - może zostać zainfekowany -checked
                // Human.cs - HEALTHY - inoculated - nic sie nie dzieje - checked
                // Human.cs - INFECTED - może infekować innych - checked
                // Human.cs - INFECTED - po infectionTime staje się chory - checked
                // Human.cs - ILL - infekuje innych - checked
                // Human.cs - ILL - po illnessTime staje się terminalnie chory - checked
                // Human.cs - TERMINALLY_ILL - infekuje innych
                // Human.cs - TERMINALLY_ILL - po terminalIllnessTime umiera - checked
                // Hospital.cs - Vaccines - jeżeli się skończą kupujemy nowe - checked
                // Hospital.cs - Tests - jeżeli się skończą kupujemy nowe - checked

                // Virus.cs - z bardzo niewielkim prawdopodobieństwem może mutować
                // wszyscy pacjenci posiadają wtedy inoculated=false
                if(newVaccinesAreReady>0){
                    newVaccinesAreReady--;
                } else{
                    newVaccinesAreReady=5;
                }
                if(newTestsAreReady>0){
                    newTestsAreReady--;
                } else{
                    newTestsAreReady=2;
                }
                Thread.Sleep(2000);
            }
        }
    }
}
