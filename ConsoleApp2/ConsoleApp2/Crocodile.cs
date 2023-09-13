using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Crocodile:Reptilel
    {
        protected bool isTeethFix;

        public Crocodile(int calories, int age, bool isPreadtor, string name, bool isTeethFix ,int lengthOfTail) :
        base(calories, age, isPreadtor, name,lengthOfTail)
        {
            this.isTeethFix  = isTeethFix;
        }
        public bool getisteethfix() { return isTeethFix; }
        public void setfat(bool isTeethFix) { this.isTeethFix = isTeethFix; }
    }
}
