using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epidemia.Classes
{
    class Virus
    {
        public Guid identifier { get; set; }
        private int infectionRatio { get; set; }
        public bool isMutable { get; set; }
        public void mutate() { }
    }
}
