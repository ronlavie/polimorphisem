using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Snake:Reptilel
    {
        protected bool isVenomes;

        public Snake(int calories, int age, bool isPreadtor, string name, int lengthOfTail,bool isVenomes) :
            base(calories, age, isPreadtor, name,lengthOfTail)
        {
            this.isVenomes = isVenomes;
        }
        
        public bool getIsvenomes() {  return isVenomes; }
        public void setIsvenomes(bool venomes) {this.isVenomes=venomes;}

        public void dance()
        {
            Console.WriteLine("\0/");
        }
    }
}
