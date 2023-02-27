using System;
using System.Collections.Generic;
using System.Text;

namespace labo3_oop
{
    class Cote : Evaluations
    {
        private float note;
        public Cote(Activity acti, float note)
            :base(acti)
        {
            this.note = note;
        }
        public override double Note()
        {
            return this.note;
        }
        public void setNote(float note)
        {
            this.note = note;
        }
    }
}
