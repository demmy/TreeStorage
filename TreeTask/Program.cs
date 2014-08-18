using System;
using Abstract;
using TreeStorage;

namespace TreeTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITree<Person> p1 = new Tree<Person>();

            p1.Data = new Person {Name = "John"};
            ITree<Person> p2 = p1.AddChild(new Person {Name = "Mary"});
            ITree<Person> p3 = p2.AddChild(new Person {Name = "Jane"});

            foreach (Person person in p1)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine("--------------");
            foreach (Person person in p2)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}