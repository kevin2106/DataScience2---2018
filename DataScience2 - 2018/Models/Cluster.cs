using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience2___2018.Models
{
    class Cluster
    {
        public int Id { get; private set; }
        public Item Centroid { get; private set; }
        public List<Item> Values { get; private set; }

        public Cluster(int Id)
        {
            this.Id = Id;
            this.Centroid = null;
            this.Values = new List<Item>();
        }

        public void AddMember (Item member)
        {
            Values.Add(member);
        }

        public void ComputeCentroid()
        {
            Item sumItem = new Item(new float[Values[0].dimensionCount]);
            foreach(Item i in Values)
            {
                //sumItem = sumItem + i;
            }
        }
    }

    
}
