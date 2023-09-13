using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Eagle:Bird
    {
        protected string featherColor;

        public Eagle(int calories, int age, bool isPreadtor, string name, int high, int wingspan,string feathercolor) :
            base(calories, age, isPreadtor, name, wingspan, high)
        {
            this.featherColor = feathercolor;

        }
        public string getFeatherColor() { return featherColor; }
        public void setFeatherColor(string feathercolor) {this.featherColor = feathercolor; }
    }
}
