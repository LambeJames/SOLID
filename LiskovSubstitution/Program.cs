using System;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dog inherits from fish but is not substitutable for it as it displays different behaviour 
            Dog dave = new Dog();
            Console.WriteLine($"Dave the dog says {dave.Move()}");

            Fish frankie = new Dog();
            Console.WriteLine($"Frankie the fish says {frankie.Move()}");

            // By using a generic abstract base class, Fish and Bird classes are now substitutable for the base class
            Animal freddie = new Fish();
            Console.WriteLine($"Freddie the fish says {freddie.Move()}");

            Animal barry = new Bird();
            Console.WriteLine($"Barry the bird says {barry.Move()}");
        }
    }
}
