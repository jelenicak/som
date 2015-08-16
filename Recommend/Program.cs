using System;

namespace Recommend
{
    class Program
    {
        static void Main(string[] args)
        {

            // Read each line of the file into a string array. Each element 
            // of the array is one line of the file. 
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Jelena\Documents\Visual Studio 2013\Projects\Recommend\tag-genome\moviestxt.txt");

            // Display the file contents by using a foreach loop.
            //System.Console.WriteLine("Contents of WriteLines2.txt = ");
            //foreach (string line in lines)
            //{
            //    // Use a tab to indent each line of the file.
            //    Console.WriteLine("\t" + line);
            //}

            //// Keep the console window open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //System.Console.ReadKey();

            Map map = new Map(10, 5);
            map.initialize();
            map.printValues();
            Console.ReadLine();

        }
    }
}
