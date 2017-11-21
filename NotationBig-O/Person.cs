using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotationBig_O
{
    public class Person
    {
        public String FirstName { set; get; }
        public String LastName { set; get; }
        public String Company { set; get; }

        public Person(String _firstname, String _lastname,String _company)
        {
            this.FirstName = _firstname;
            this.LastName = _lastname;
            this.Company = _company;
        }
        
    }
}
