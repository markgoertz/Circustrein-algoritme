using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_algoritme
{
    class Train
    {
       public List<Wagon> AnimalWagons = new List<Wagon>();
        public Wagon NewAnimalWagon(Animal animal)
        {
            Wagon NewAnimalWagon = new Wagon();
            NewAnimalWagon.TryAddAnimal(animal);
            AnimalWagons.Add(NewAnimalWagon);
            return NewAnimalWagon;
        }

        public void FillWagon(List<Animal> Animal)
        {
            AnimalCollection animalcollection = new AnimalCollection();

            Animal = animalcollection.SortAnimals(Animal);
            foreach (Animal SelectedAnimal in Animal)
            {
                if (SelectedAnimal.IsCarnivore)  
                {
                    NewAnimalWagon(SelectedAnimal);
                }
                else
                {
                    bool AnimalHasPlace = false;

                    foreach (Wagon SelectedWagon in AnimalWagons)
                    {
                        AnimalHasPlace = SelectedWagon.TryAddAnimal(SelectedAnimal);
                        if (AnimalHasPlace) break;
                    }

                    if (!AnimalHasPlace)
                    {
                        NewAnimalWagon(SelectedAnimal);
                    }
                }
            }
        }
    }
}
