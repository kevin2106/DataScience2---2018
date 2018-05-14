using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience2___2018.Models
{
    class Item
    {
        public float[] items { get; private set; }
        public int dimensionCount;
        public int clusterId;

        public Item(params float[] items)
        {
            Random r = new Random();
            this.items = items;
            this.dimensionCount = items.Length;
            this.clusterId = r.Next(Program.clusterCount); 
        }

        public float Distance (Item other)
        {
            float squaredDist = 0;
            Item mostDimensions = (items.Length >= other.items.Length ? this : other);
            for (int i = 0; i < mostDimensions.items.Length; i++)
            {
                squaredDist += (float)Math.Pow((items[i] - other.items[i]), 2);
            }

            return (float)Math.Sqrt(squaredDist);
        }
    }
}
