using DataScience2___2018.Data;
using DataScience2___2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience2___2018
{
    class Program
    {
        public static int clusterCount = 5;
        static Item[] data;
        static void Main(string[] args)
        {

            data = DataProcessor.fileReader();

            List<Cluster[]> clusterResults = new List<Cluster[]>();

            int algorithmCount = 500;

            int counter = 0;

            while (counter < algorithmCount)
            {
                Cluster[] clusterResult = ClusterModule.Cluster(clusterCount, )
            }
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
