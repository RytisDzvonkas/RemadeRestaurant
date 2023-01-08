using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemadeRestaurant.OrderRegistration
{
    public static class ValidateInput
    {
        public static int Validate(int optionsCount)
        {
            bool isCorrectInput = false;
            int argumentValue = 0;
            while (!isCorrectInput)
            {
                string userInputValue = Console.ReadLine();
                if (int.TryParse(userInputValue, out argumentValue) && argumentValue <= optionsCount && argumentValue != 0 && argumentValue > 0)
                {
                    isCorrectInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            return argumentValue;
        }
    }
}
