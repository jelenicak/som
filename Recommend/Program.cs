using System;

namespace Recommend
{
    class Program
    {
        static void Main(string[] args)
        {

            Map map = new Map(10, 1128);
            map.initialize();

            TrainingSet trainingSet = new TrainingSet();
            trainingSet.prepare();

            Neuron n = new Neuron(1128);
            n.Weights = trainingSet.Set[2];
            Neuron winner = map.findWinner(n);

            Console.ReadLine();


        }
    }
}
