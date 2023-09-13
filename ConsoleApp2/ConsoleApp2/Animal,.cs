using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Animal
    {
        protected string name;
        protected int age;
        protected bool isPreadtor;
        protected int calories;

        public Animal(int calories, int age,bool isPreadtor,string name)
        {
            this.name = name;
            this.age = age;
            this.calories = calories;
            this.isPreadtor = isPreadtor;
        }
        public int getAge() { return age; }
        public void setAge(int age) {  this.age = age; }
        public string getName() { return name; }
        public void setName(string name) { this.name = name;}
        public bool getIsPred() {  return isPreadtor; }
        public void setIspred(bool ispred) {  isPreadtor = ispred; }

        public int Eat()
        { return calories * 3 ; }

    }
    
}
