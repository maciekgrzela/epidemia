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
        public DiseaseProgress()
        {
        }

        public void disease()
        {
            while (true)
            {
                Hospital hospital = Hospital.Instance;
                Console.WriteLine("Empidemia sie rozwija");
                Console.WriteLine("Stan zasobow: Vaccines:{0}, Tests:{1}", hospital.Vaccines.Count, hospital.Tests.Count);
                Thread.Sleep(1000);
            }
        }
    }
}
