using Newtonsoft.Json;
using RemadeRestaurant.Entities;
using RemadeRestaurant.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace RemadeRestaurant.OrderRegistration
{
    public class CheckIfTableIsBusy : GenericRepository<Tables>
    {
        string jsonTables = @"D:\CodeAcademy\Back End\Egzas\RemadeRestaurant\RemadeRestaurant\Json\Tables.json";
        int input = 0;

        public string EditTableProperties()
        {
            using (StreamReader sr = new StreamReader(jsonTables))
            {
                string table = sr.ReadToEnd();
                var listOfTables = JsonConvert.DeserializeObject<List<Tables>>(table);

                foreach (var item in listOfTables)
                {
                    Console.WriteLine($"id {item.Id} size {item.Size} Busyness {item.Busyness}");
                }

                Console.WriteLine("Enter table Id: ");
                int tableIdFromInput = int.Parse(Console.ReadLine().Trim());

                ValidateInput.Validate(tableIdFromInput);

                input = tableIdFromInput;
                var listOfTablesFromInput = listOfTables.Where(obj => obj.Id == tableIdFromInput).ToList();

                foreach (var tab in listOfTables)
                {
                    if (tableIdFromInput == tab.Id)
                    {
                        if (tab.Busyness == false)
                        {
                            listOfTablesFromInput.ForEach(obj => obj.Busyness = true);

                            Console.WriteLine("Enter waiter Id: ");
                            int waiterIdFromInput = int.Parse(Console.ReadLine().Trim());

                            if (waiterIdFromInput != null)
                            {
                                listOfTablesFromInput.ForEach(obj => obj.WaiterId = waiterIdFromInput);
                            }

                            listOfTablesFromInput.ForEach(obj => obj.ChequeId += 1);
                            listOfTablesFromInput.ForEach(obj => obj.OrderId += 1);
                            break;
                        }
                        else
                        {
                            var init = new Initialize();
                            Console.WriteLine($"Table {tableIdFromInput} is busy, try other one");
                            init.Init();
                        }
                    }
                }

                string outputToFile = JsonConvert.SerializeObject(listOfTables, Formatting.Indented);
                return outputToFile;
            }
        }
        public void WriteToFile()
        {
            File.WriteAllText(jsonTables, EditTableProperties());

            var order = new GetOrderFromCustomer();
            order.FormAnOrder(input);
        }
    }
}

