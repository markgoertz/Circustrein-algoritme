using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_algoritme
{
    public class Wagon
    {
        public List<Animal> Animals = new List<Animal>();
        public int WagonSpace { get; private set; } = 10;
        public bool TryAddAnimal(Animal animal)
        {
            if (animal.Size > BiggestCarnivore() && (int)animal.Size <= WagonSpace)
            {
                Animals.Add(animal);
                WagonSpace -= (int)animal.Size;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Animal.Sizes BiggestCarnivore()
        {
            List<Animal> Carnivores = Animals.Where(Animals => Animals.IsCarnivore).ToList();

            if (Carnivores.Count == 0)
            {
                return Animal.Sizes.none;
            }
            else
            {
                return Carnivores.First().Size;
            }
        }
    }
}