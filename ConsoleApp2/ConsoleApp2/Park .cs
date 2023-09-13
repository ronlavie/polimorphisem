using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Park
    {
        protected Animal[] animals;
        protected int numOfAnimals;

        public Park()
        {
            animals = new Animal[500];
            numOfAnimals = 0;
        }

        public void AddAnimal(Animal animal)
        {
            for(int i = 0; i < animals.Length; i++)
            {
                if (animals[i] == null)
                {
                    numOfAnimals++;
                    animals[i] = animal;
                    return;
                }
            }
        }

        public List<Animal> OldPrepatorOn()
        {
            List<Animal> oldPrepatorOn = new List<Animal>();

            foreach(Animal animal in animals)
            {
                if(animal.getIsPred() && animal.getAge() > 10)
                {
                    oldPrepatorOn.Add(animal);
                }
            }

            return oldPrepatorOn;
        }

        public List<Animal> OldReptilesBird()
        {
            List<Animal> oldReptileBird = new List<Animal>();

            foreach (Animal animal in animals)
            {
                if (animal.getIsPred() && (animal is Reptilel || animal is Bird) && animal.getAge() > 10)
                {
                    oldReptileBird.Add(animal);
                }
            }

            return oldReptileBird;
        }
    }
}
