using System;
using System.Collections.Generic;
using System.Text;

namespace labo3_oop
{
    class Teacher : Person
    {
        private int salary;
        public Teacher(string firstname, string lastname,int salary)
            : base(firstname, lastname)
        {
            this.salary = salary;
        }
        public int getSalary()
        {
            return this.salary;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format(" {0}",this.salary);
        }

    }
}
