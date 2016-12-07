using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBikeClassExample
{
    class Car
    {
        public string model;
        public string colour;
        public List<char> gears;

        public Car(string colour, string model)
        {
            gears = new List<char>(new char[] { 'R', 'N', '1', '2', '3', '4', '5' });
            this.model = model;
            this.colour = colour;
        }

        public string Drive(int speed)
        {
            return "vroom...";
        }

        public string Reverse()
        {
            return "reversing";
        }

        public string Horn()
        {
            return "honk honk";
        }
    }
}
