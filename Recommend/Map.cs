using System;
using System.Collections.Generic;

namespace Recommend
{
    class Map
    {
        private Neuron[,] lattice;
        private int size;
        private int dim;

        private List<double[]> trainingSet;

        public Map(int size, int dim)
        {
            this.size = size;
            this.dim = dim;
            lattice = new Neuron[size, size];
        }

        public void initialize()
        {
            Randomizer rand = new Randomizer();
            for (int i = 0; i < size;  i++)
            {
                for (int j = 0; j < size; j++)
                {
                    lattice[i, j] = new Neuron(dim);
                    lattice[i, j].Weights = rand.getRandomVector(dim);
                }
            }
        }

        public Neuron findWinner(double[] weights)
        {
            double min = Double.MaxValue;
            Neuron winner = null;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    double distance = Training.calculateDistance(weights, lattice[i, j].Weights);
                    if (distance < min)
                    {
                        min = distance;
                        winner = lattice[i, j];
                    }
                }
            }
            return winner;
            
        }

        public void printValues()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < dim; k++)
                    {
                        Console.Write(lattice[i, j].Weights[k] + " ");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
