using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DataScience2___2018.Models;

namespace DataScience2___2018.Data
{
    class DataProcessor
    {

        public static Item[] fileReader()
        {
            List<Item> itemList = new List<Item>();
            char delimiter = ',';

            using (StreamReader sr = new StreamReader("WineData.csv"))
            {
 
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(delimiter);

                    List<float> itemValues = new List<float>();
                    foreach (string s in values)
                    {
                        itemValues.Add(float.Parse(s));
                    }

                    itemList.Add(new Item(itemValues.ToArray()));
                    
                }
            }
            return itemList.ToArray();
        }
    }
}
