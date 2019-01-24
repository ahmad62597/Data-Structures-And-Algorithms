using System;
using StackAndQueue.Classes;
using System.Text;

namespace FifoAnimalShelter.Classes
{
    public class AnimalShelter
    {
        //Create a queue for each animal type
        public Queue Cats = new Queue(null);
        public Queue Dogs = new Queue(null);
        public Queue OtherAnimals = new Queue(null);

  
        // Adds a new Cat, Dog, or other animal to the Shelter
        public void Enqueue(Animal animal)
        {
            if (animal is Cat) Cats.Enqueue(new Node(animal));
            else if (animal is Dog) Dogs.Enqueue(new Node(animal));
            else OtherAnimals.Enqueue(new Node(animal));
        }


        
        // Returns earliest Cat or Dog (depending on pref) in the queue.
        public Animal Dequeue(string pref)
        {
            if (pref.ToLower() == "cat")
            {
                if (Cats.Peek() == null) return null;
                return (Cat)Cats.Dequeue().Value;
            }
            else if (pref.ToLower() == "dog")
            {
                if (Dogs.Peek() == null) return null;
                return (Dog)Dogs.Dequeue().Value;
            }
            else
            {
                if (OtherAnimals.Peek() == null) return null;
                else return (Animal)OtherAnimals.Dequeue().Value;
            }
        }
    }
}