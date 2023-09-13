using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cobra:Snake
    {
        protected int teethLength;

        public Cobra(int calories, int age, bool isPreadtor, string name, int lengthOfTail, bool isVenomes,int teethLength) :
            base(calories, age, isPreadtor, name, lengthOfTail, isVenomes)
        {
            this.teethLength = teethLength;
        }
        public void setTeethLen(int teethlength) { this.teethLength = teethlength; }
        public int getTeethLen() { return teethLength; }
    }
}
