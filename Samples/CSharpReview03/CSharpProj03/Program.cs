using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProj03
{
    class Program
    {
        // static iRoom room;
        static Room room;

        static Program()
        {
            room = new Room();
        }

        static void Main(string[] args)
        {
            // Instantiate "room" object
            // Room room = new Room();
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
            Console.WriteLine();
            //OOP
            int day = 5;
            Console.WriteLine("Total Bill for " + day + " days is " + room.HotelRate(day));
            Console.ReadKey();
        }
    }
}
