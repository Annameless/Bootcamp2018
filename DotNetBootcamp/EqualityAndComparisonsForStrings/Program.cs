using System;
using System.Globalization;
using System.Threading;

namespace EqualityAndComparisonsForStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            Console.WriteLine("Current culture {0}\n", Thread.CurrentThread.CurrentCulture);
            var apple = "apple";
            var pear = "Apple";
            DisplayAllByStrComparison(apple, pear);

            Console.WriteLine("\nCharacter Expansion");
            var s1 = "Stra\u00dfe";
            var s2 = "Strasse";
            DisplayAllByStrComparison(s1, s2);

            Console.WriteLine("\nCombining diaeresis Character");
            var s3 = "erkl\u00e4ren";
            var s4 = "erkla\u0308ren";
            DisplayAllByStrComparison(s3, s4);

            Console.WriteLine("\nEquality Comparisons for Strings");
            var pineapple = "Pineapple";
            var areEqual = string.Equals(apple, pineapple, StringComparison.CurrentCultureIgnoreCase);

            int cmpResult = string.Compare(apple, pineapple, CultureInfo.GetCultureInfo("fr-FR"), CompareOptions.IgnoreSymbols);
            areEqual = (cmpResult == 0);

            //case-sensitive ordinal
            areEqual = (apple == pineapple);

            Console.WriteLine("\nString pooling and Interning");
            var str1 = "tomato";
            var str2 = "to" + "mato";
            Console.WriteLine(string.Format("strings are '{0}' and '{1}'", str1, str2));
            Console.WriteLine("str1 == str2: " + (str1 == str2));
            Console.WriteLine("ReferenceEquals(str1, str2): " + ReferenceEquals(str1, str2));
        }

        static void DisplayAllByStrComparison(string s1, string s2){
            foreach(StringComparison cmp in Enum.GetValues(typeof(StringComparison))){
                DisplayComparison(s1, s2, cmp);
            }
        }

        static void DisplayComparison(string s1, string s2, StringComparison stringComparison)
        {
            var result = string.Compare(s1, s2, stringComparison);
            Console.WriteLine("{0} {1} {2}   ({3}, {4})", s1, GetCompareSymbol(result), s2, result, stringComparison);
        }

        static string GetCompareSymbol(int r){
            if (r == 0)
                return "==";
            if (r > 0)
                return ">";
            return "<";
        }
    }
}
