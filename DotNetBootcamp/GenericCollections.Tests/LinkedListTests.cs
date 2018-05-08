using Xunit;
using System.Collections.Generic;

namespace GenericCollections.Tests
{
    public class LinkedListTests
    {
		[Fact]
        public void Can_Add_After()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");
            list.AddAfter(list.First, "there");

			Assert.Equal("there", list.First.Next.Value);
        }

        [Fact]
        public void Can_Remove_Last()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");
            list.RemoveLast();

            Assert.Equal(list.First, list.Last);
        }

        [Fact]
        public void Can_Find_Items()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");

            Assert.True(list.Contains("Hello"));
        }
    }
}
