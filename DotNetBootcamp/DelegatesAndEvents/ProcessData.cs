using System;
namespace DelegatesAndEvents
{
    public delegate int BizRulesDelegate(int x, int y);

    public class ProcessData
    {
        public void Process(int x, int y, BizRulesDelegate del){
            Console.WriteLine(del(x, y));
        }

        public void ProcessAction(int x, int y, Action<int, int> action){
            action(x, y);
            Console.WriteLine("Action has been processed");
        }

        public int ProcessFunction(int x, int y, Func<int, int, int> func){
            Console.WriteLine("Processingn function now");
            return func(x, y);
        }
    }
}
