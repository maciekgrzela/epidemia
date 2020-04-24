using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epidemia.Classes
{
    class Hospital
    {
        private static volatile Hospital instance = null;
        private static readonly object accessLock = new object();
        private List<Vaccine> vaccines = new List<Vaccine>();
        private List<Bed> beds = new List<Bed>();
        private List<Test> tests = new List<Test>();

        public static Hospital Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (accessLock)
                    {
                        if(instance == null)
                        {
                            instance = new Hospital();
                        }
                    }
                }
                return instance;
            }
        }

        public List<Vaccine> Vaccines
        {
            get
            {
                List<Vaccine> returned = new List<Vaccine>();
                lock (accessLock)
                {
                    returned = vaccines;
                }
                return returned;
            }
            set
            {
                lock (accessLock)
                {
                    vaccines = value;
                }
            }
        }

        public List<Test> Tests
        {
            get
            {
                List<Test> returned = new List<Test>();
                lock (accessLock)
                {
                    returned = tests;
                }
                return returned;
            }
            set
            {
                lock (accessLock)
                {
                    tests = value;
                }
            }
        }

        public List<Bed> Beds
        {
            get
            {
                List<Bed> returned = new List<Bed>();
                lock (accessLock)
                {
                    returned = beds;
                }
                return returned;
            }
            set
            {
                lock (accessLock)
                {
                    beds = value;
                }
            }
        }

        public void orderVaccines(int amount) 
        {
            for (int i = 0; i < amount; i++)
            {
                this.vaccines.Add(new Vaccine(true));
            }
            
        }
        public void orderTests(int amount) 
        {
            for(int i = 0; i < amount; i++)
            {
                this.tests.Add(new Test(false));
            }
        }
        public void orderBeds(int amount, int withRespirator) 
        {
            for (int i = 0; i < amount; i++)
            {
                this.Beds.Add(new Bed(Guid.NewGuid(), false, false));
            }
            for(int i = 0; i < withRespirator; i++)
            {
                this.Beds.Add(new Bed(Guid.NewGuid(), true, false));
            }
        }
    }
}
