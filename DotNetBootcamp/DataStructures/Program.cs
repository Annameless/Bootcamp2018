using System;

namespace DataStructures
{
    class Program
    {
		static void ConsoleWrite(double data){
			Console.WriteLine(data);
		}

        static void Main(string[] args)
		{
			var buffer = new Buffer<double>();

			ProcessInput(buffer);

			buffer.Dump(d => Console.WriteLine(d));

			var asInts = buffer.AsEnumerableOf<int>();
			foreach (var item in asInts)
                Console.WriteLine(item);
            
			var asIntsFromExtension = buffer.AsEnumerableOf<double, int>();
			foreach (var item in asIntsFromExtension)
                Console.WriteLine(item);

			Converter<double, DateTime> converter = d => new DateTime(2018, 05, 09).AddDays(d);
			var asDates = buffer.Map<double, DateTime>(converter);
			foreach(var item in asDates){
				Console.WriteLine(item);
			}

            ProcessBuffer(buffer);


			var cBuffer = new CircularBuffer<double>(capacity:3);
			cBuffer.ItemDiscarded += CBuffer_ItemDiscarded;

			ProcessInput(cBuffer);

			ProcessBuffer(cBuffer);
        }

		private static void ProcessBuffer(IBuffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine(sum);
        }

		private static void ProcessInput(IBuffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }

		static void CBuffer_ItemDiscarded(object sender, ItemDiscardedEventArgs<double> e)
		{
			Console.WriteLine("Buffer full. Discarding {0} New item is {1}", e.ItemDiscarded, e.NewItem);
		}      
	}
}
