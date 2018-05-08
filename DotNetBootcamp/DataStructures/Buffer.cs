using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
	public class Buffer<T> : IBuffer<T>
	{
		protected Queue<T> _queue = new Queue<T>();

		public virtual bool IsEmpty => _queue.Count == 0;

		public IEnumerator<T> GetEnumerator()
		{
			//return _queue.GetEnumerator();
			foreach (var item in _queue)
            {
                yield return item;
            }
		}

		public virtual T Read()
		{
			return _queue.Dequeue();
		}

		public virtual void Write(T value)
		{
			_queue.Enqueue(value);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
