using Newtonsoft.Json;
using RemadeRestaurant.Entities;
using RemadeRestaurant.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemadeRestaurant.OrderRegistration
{
    public class GetOrderFromCustomer : GenericRepository<Tables>
    {
        //string jsonOrder = @"D:\CodeAcademy\Back End\Egzas\RemadeRestaurant\RemadeRestaurant\Json\Orders.json";
        string jsonTables = @"D:\CodeAcademy\Back End\Egzas\RemadeRestaurant\RemadeRestaurant\Json\Tables.json";

        public List<Product> GetFoodFromInput()
        {
            string foodPath = @"D:\CodeAcademy\Back End\Egzas\RemadeRestaurant\RemadeRestaurant\Json\Food.json";

            StreamReader srFood = new StreamReader(foodPath);
            string food = srFood.ReadToEnd();

            var listOfFood = JsonConvert.DeserializeObject<List<Food>>(food);

            Console.WriteLine("Select your food");
            foreach (var item in listOfFood)
            {
                Console.WriteLine($"Id {item.Id}, title {item.Title}, price {item.Price}");
            }

            List<Product> products = new List<Product>();


            var selectedFood = int.Parse(Console.ReadLine());

            ValidateInput.Validate(selectedFood);

            products.Add(listOfFood.Find(x => x.Id == selectedFood));

            return products;
        }
        public List<Product> GetDrinksFromInput()
        {
            string drinksPath = @"D:\CodeAcademy\Back End\Egzas\RemadeRestaurant\RemadeRestaurant\Json\Drinks.json";

            StreamReader srDrinks = new StreamReader(drinksPath);

            string drinks = srDrinks.ReadToEnd();
            var listOfDrinks = JsonConvert.DeserializeObject<List<Drinks>>(drinks);

            List<Product> products = new List<Product>();

            Console.WriteLine("Select your drinks");
            foreach (var item in listOfDrinks)
            {
                Console.WriteLine($"Id {item.Id}, title {item.Title}, price {item.Price}");
            }
            var selectedDrinks = int.Parse(Console.ReadLine());

            ValidateInput.Validate(selectedDrinks);

            products.Add(listOfDrinks.Find(x => x.Id == selectedDrinks));

            string outputToFile = JsonConvert.SerializeObject(products, Formatting.Indented);
            Console.WriteLine(outputToFile);

            return products;
        }

        public void FormAnOrder(int tableId)
        {
            StreamReader srTables = new StreamReader(jsonTables);

            string table = srTables.ReadToEnd();
            var listOfTables = JsonConvert.DeserializeObject<List<Tables>>(table);

            var orderStructure = listOfTables.Where(obj => obj.Id == tableId).ToList().Select(obj => new
            {
                obj.Id,
                obj.WaiterId,
                obj.OrderId,
                obj.ChequeId
            }).ToList();

            //reikia sujungti du listus
            //orderStructure.AddRange();
            var orderId = orderStructure[0].OrderId;
            //orderStructure[0] = GetDrinksFromInput();

            string outputToFile = JsonConvert.SerializeObject(orderStructure, Formatting.Indented);
            File.WriteAllText($@"D:\CodeAcademy\Back End\Egzas\RemadeRestaurant\RemadeRestaurant\Json\Orders{orderId}.json", outputToFile);
            //Console.WriteLine(outputToFile);


        }


    }
}
