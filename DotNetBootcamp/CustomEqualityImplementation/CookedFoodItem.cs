using System;
namespace CustomEqualityImplementation
{
    public sealed class CookedFoodItem: FoodItem
    {
        private readonly string _cookingMethod;

        public CookedFoodItem(string cookingMethod, string name, FoodGroup group) : base(name, group){
            _cookingMethod = cookingMethod;
        }

		public override string ToString()
		{
            return string.Format("{0} {1}", _cookingMethod, Name);
		}

		public override bool Equals(object obj)
		{
            if (!base.Equals(obj))
                return false;
            return _cookingMethod == ((CookedFoodItem)obj)._cookingMethod;
		}

		public override int GetHashCode()
		{
            return base.GetHashCode() ^ _cookingMethod.GetHashCode();
		}

        public static bool operator ==(CookedFoodItem l, CookedFoodItem r)
        {
            return object.Equals(l, r);
        }

        public static bool operator !=(CookedFoodItem l, CookedFoodItem r)
        {
            return !object.Equals(l, r);
        }
	}
}
