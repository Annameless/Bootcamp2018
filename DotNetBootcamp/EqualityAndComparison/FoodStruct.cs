using System;
using CustomEqualityImplementation;

namespace EqualityAndComparison
{
    public struct FoodStruct: IEquatable<FoodStruct>
    {
        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; }}
        public FoodGroup Group { get { return _group; }}

        public FoodStruct(string name, FoodGroup group){
            _name = name;
            _group = group;
        }

		public override string ToString()
		{
            return _name;
		}

        public bool Equals(FoodStruct other)
        {
            return _name.Equals(other._name) && _group.Equals(other._group);
        }
	}
}
