using Xunit;
using System.Collections.Generic;

namespace GenericCollections.Tests
{
    public class DictionaryTests
    {
		[Fact]
        public void Can_Use_Dictionary_As_Map()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");
            
            Assert.Equal("one", map[1]);
        }

        [Fact]
        public void Can_Search_Key_With_ContainsKey()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            Assert.True(map.ContainsKey(2));
        }

        [Fact]
        public void Can_Remove_By_Key()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            map.Remove(1);

            Assert.Equal(1, map.Count);
        }   
    }
}
