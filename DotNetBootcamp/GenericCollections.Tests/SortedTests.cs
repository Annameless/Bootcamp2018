using System.Collections.Generic;
using Xunit;

namespace GenericCollections.Tests
{
    public class SortedTests
    {
		[Fact]
        public void Can_Use_Sorted_List()
        {
            var list = new SortedList<int, string>();

            list.Add(3, "three");
            list.Add(1, "one");
            list.Add(2, "two");

            Assert.Equal(0, list.IndexOfKey(1));
			Assert.Equal(1, list.IndexOfValue("two"));
        }

        [Fact]
        public void Can_Use_Sorted_Set()
        {
            var set = new SortedSet<int>();

            set.Add(3);
            set.Add(1);
            set.Add(2);

            var enumerator = set.GetEnumerator();
            enumerator.MoveNext();
			Assert.Equal(enumerator.Current, 1);
        }
    }
}
