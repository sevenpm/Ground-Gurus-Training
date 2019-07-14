using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProj02
{
    class Room
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

        public string SayMyName(string name)
        {
            return name;
        }
    }
}
