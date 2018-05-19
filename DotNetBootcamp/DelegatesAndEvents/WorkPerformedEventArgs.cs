using System;
namespace DelegatesAndEvents
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public WorkPerformedEventArgs(int h, WorkType wt){
            Hours = h;
            WorkType = wt;
        }

        public int Hours
        {
            get;
            set;
        }
            public WorkType WorkType
        {
            get;
            set;
        }
    }
}
