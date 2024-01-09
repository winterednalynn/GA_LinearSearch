using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinearSearch
{
    public class Movies
    {
        public Movies(string name, string category, int rate) // CONSTRUCTOR FOR MOVIES 
        {
            Name = name;
            Category = category;
            this.rate = rate;
        }
        // PROPERTIES 
        public string Name { get; set; }
        public string Category { get; set; }
        public int rate { get; set; }

        public override string ToString() // WHEN .TOSTRING IS CALLED, THIS FORMAT WILL PROMPT. 
        {
            return $"{Name} - {Category} - Rate {rate}"; 
        }
    }
   
}
