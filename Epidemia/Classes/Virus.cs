using System.Collections.Generic;

namespace Epidemia.Classes
{
    class Virus
    {
        private static volatile Virus instance = null;
        private static readonly object accessLock = new object();
        private int infectionRatio;
        private bool isMutable;
        private double mutationProbability;

        public static Virus Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (accessLock)
                    {
                        if (instance == null)
                        {
                            instance = new Virus();
                        }
                    }
                }
                return instance;
            }
        }

        public int InfectionRatio
        {
            get
            {
                int returned = 0;
                lock (accessLock)
                {
                    returned = infectionRatio;
                }
                return returned;
            }
            set
            {
                lock (accessLock)
                {
                    infectionRatio = value;
                }
            }
        }

        public bool IsMutable
        {
            get
            {
                bool returned = false;
                lock (accessLock)
                {
                    returned = isMutable;
                }
                return returned;
            }
            set
            {
                lock (accessLock)
                {
                    isMutable = value;
                }
            }
        }

        public double MutationProbability
        {
            get
            {
                double returned = 0;
                lock (accessLock)
                {
                    returned = mutationProbability;
                }
                return returned;
            }
            set
            {
                lock (accessLock)
                {
                    mutationProbability = value;
                }
            }
        }

        public void mutate(ref List<Human> population) { }
        public void infect(ref List<Human> population) { }

        public void initialize(int infectionRatio, bool isMutable, double mutationProbability) 
        {
            this.infectionRatio = infectionRatio;
            this.isMutable = isMutable;
            this.mutationProbability = mutationProbability;
        }
    }
}
