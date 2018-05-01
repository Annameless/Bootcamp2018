using System.Collections.Generic;

namespace TheArrayType
{
    public class StringLengthComparer : Comparer<string>
    {
        public static StringLengthComparer _instance = new StringLengthComparer();

        public static StringLengthComparer Instance { get { return _instance; } }

        private StringLengthComparer() { }

        public override int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
