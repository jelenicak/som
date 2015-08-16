namespace Recommend
{
    class Neuron
    {
        private double[] weights;

        public double[] Weights
        {
            get { return weights; }
            set { weights = value; }
        }


        public Neuron(int dim)
        {
            this.weights = new double[dim];
        }
    }
}
