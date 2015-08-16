using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommend
{
    public class Randomizer
    {

        private Random random;

        public Randomizer()
        {
            this.random = new Random();
        }

        public double[] getRandomVector(int length)
        {
            double[] randVector = new double[length];
            for (int i = 0; i < length; i++)
            {
                randVector[i] = Math.Round(random.NextDouble(), 3);
            }
            return randVector;
        }
    }
}
