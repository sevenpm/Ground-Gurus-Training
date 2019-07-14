using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProj02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate "room" object
            Room room = new Room();
            room.HotelInfo();
            Console.WriteLine();
            // Get rate
            decimal rate = room.HotelRate();
            Console.Write("Room rate : " + rate);
            Console.ReadKey();
            Console.WriteLine();
            // Method with parameter
            Console.Write("Hello " + room.SayMyName("Seven") + "!");
            Console.ReadKey();
        }
    }
}
