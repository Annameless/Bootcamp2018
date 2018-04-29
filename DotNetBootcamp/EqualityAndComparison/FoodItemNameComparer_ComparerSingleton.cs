using System;
using System.Collections.Generic;
using CustomEqualityImplementation;

namespace EqualityAndComparison
{
    public class FoodItemNameComparer_ComparerSingleton: Comparer<FoodItem>
    {
        public static FoodItemNameComparer_ComparerSingleton _instance = new FoodItemNameComparer_ComparerSingleton();

        public static FoodItemNameComparer_ComparerSingleton Instance { get { return _instance; }}

        private FoodItemNameComparer_ComparerSingleton(){}

        public override int Compare(FoodItem x, FoodItem y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            int nameOrder = string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
            if (nameOrder != 0)
                return nameOrder;
            return string.Compare(x.Group.ToString(), y.Group.ToString(), StringComparison.CurrentCulture);
        }
    }
}
