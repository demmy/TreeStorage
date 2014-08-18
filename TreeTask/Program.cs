using System;
using System.Collections.Generic;
using Abstract;
using TreeStorage;

namespace TreeTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
          ITree<Person> p1 = new Tree<Person>();

            p1.Data = new Person(){Name = "John"};
            var p2 = p1.AddChild(new Person() {Name = "Mary"});
            var p3 = p2.AddChild(new Person() {Name = "Jane"});

            foreach (var person in p1)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine("--------------");
            foreach (var person in p2)
            {
                Console.WriteLine(person.Name);
            }





        }
    }


}