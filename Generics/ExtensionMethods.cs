using System;
using System.Collections.Generic;
using System.Linq;
namespace Generics
{
    public static class ExtensionMethods
    {
        
        //ExtensionMethods
        //TODO Create a static class called "ExtensionMethods"
        //TODO in your new class create a static extension method called "pluralize" this method should take a string and add an s to the end of it. (***BONUS*** if string ends in y you can replace y with ies to pluralize it)

        //TODO Create an extension method called "SortArray". This method will take an array of type T. Then it will use a LINQ statement to OrderBy.
        //TODO call both extension methods in the Main. Use the method on the numbers Array.


        public static string Pluralize(this string x)
        {
            if (x[x.Length-1]=='y')
            {
                x = x.Remove(x.Length - 1);
                return x + "ies";
            }
            else
            {
                return x + "s";
            }
        }
        public static T[] SortArray<T>(this T[] array)
        {
            return array.OrderBy(x => x).ToArray();
        }

        public static void NumberPrinter<T>(this T A ) where T: IEnumerable<int>
        {
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
        }
    }
}
