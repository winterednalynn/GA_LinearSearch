using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinearSearch
{
    public class Store
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string StoreLocation { get; set; }

        public Store(string name, string category, string storeLocation)
        {
            Name = name;
            Category = category;
            StoreLocation = storeLocation;
        }
    }
}
