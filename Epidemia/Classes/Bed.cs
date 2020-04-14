using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epidemia.Classes
{
    class Bed
    {

        public Bed(Guid identifier, bool hasRespirator, bool isOccupied)
        {
            this.identifier = identifier;
            this.hasRespirator = hasRespirator;
            this.isOccupied = isOccupied;
            this.mutex = new Mutex();
        }

        public Guid identifier { get; set; }
        public bool hasRespirator { get; set; }
        public bool isOccupied { get; set; }
        public void recover(Human human) { }
        public Mutex mutex { get; set; }
    }
}
