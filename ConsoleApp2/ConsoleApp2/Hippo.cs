using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Hippo:Mammal
    {
        protected int fat;


        public Hippo(int calories, int age, bool isPreadtor, string name, int month, int milkCalories,int fat) :
            base(calories, age, isPreadtor, name, month, milkCalories)
        {
            this.fat = fat;
        }
        public int getfat() { return fat; }
        public void setfat(int fat) { this.fat = fat; }
    }
}
