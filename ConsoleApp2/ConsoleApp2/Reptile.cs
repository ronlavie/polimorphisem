using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp2
{
    internal class Reptilel : Animal
    {
        protected int lengthOfTail;

        public Reptilel(int calories, int age, bool isPreadtor, string name, int lengthOfTail) :
            base(calories, age, isPreadtor, name) 
        {
            this.lengthOfTail = lengthOfTail;
        }
        public int getLength() { return lengthOfTail; }
        public void setLength(int length) { lengthOfTail = length; }
    }
}
