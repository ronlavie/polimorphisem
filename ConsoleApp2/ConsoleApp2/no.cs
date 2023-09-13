using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1_RonLavie
{
    internal class no
    {
        static void Main(string[] args)
        {
            Mammal[] mammals =
                {new Mammal(2000,10,true,"c1",5,351),
                new Mammal (2200,6,true,"h2",5,351),
                new Mammal(2000,10,false,"k1",5,351),
                new Mammal(2500,2,false,"d5",5,351),
                new Mammal(2000,4,true,"m1",5,351) };
            Animal[] animals =
            {
                new Animal(2000,10,true,"C1"),
                new Animal(2500,7,true,"B1"),
                new Animal(2000,10,true,"C2"),
                new Animal(2300,4,true,"B2"),
                new Animal(3000,10,true,"B3"),
                new Animal(3000,9,true,"B4"),
                new Animal(3000,10,true,"hippo1"),
                new Animal(1500,10,true,"E1")
            };
            Reptilel[] reptilels = {new Reptilel(1000,5,true,"s1",15),
                new Reptilel(1000, 5, true, "s1", 6),
                new Reptilel(1200, 2, true, "s2", 7),
                new Reptilel(1700, 5, true, "s3", 15),
                new Reptilel(1100, 3, true, "s4", 12), };


        }
        public static int food(Animal[] animal)
        {
            int food = 0;
            foreach (var item in animal)
            {
                food += item.Eat();
            }
            return food;
        }

        public static int mammlenum(Animal[] animal)
        {
            int mammlenum = 0;
            foreach (Animal item in animal)
            {
                if (item is Mammal)
                    mammlenum++;
            }
            return mammlenum;
        }
        public static void active(Animal[] animal)
        {
           ;
            foreach (Animal item in animal)
            {
                if (item is Bird|| item is Snake)
                {
                    
                }
                    
            }
          
        }
    }
}
