using System;
namespace ComparisonsInDotNet
{
    public struct CalorieCount : IComparable<CalorieCount>, IEquatable<CalorieCount>, IComparable
    {
        private float _value;
        public float Value { get { return _value; }}

        public CalorieCount(float value){
            this._value = value;
        }

		public override string ToString()
		{
            return _value + " cal";
		}

        public int CompareTo(CalorieCount other)
        {
            return _value.CompareTo(other._value);
        }

        public static bool operator <(CalorieCount x, CalorieCount y){
            return x._value < y._value;
        }


        public static bool operator <=(CalorieCount x, CalorieCount y)
        {
            return x._value <= y._value;
        }


        public static bool operator >(CalorieCount x, CalorieCount y)
        {
            return x._value > y._value;
        }


        public static bool operator >=(CalorieCount x, CalorieCount y)
        {
            return x._value >= y._value;
        }


        public static bool operator ==(CalorieCount x, CalorieCount y)
        {
            return x._value == y._value;
        }


        public static bool operator !=(CalorieCount x, CalorieCount y)
        {
            return x._value != y._value;
        }

		public override bool Equals(object obj)
		{
            if (obj == null)
                return false;
            if (!(obj is CalorieCount))
                return false;
            return _value == ((CalorieCount)obj)._value;
		}

        public bool Equals(CalorieCount other)
        {
            return _value == other._value;
        }

		public override int GetHashCode()
		{
            return _value.GetHashCode();
		}

        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (!(obj is CalorieCount))
                throw new ArgumentException("Expected CalorieCount interface", "obj");
            return CompareTo((CalorieCount)obj);
        }
	}
}
