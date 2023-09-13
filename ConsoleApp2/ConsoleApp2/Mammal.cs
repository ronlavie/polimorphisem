using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Mammal: Animal
    {
        protected int month;
        protected int milkCalories;

        public Mammal(int calories, int age, bool isPreadtor, string name,int month, int milkCalories):
            base( calories,  age,  isPreadtor,  name)
        {
            this.month = month;
            this.milkCalories = milkCalories;

        }
        public new int eat()
        {
            return base.Eat() + milkCalories;
        }
    }
}
