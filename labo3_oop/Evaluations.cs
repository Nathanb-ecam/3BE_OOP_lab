namespace labo3_oop
{
    class Evaluations
    {
        private Activity activity;
        private double note;
        protected Evaluations(Activity activity)
        {
            this.activity = activity;
            this.note = 0.0;
        }
        public virtual double Note()
        {
            return this.note;
        }

        public string ToString()
        {
            return this.activity.ToString();
        }
        
    }
}