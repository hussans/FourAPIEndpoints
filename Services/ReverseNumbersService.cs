using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSevenEndPoints.Services
{
    public class ReverseNumbersService
    {
        public string ReverseNumbers(string reverseNumbers)
        {
            int enterNumbers;
            bool intTrue = int.TryParse(reverseNumbers, out enterNumbers);

            if(intTrue)
            {
                int reverseInt = 0;
                int originalNumbers = enterNumbers;
                while(enterNumbers > 0)
                {
                    reverseInt = reverseInt * 10 + enterNumbers % 10;
                    enterNumbers = enterNumbers / 10;
                }
                return $"You entered {originalNumbers}, reversed is {reverseInt}";
            }
            else
            {
                return "Please enter numbers.";
            }
        }
    }
}