using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_1
{
    internal class Boat
    {
        public int number { get; set; }
        public double weight { get; set; }
        public int power { get; set; }
        public double length { get; set; }
        public double rent { get; set; }

        public Boat(int number, double weight, int power, double length, double rent)
        {
            this.number = number;
            this.weight = weight;
            this.power = power;
            this.length = length;
            this.rent = rent;
        }

    }
}
