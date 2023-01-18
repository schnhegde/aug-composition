using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoExample
{
    public class Employee
    {
        private string id;
        private Person person;

        // as person is composed here no change required if new things are added to person class
        // it is self contained
        public Employee(string id, Person person)
        {
            this.id = id;
            this.person = person;
        }

        public string getId()
        {
            return id;
        }

        public string getFullName()
        {
            return person.getFullName();
        }
    }
}
