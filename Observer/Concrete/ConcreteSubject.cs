using Observer.AbstractAndBaseFramework;

namespace Observer.Concrete
{
    class ConcreteSubject:Subject
    {
        private string _subjectState;

        public string SubjectState
        {
            get { return _subjectState;}
            set { _subjectState = value; }
        }
    }
}
