using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public class Personel : Person
    {
        public int salary { get; set; }
        public Personel(string name,string surname, int salary)
        {
            this.name = name;
            this.surname = surname;
            this.salary = salary;
        }
    }
}
