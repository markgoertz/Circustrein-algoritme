using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_algoritme
{
    public class Animal
    {
         public enum Sizes
         {
           small = 1,
           medium = 3,
           large = 5,
           none = 0
         }

         public Sizes Size;
         public bool IsCarnivore { get; private set; }

         public Animal(Sizes size, bool iscarnivore)
         {
           Size = size;
           IsCarnivore = iscarnivore;
         }

         public override string ToString()
         {
            string species;
            if (IsCarnivore)
            {
             species = "Carnivore";
            }
            else
            {
              species = "Herbivore";
            }
            return $"{species} + {Size}";
         }
    }
}

