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
            if (animal.Size > CheckForCarnivoreRisk() && (int)animal.Size <= WagonSpace)
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

        public Animal.Sizes CheckForCarnivoreRisk()
        {
            List<Animal> Carnivores = Animals.Where(Animals => Animals.IsCarnivore)
                                             .OrderByDescending(Animal => Animal.IsCarnivore)
                                             .ThenByDescending(Animal => (int)Animal.Size)
                                             .ToList();

            if (Carnivores.Count != 0)
            {
                return Carnivores.First().Size;
            }
            else 
            {
                return Animal.Sizes.none;
            }

        }
    }
}