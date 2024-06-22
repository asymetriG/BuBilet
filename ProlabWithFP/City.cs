using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public class City
    {
        public string name { get; set; }

        public City(string name) { 
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
