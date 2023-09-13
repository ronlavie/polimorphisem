using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cow:Mammal
    {
        protected int birthnum;

        public Cow(int calories, int age, bool isPreadtor, string name, int month, int milkCalories, int birthnum) :
            base(calories, age, isPreadtor, name, month, milkCalories)
        {
            this.birthnum = birthnum;
        }
        public int getBirthnum() { return birthnum; }
        public void setBirthnum(int birthnum) { this.birthnum = birthnum; }

        public new int eat()
        {
            return base.eat()/4;
        }

    }
}
