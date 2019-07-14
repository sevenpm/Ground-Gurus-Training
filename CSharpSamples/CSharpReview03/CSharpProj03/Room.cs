using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProj03
{
    class Room : HotelBaseClass
    {
        // Data Type
        public string RoomName { get; set; }
        public decimal Rate { get; set; }
        public int Bed { get; set; }

        public void HotelInfo()
        {
            Console.Write("This is the info of hotel!");
            Console.ReadKey();
        }

        public decimal HotelRate()
        {
            Rate = 2000.50m; // m  military decimal
            return Rate;
        }

        public decimal HotelRate(int day) // Polymorphism
        {
            var total = ComputeRate(day); // var not string, not decimal, not int, means no specific type
            return total;
        }

        public string SayMyName(string name)
        {
            return name;
        }

        private decimal ComputeRate(int day) // Encapsulation
        {
            Rate = 2000.50m;
            var total = Rate * day;
            return total;
        }
    }
}
