using System;
using System.Collections.Generic;

namespace Recommend
{
    class Program
    {
        static void Main(string[] args)
        {

            Map map = new Map(10, 1128);
            map.initialize();

            List<double[]> trainingSet = Training.getTrainingSet(@"..\..\Resources\tag_relevancetxt.txt");
            Neuron winner = map.findWinner(trainingSet[2]);

            Console.ReadLine();


        }
    }
}
