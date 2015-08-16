using System;

namespace Recommend
{
    class Program
    {
        static void Main(string[] args)
        {

            //Map map = new Map(10, 5);
            //map.initialize();
            //map.printValues();

            TrainingSet set = new TrainingSet();
            set.prepare();

            Console.ReadLine();


        }
    }
}
