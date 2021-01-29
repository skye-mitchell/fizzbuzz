using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int num) 
        {
            if (IsMultipleOf5(num)) 
            {
                return "Fizz";
            }
            if (IsMultipleOf5(num)) 
            {
                return "Buzz";
            }
            return num.ToString();
        }
        private bool IsMultipleOf5(int numberToCheck) 
        {
            return numberToCheck % 3 == 0;
        }
    }
}
