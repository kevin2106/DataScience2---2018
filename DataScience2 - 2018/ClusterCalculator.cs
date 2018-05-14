using DataScience2___2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience2___2018
{
    class ClusterCalculator
    {

        public static Cluster[] Cluster(int k, int iterations, Item[] data)
        {
            Cluster[] clusters = new Cluster[k];
            for (int i = 0; i < clusters.Length; i++)
            {
                clusters[i] = new Cluster(i);
            }

            foreach (Item i in data)
            {
                clusters[i.clusterId].AddMember(i);
            }

            List<Item> centroids = new List<Item>();
            for (int i = 0; i < clusters.Length; i++)
            {
                clusters[i].ComputeCentroid();
                centroids.Add(clusters[i].Centroid);
            }

            bool centroidChanged = true;
            int counter = 0;

            while (centroidChanged && counter < iterations)
            {
                List<Item> oldCentroids = new List<Item>();
                foreach(Item i in data)
                {
                    oldCentroids.Add(i);
                    for (int j = 0; j < clusters.Length; j++)
                    {
                        i.clusterId = (i.Distance(clusters[j].Centroid) < i.Distance(clusters[i.clusterId].Centroid) ? j : i.clusterId);
                    }
                }

            }

            return null;
        }
    }
}
