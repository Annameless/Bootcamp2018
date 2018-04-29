using System;
using System.Collections.Generic;

namespace EqualityAndComparison
{
    public class FoodStructEqualityComparer: EqualityComparer<FoodStruct>
    {
        private static readonly FoodStructEqualityComparer _instance = new FoodStructEqualityComparer();
        public static FoodStructEqualityComparer Instance { get { return _instance; }}
        private FoodStructEqualityComparer(){}

        public override bool Equals(FoodStruct x, FoodStruct y)
        {
            return x.Name.ToLowerInvariant() == y.Name.ToLowerInvariant() && x.Group == y.Group;
        }

        public override int GetHashCode(FoodStruct obj)
        {
            return obj.Name.ToLowerInvariant().GetHashCode() ^ obj.Group.GetHashCode();
        }
    }
}
