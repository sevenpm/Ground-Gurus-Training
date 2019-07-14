using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProj03
{
    public interface iRoom
    {
        void HotelInfo();
        decimal HotelRate();
        decimal HotelRate(int day);
        string SayMyName(string name);
        decimal ComputeRate(int day);
    }
}
