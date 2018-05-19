using System;
namespace DelegatesAndEvents
{
    //public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs args);
                                            
    public class Worker
    {
        //public event WorkPerformedHandler WorkPerformed;
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public virtual void DoWork(int h, WorkType wt){
            for (int i = 0; i < h; i++){
                OnWorkPerformed(i + 1, wt);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int h, WorkType wt){
            if(WorkPerformed != null){
                WorkPerformed(this, new WorkPerformedEventArgs(h, wt));
            }
        }

        protected virtual void OnWorkCompleted()
        {
            var del = WorkCompleted as EventHandler;
            if(del != null){
                del(this, EventArgs.Empty);
            }
        }
    }
}
