using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public interface ILoginable
    {
        string username { get; set; }
        string password { get; set; }
    }
}
