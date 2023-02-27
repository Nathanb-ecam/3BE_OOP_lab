using System;
using System.Collections.Generic;
using System.Text;

namespace labo3_oop
{
    class Person
    {
        private string firstname, lastname;
        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public override String ToString()
        {
            return String.Format("{0} {1}", this.firstname, this.lastname);
        }
    }
}
