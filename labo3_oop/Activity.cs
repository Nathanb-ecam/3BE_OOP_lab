using System;

namespace labo3_oop
{
    class Activity
    {
        private int ECTS;
        private string name, code;
        private Teacher teacher;
        public Activity(Teacher teacher,string name, string code, int ects)
        {
            this.teacher = teacher;
            this.name = name;
            this.code = code;
            this.ECTS = ects;
        }
        public string ToString()
        {
            return String.Format("{0} {1} {2}", this.name, this.code, this.ECTS);
        }
    }
}