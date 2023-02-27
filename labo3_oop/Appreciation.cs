using System;
using System.Collections.Generic;
using System.Text;

namespace labo3_oop
{
    class Appreciation : Evaluations
    {
        private string appreciation;
        public Appreciation(Activity acti, string appreciation)
            : base(acti)
        {
            this.appreciation= appreciation;
        }
        public override double Note()
        {
            return base.Note();
        }
        public void setAppreciation(string appreciation)
        {
            this.appreciation = appreciation;
        }
    }
}
