using System;

namespace CustomEqualityImplementation
{
    public class FoodItem //: IEquatable<FoodItem>
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

        //public bool Equals(FoodItem other)
        //{
        //    return _name == other.Name && _group == other.Group;
        //}

		public override bool Equals(object obj)
		{
            if (obj == null)
                return false;
            if(ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;

            var other = obj as FoodItem;
            return _name == other.Name && _group == other.Group; //Equals((FoodItem)obj);
		}

        public static bool operator ==(FoodItem l, FoodItem r){
            return object.Equals(l, r);//l.Equals(r);
        }

        public static bool operator !=(FoodItem l, FoodItem r)
        {
            return !object.Equals(l, r);//!l.Equals(r);
        }

		public override int GetHashCode()
		{
            return _name.GetHashCode() ^ _group.GetHashCode();
		}
	}
}
