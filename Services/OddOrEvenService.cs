using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace FiveToSevenEndPoints.Services
{
    public class OddOrEvenService
    {
        public string OddOrEven(int enterNumber)
        {
            if(enterNumber % 2 == 0)
            {
                string even = $"{enterNumber} is even!";
                return even;
            } 
            else 
            {
                string odd = $"{enterNumber} is odd!";
                return odd;
            }
        }
    }
}