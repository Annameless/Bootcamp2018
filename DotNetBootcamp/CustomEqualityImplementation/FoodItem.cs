using System;

namespace CustomEqualityImplementation
{
    public class FoodItem : IEquatable<FoodItem>
    {
        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; } }
        public FoodGroup Group { get { return _group; } }

        public FoodItem(string name, FoodGroup group)
        {
            _name = name;
            _group = group;
        }

        public override string ToString()
        {
            return _name;
        }

        public bool Equals(FoodItem other)
        {
            return _name == other.Name && _group == other.Group;
        }

		public override bool Equals(object obj)
		{
            if(obj is FoodItem)
                return Equals((FoodItem)obj);
            return false;
		}

        public static bool operator ==(FoodItem l, FoodItem r){
            return l.Equals(r);
        }

        public static bool operator !=(FoodItem l, FoodItem r)
        {
            return !l.Equals(r);
        }

		public override int GetHashCode()
		{
            return _name.GetHashCode() ^ _group.GetHashCode();
		}
	}
}
