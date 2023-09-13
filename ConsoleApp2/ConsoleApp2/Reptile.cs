using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp2
{
    internal class Reptilel : Animal,IReptile
    {
        protected int lengthOfTail;

        public Reptilel(int calories, int age, bool isPreadtor, string name, int lengthOfTail) :
            base(calories, age, isPreadtor, name) 
        {
            this.lengthOfTail = lengthOfTail;
        }
        public int getLength() { return lengthOfTail; }
        public void setLength(int length) { lengthOfTail = length; }
        
        public void crawl()
        {
            Console.WriteLine("3---0-");
                                 
        }
        public void temp()
        {
            Console.WriteLine("you good to go");
        }
        public void defend()
        {
            Console.WriteLine("☺2☻");
        }
    }
    
}
