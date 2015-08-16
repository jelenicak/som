using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommend
{
    class Neuron
    {
        private double[] weights;

        public double[] Weights { get; set; }

        public Neuron(int dim)
        {
            this.weights = new double[dim];
        }
    }
}
