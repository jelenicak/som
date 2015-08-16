using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommend
{
    class TrainingSet
    {
        private List<double[]> set;

        public TrainingSet()
        {
            set = new List<double[]>();
        }

        public void prepare()
        {
            int current = 1;
            double[] trainingExample = new double[1128];
            int tagId = 0;
            string[] lines = readLines();
            string[] tokens;
            foreach (string line in lines)
            {
                tokens = line.Split('\t');
                if (tokens[0].Equals(current.ToString()))
                {
                    trainingExample[tagId] = Double.Parse(tokens[2], System.Globalization.NumberStyles.AllowDecimalPoint);
                    tagId++;
                } else
                {
                    set.Add(trainingExample);
                    current++;
                    tagId = 0;
                    trainingExample = new double[1128];
                    trainingExample[tagId] = Double.Parse(tokens[2], System.Globalization.NumberStyles.AllowDecimalPoint);
                    tagId++;
                }
            }
            set.Add(trainingExample);
            Console.WriteLine("Done!");
        }

        private string[] readLines()
        {
            return System.IO.File.ReadAllLines(@"C:\Users\Jelena\Documents\Visual Studio 2013\Projects\Recommend\tag-genome\tag_relevancetxt.txt");
        }
    }
}
