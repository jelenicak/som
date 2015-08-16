using System;
using System.Collections.Generic;

namespace Recommend
{
    static class Training
    {
        public static double calculateDistance(double[] v1, double[] v2)
        {
            double sum = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                sum += Math.Pow((v1[i] - v2[i]), 2);
            }
            return Math.Sqrt(sum);
        }

        public static List<double[]> getTrainingSet(String filePath)
        {
            List<double[]> set = new List<double[]>();
            int currentMovie = 1;
            int tagId = 0;
            string[] lines = System.IO.File.ReadAllLines(filePath);
            string[] tokens;
            double[] trainingExample = new double[1128];

            foreach (string line in lines)
            {
                tokens = line.Split('\t');
                if (!tokens[0].Equals(currentMovie.ToString()))
                {
                    set.Add(trainingExample);
                    currentMovie++;
                    tagId = 0;
                    trainingExample = new double[1128];
                }
                trainingExample[tagId] = Double.Parse(tokens[2], System.Globalization.NumberStyles.AllowDecimalPoint);
                tagId++;
            }
            set.Add(trainingExample);
            return set;
        }
    }
}
