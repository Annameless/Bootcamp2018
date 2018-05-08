using System.Collections.Generic;
using Xunit;

namespace GenericCollections.Tests
{
    public class StackTests
    {
		[Fact]
        public void Can_Peek_At_Next_Item()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            Assert.Equal(3, stack.Peek());
        }

        [Fact]
        public void Can_Search_With_Contains()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            Assert.True(stack.Contains(2));
        }

        [Fact]
        public void Can_Convert_To_Array()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var asArray = stack.ToArray();
            stack.Pop();

			Assert.Equal(3, asArray[0]);
			Assert.Equal(2, stack.Count);
        } 
    }
}
