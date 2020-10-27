using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_algoritme
{
    public class AnimalCollection
    {
        public List<Animal> animals = new List<Animal>();

        public List<Animal> SortAnimals(List<Animal> unorderAnimals)
        {
            return unorderAnimals.OrderByDescending(Animal => Animal.IsCarnivore)
                                    .ThenByDescending(Animal => (int)Animal.Size)
                                    .ToList();
        }
    }
}
