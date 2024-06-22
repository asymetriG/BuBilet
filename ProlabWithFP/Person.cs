using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public abstract class Person
    {
        private string _name;
        private string _surname;

        public string name {
            get {
                return _name;
            }

            set { 
                _name = value;
            }
        }

        public string surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }
    }
}
