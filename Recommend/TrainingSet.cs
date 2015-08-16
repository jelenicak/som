using System;
using System.Collections.Generic;

namespace Recommend
{
    class TrainingSet
    {
        private List<double[]> set;

        public List<double[]> Set
        {
            get { return set; }
            set { set = value; }
        }


        public TrainingSet()
        {
            set = new List<double[]>();
        }

        public void prepare()
        {
            int currentMovie = 1;
            int tagId = 0;
            string[] lines = readLines();
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
        }

        private string[] readLines()
        {
            return System.IO.File.ReadAllLines( @"..\..\Resources\tag_relevancetxt.txt");
        }
    }
}
