using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Storage<T> where T : IStorable
    //TODO Create a class called "Storage" that has a generic Type "T".
    //Set a constraint to for the type so that T must conform to IStorable.
    {
        public Storage()
        {

        }
        
        public List<T> Bin { get; set; } = new List<T>();

          public Storage (params T[] bin)
        {
            foreach (var item in bin)
            {
                Bin.Add(item);
            }
        }



    }
}
