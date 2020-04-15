using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epidemia.Classes
{
    public static class StaticRandom
    {
        static int seed = Environment.TickCount;
        static readonly ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref seed)));

        public static double Rand()
        {
            return random.Value.NextDouble();
        }

        public static int Rand(int min, int max)
        {
            return random.Value.Next(min, max);
        }
    }
}
