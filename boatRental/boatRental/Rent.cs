using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_1
{
    internal class Rent
    {
        public long id { get; set; }
        public long boat { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public int usedFuel { get; set; }
        public DateTime rentDate { get; set; }
        public Boolean damage { get; set; }

        public Rent(long id, int boat, DateTime start, DateTime end, int usedFuel, DateTime rentDate, Boolean damage)
        {
            this.id = id;
            this.boat = boat;
            this.start = start;
            this.end = end;
            this.usedFuel = usedFuel;
            this.rentDate = rentDate;
            this.damage = damage;
        }

        public double getRevenue(double rentPrice)
        {
            return rentPrice + (this.usedFuel * 5);
        }

        public int calculateRentTime()
        {
            return Convert.ToInt32(this.end.Subtract(this.start).TotalMinutes);
        }

        public double calculateFuelUsage()
        {
            return this.usedFuel / this.calculateRentTime();
        }
    }
}
