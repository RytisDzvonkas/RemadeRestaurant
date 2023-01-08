using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemadeRestaurant.OrderRegistration
{
    public class Initialize
    {
        public void Init()
        {
            var tableBusyness = new CheckIfTableIsBusy();
            var ordering = new GetOrderFromCustomer();

            tableBusyness.EditTableProperties();


            while (true)
            {

                //Console.Clear();

                //reikia dadeti pasirinkimu tokiu kaip "Go Back", "Update order" ir pan.

                Console.WriteLine("Select: ");
                Console.WriteLine("1. food");
                Console.WriteLine("2. drinks");
                Console.WriteLine("3. exit the program");
                var inputSelected = int.Parse(Console.ReadLine());

                if (inputSelected == 1)
                {
                    ordering.GetFoodFromInput();
                    tableBusyness.WriteToFile();
                }
                if (inputSelected == 2)
                {
                    ordering.GetDrinksFromInput();
                    tableBusyness.WriteToFile();
                }
                if (inputSelected == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose valid menu button");
                    Init();
                }

                Console.WriteLine(inputSelected);
                Console.ReadLine();

            }
        }
    }
}

