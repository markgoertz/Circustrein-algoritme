using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_algoritme
{
    public class Train
    {
        public List<Wagon> AnimalWagons = new List<Wagon>();
        private readonly AnimalCollection animalcollection = new AnimalCollection();
        public List<Wagon> GetWagons()
        {
            return AnimalWagons;
        }
        public Wagon NewAnimalWagon(Animal animal)
        {
            Wagon NewAnimalWagon = new Wagon();
            NewAnimalWagon.TryAddAnimal(animal);
            AnimalWagons.Add(NewAnimalWagon);
            return NewAnimalWagon;
        }

        public void FillWagon(List<Animal> Animal)
        {
            //Sort the parameter by IsCarnivore and then by Size and returns it back into a list.
            Animal = animalcollection.SortAnimals(Animal);

            //Takes out every individual animal from List(Animal) and checks the animal with the if/else statements.
            foreach (Animal SelectedAnimal in Animal)
            {
                //If the selected individual animal is a Carnivore. Then the method redirrect this animal to the method NewAnimalWagon.
                if (SelectedAnimal.IsCarnivore)
                {
                    NewAnimalWagon(SelectedAnimal);
                }

                //The selected individual Animal is a herbivore. 
                else
                {
                    bool InWagonFitsAnimal = false;

                    foreach (Wagon SelectedWagon in AnimalWagons)
                    {
                        InWagonFitsAnimal = SelectedWagon.TryAddAnimal(SelectedAnimal);
                        if (InWagonFitsAnimal) break;
                    }

                    if (!InWagonFitsAnimal)
                    {
                        NewAnimalWagon(SelectedAnimal);
                    }
                }
            }
        }
    }
}