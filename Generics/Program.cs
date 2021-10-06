using System;
using System.IO;

namespace Generics
{
    class Program
    {
        //Generics
        //TODO Create a class called "Storage" that has a generic Type "T". Set a constraint to for the type so that T must conform to IStorable.
        //TODO In your class create a property List called "Bin". Set the list type to "T".
        //TODO Create two more classes. One class called "Boxes". The second class called "Food". Both classes will conform to IStoreable interface.
        //TODO create two instances of type Storage in the Main method. First Instance will hold type "<Equipment>". The second instance will hold "<food>".
        //TODO create some instances of type Food and Equipment and Add them the correct storage bins.
       
        static void Main(string[] args)
        {            

            var food1 = new Food();
            var box1 = new Boxes();

            var food2 = new Food();
            var box2 = new Boxes();

            var foodStorage = new Storage<Food>(food1, food2);
            var boxStorage = new Storage<Boxes>(box1, box2);


            var numbers = new int[] {3, 7, 25, 6 };
            numbers = numbers.SortArray();
            numbers.NumberPrinter();
            //Console.WriteLine(numbers);

            string name = "almond";
            name = name.Pluralize();
            Console.WriteLine(name);

        }
      
      

        //ExtensionMethods
        //TODO Create a static class called "ExtensionMethods"
        //TODO in your new class create a static extension method called "pluralize" this method should take a string and add an s to the end of it. (***BONUS*** if string ends in y you can replace y with ies to pluralize it)

        //TODO Create an extension method called "SortArray". This method will take an array of type T. Then it will use a LINQ statement to OrderBy.
        //TODO call both extension methods in the Main. Use the method on the numbers Array.


    }
}
