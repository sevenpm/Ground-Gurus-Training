using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReviewProj01
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloEarth();
        }

        //Access Modifier - it will define the area or coverage of the method (where it can be accessed)
        //public / static / private (in oop you can make your data or functions secured)
        static void HelloEarth()
        {
            Console.WriteLine("Hello Seven!");
            Console.ReadKey();
        }
    }
}
