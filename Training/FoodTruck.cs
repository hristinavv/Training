using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Training
{
    internal class FoodTruck
    {

       public List<(string Name, decimal Quantity)> MenuList { get; set; }


        public string Owner { get; set; }

        public decimal Capacity { get; set; }
        public decimal ContainingAmount
        {
            get
            {
                var Amount = 0.0;
                Amount = ItemList.Sum(li => li.Quantity);
               // foreach (var Item in ItemList)
               // {
              //      Amount += Item.Quantity;
                //}
                return (decimal) Amount;
            }
        }
        public decimal Fullness
        {
            get
            {
                return ContainingAmount / Capacity * 100;
            }
        }

        public List<(string, decimal)> ItemList { get; private set; }

        public FoodTruck()
        {
            List<string> MenuList = new List<string>();
        }
        public FoodTruck(string owner, decimal capacity)
        {
            Owner = owner;
            Capacity = capacity;
        }
        private void InitItemList()
        {
            ItemList = new List<(string, decimal)>();
        }
           
 
        public void AddItem(string item, decimal quantity)
        {
            var ListItem = (item, quantity);
            MenuList.Add(((string Name, int Quantity))ListItem);
        }
        public void PrintTruckContents()
        {
            Console.WriteLine("${Owner}'s food truck has:");
            foreach (var item in MenuList)
           
                Console.WriteLine(item);
            }
        }
    }



    

