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

        public DiseaseProgress(int vaccinesSuply, int testsSupply)
        {
            this.vaccinesSuply = vaccinesSuply;
            this.testsSupply = testsSupply;
        }

        public void disease()
        {
            while (true)
            {
                Hospital hospital = Hospital.Instance;
                Console.WriteLine("Empidemia sie rozwija");
                Console.WriteLine("Stan zasobow: Vaccines:{0}, Tests:{1}", hospital.Vaccines.Count, hospital.Tests.Count);

                if(hospital.Vaccines.Count == 0)
                {
                    hospital.orderVaccines(this.vaccinesSuply);
                    Console.WriteLine("Dokonano zakupu szczepionek");
                }

                if(hospital.Tests.Count == 0)
                {
                    hospital.orderTests(this.testsSupply);
                    Console.WriteLine("Dokonano zakupu testów");
                }


                // Bed.cs - nic sie nie dzieje
                
                // Human.cs - HEALTHY - other - może zostać zainfekowany
                // Human.cs - HEALTHY - tested - może zostać zainfekowany
                // Human.cs - HEALTHY - inoculated - nic sie nie dzieje
                // Human.cs - INFECTED - może infekować innych
                // Human.cs - INFECTED - po infectionTime staje się chory
                // Human.cs - ILL - infekuje innych
                // Human.cs - ILL - po illnessTime staje się terminalnie chory
                // Human.cs - TERMINALLY_ILL - infekuje innych
                // Human.cs - TERMINALLY_ILL - po terminalIllnessTime umiera

                // Hospital.cs - Vaccines - jeżeli się skończą kupujemy nowe checked
                // Hospital.cs - Tests - jeżeli się skończą kupujemy nowe checked
                
                // Virus.cs - z bardzo niewielkim prawdopodobieństwem może mutować
                // wszyscy pacjenci posiadają wtedy inoculated=false

                Thread.Sleep(1000);
            }
        }
    }
}
