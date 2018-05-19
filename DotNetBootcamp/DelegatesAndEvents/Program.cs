using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            //var del1 = new WorkPerformedHandler(WorkPerf1);
            //var del2 = new WorkPerformedHandler(WorkPerf2);
            //var del3 = new WorkPerformedHandler(WorkPerf3);

            //del1(5, WorkType.Golf);
            //del2(10, WorkType.GenerateReports);

            //del1 += del2;
            //del1 += del3;
            //del1(10, WorkType.GoToMeetings);

            //del1 += del2 + del3;
            //var totalH = del1(11, WorkType.GoToMeetings);
            //Console.WriteLine(totalH);
            var pd = new ProcessData();
            pd.Process(2, 3, (a, b) => a * b);

            pd.ProcessAction(2, 3, new Action<int, int>((x, y) => Console.WriteLine(x + y)));

            var result = pd.ProcessFunction(3, 2, new Func<int, int, int>((x, y) => x - y));
            Console.WriteLine("Result of function is " + result);

            Worker worker = new Worker();
            worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            worker.WorkCompleted += Worker_WorkCompleted;
            worker.WorkCompleted += delegate (object sender, EventArgs a)
            {
                Console.WriteLine("Success - via anonymous method");
            };
            worker.WorkCompleted += (s, e) => Console.WriteLine("Yay - via Lambda");
            worker.DoWork(8, WorkType.GenerateReports);
        }

        static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs args){
            Console.WriteLine(args.Hours + " - " + args.WorkType);
        }

        static void Worker_WorkCompleted(object sender, EventArgs args)
        {
            Console.WriteLine("Worker completed");
        }

        static int WorkPerf1(int h, WorkType wt){
            Console.WriteLine("1 called " + h);
            return h + 1;
        }

        static int WorkPerf2(int h, WorkType wt)
        {
            Console.WriteLine("2 called " + h);
            return h +2;
        }

        static int WorkPerf3(int h, WorkType wt)
        {
            Console.WriteLine("3 called " + h);
            return h +3;
        }
    }

    public enum WorkType{
        GoToMeetings,
        Golf, 
        GenerateReports
    }
}
