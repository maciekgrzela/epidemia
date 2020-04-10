using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epidemia.Classes
{
    class Vaccine
    {
        public Guid identifier { get; set; }
        public bool isEffective { get; set; }
        public int protectionTime { get; set; }
        public void protect(Human human) { }
    }
}
