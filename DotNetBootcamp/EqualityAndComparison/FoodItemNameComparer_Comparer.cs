using System;
using System.Collections.Generic;
using CustomEqualityImplementation;

namespace EqualityAndComparison
{
    public class FoodItemNameComparer_Comparer: Comparer<FoodItem>
    {
        public override int Compare(FoodItem x, FoodItem y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            return string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
        }
    }
}
