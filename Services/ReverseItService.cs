using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSevenEndPoints.Services
{
    public class ReverseItService
    {
        public string ReverseIt(string enterToReverse)
        {
            
            string reversed = new string(enterToReverse.Reverse().ToArray());
            return $"You entered {enterToReverse}, reversed is {reversed}";

            /*  in depth code --- 
                char[] reversedChar = new char[enterToReverse.Length];
                for(int i = 0; i < enterToReverse.Length; i++)
                {
                    reversedChar[i] = enterToReverse[enterToReverse.Length - 1 - i];
                }
                return new string(reversedChar);
            */
        }
    }
}