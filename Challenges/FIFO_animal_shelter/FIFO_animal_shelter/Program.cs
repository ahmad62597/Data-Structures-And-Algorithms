using FifoAnimalShelter.Classes;
using System;

namespace FifoAnimalShelter
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the animal shelter!");
            FIFOAnimalShelter();
        }

        public static void FIFOAnimalShelter()
        {
            //Create animal shelter
            Console.WriteLine("Preparing the shelter...\n\n");
            AnimalShelter myShelter = new AnimalShelter();

            //Add cat
            Console.WriteLine("A cat has just been placed for adoption.");
            myShelter.Enqueue(new Cat("Billy"));

            //Add dog
            Console.WriteLine("A dog named Pupper has just been placed for adoption.");
            myShelter.Enqueue(new Dog("Pupper"));
            Console.WriteLine("Another dog named Bopper has just been placed for adoption.");
            myShelter.Enqueue(new Dog("Bopper"));

            //Add "Animal"
            Console.WriteLine("Another animal has been put for adoption.");
            myShelter.Enqueue(new Animal());

            //Request dog
            Console.WriteLine("I want to adopt a dog please");
            Dog myDog = (Dog)myShelter.Dequeue("dog");
            Console.WriteLine($"Here's your new dog, his name is: {myDog.Name}");
        }
    }
}
