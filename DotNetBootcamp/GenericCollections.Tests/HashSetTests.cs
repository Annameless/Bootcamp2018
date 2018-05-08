using Xunit;
using System.Collections.Generic;

namespace GenericCollections.Tests
{
    public class HashSetTests
    {
		[Fact]
        public void Intersect_Sets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };
            
            set1.IntersectWith(set2);

            Assert.True(set1.SetEquals(new[] { 2, 3 }));
        }

        [Fact]
        public void Union_Sets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.UnionWith(set2);

			Assert.True(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }

        [Fact]
        public void SymmetricExceptWith_Sets()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.SymmetricExceptWith(set2);

			Assert.True(set1.SetEquals(new[] { 1, 4 }));
        }
    }
}
