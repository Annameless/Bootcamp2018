using System;

namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            var strBanana = "banana";

            var banana = new Food(strBanana);
            var banana2 = new Food(strBanana);
            var chocolate = new Food("chocolate");
            Console.WriteLine("banana.Equals(chocolate)? " + banana.Equals(chocolate));
            Console.WriteLine("banana.Equals(banana2)? " + banana.Equals(banana2));

            var strBanana2 = string.Copy(strBanana);
            Console.WriteLine("\nString is a reference type, but .equals is overriden by .Net to compare values. Same for Tuples and delegates");
            Console.WriteLine("strBanana.Equals((object)strBanana2)? " + strBanana.Equals((object)strBanana2));

            var strTent = "Tent";
            var tent = new Structure(strTent);
            var tent2 = new Structure(strTent);
            Console.WriteLine("\nStruct is a value type, so .equals will compare values. But because it uses reflection to find fields to compare by, performance is usually poor");
            Console.WriteLine("tent.Equals(tent2)? " + tent.Equals(tent2));


            Console.WriteLine("\nVirtual .Equals() vs Static .Equals()");

            Console.WriteLine("banana.Equals(null)? " + banana.Equals(null));
            try{
                Food n = null;
                Console.WriteLine("null.Equals(banana)? " + n.Equals(banana));
            }catch(NullReferenceException){
                Console.WriteLine("null.Equals(banana) threw an NPE");
            }

            Console.WriteLine("object.Equals(banana, null)? " + object.Equals(banana, null));
            Console.WriteLine("object.Equals(null, banana)? " + object.Equals(null, banana));
            Console.WriteLine("object.Equals(null, null)? " + object.Equals(null, null));

            Console.WriteLine("\nobject.ReferenceEquals() (there is no ability to override this method)");
            Console.WriteLine("strBanana.Equals((object)strBanana2)? " + strBanana.Equals((object)strBanana2));
            Console.WriteLine("BUT");
            Console.WriteLine("object.ReferenceEquals(strBanana, strBanana2)? " + object.ReferenceEquals(strBanana, strBanana2));
        }
    }
}
