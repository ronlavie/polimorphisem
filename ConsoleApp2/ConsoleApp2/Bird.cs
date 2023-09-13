using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bird:Animal
    {
        protected int high;
        protected int wingspan;

        public Bird(int calories, int age, bool isPreadtor, string name, int high, int wingspan) :
            base(calories, age, isPreadtor, name)
        {
            this.high = high;
            this.wingspan = wingspan;
        }
        public int getHigh() { return  high; }
        public int getWingspan() { return wingspan; }
        public void setHigh(int high) { this.high = high;}
        public void setwingspan(int wingspan) { this.wingspan = wingspan;}
        public string sing()
        {
            return ("kokokokykykyky");
        }
        public void dance()
        {
            Console.WriteLine("\0/");
        }
    }
}
