using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoExample
{
    public class EmployeeExtended : Person
    {

        string id;

        // if Person changes then we have to change this as well
        public EmployeeExtended(string firstName, string lastName, string id) : base(firstName, lastName)
        {
            this.id = id;
        }

        public string getId()
        {
            return id;
        }
    }
}
