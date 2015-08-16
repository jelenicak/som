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
