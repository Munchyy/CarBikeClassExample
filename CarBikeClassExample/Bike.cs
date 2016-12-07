using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBikeClassExample
{
    class Bike
    {
        private int wheelNumber;
        public string model;
        public string colour;
        public List<char> gears;

        public Bike(string colour, string model)
        {
            gears = new List<char>(new char[]{ 'N','1','2','3','4'});
            wheelNumber = 2;
            this.model = model;
            this.colour = colour;
        }

        public string Drive(int speed)
        {
            if (speed > 40)
            {
                return "VROOM VRROOOOM";
            }
            else
                return "vroom...";
        }

        public string Horn()
        {
            return "beep beep";
        }
    }
}
