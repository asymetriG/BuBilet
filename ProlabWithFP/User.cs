using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public abstract class User : ILoginable
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
