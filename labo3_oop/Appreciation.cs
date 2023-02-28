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
            setNote();
        }
        public override double Note()
        {
            return base.Note();
        }
        public void setNote()
        {
            switch (this.appreciation)
            {
                case "N":
                    base.SetNote(4);
                    break;
                case "C":
                    base.SetNote(8);
                    break;
                case "B":
                    base.SetNote(12);
                    break;
                case "TB":
                    base.SetNote(16);
                    break;
                case "X":
                    base.SetNote(20);
                    break;
                default:
                    base.SetNote(10);
                    break;
            }
        }
    }
}
