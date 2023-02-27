using System;
using System.Collections.Generic;
using System.Text;

namespace labo3_oop
{
    class Student : Person
    {
        private List<Evaluations> courses;
        public Student(string firstname, string lastname, List<Evaluations> courses) 
            : base(firstname,lastname)
        {
            this.courses = courses;
        }
        public void Add(Evaluations eval)
        {
            this.courses.Add(eval);
        }
        public double Average()
        {
            double sum = 0;
            foreach(Evaluations eval in courses)
            {
                sum +=eval.Note();
            }
            return sum/courses.Count;
        }
        public string Rapport()
        {
            Console.WriteLine("Rapport de {0}", base.ToString());
            string rapport = "";
            foreach(Evaluations eval in this.courses)
            {
                rapport += eval.ToString();
                rapport += " : ";
                rapport +=eval.Note().ToString();
                rapport += "\n";
            }
            return rapport;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
