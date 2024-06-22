using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ProlabWithFP
{
    public class Admin : User
    {

        public static Admin realAdmin { get; set; }


        public Admin(string username,string password)
        {
            this.username = username;
            this.password = password;
        }

        public static void addCompany(Company company)
        {
            Company.addNewCompany(company);
        }

        public static void setServicePrice()
        {
            ServicePayPanel spp = new ServicePayPanel();
            spp.ShowDialog();
        }
        public static void removeCompany()
        {
            RemoveCompanyForm rcf = new RemoveCompanyForm();
            rcf.ShowDialog();
        }  
               

    }
}
