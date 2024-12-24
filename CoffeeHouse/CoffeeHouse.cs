using System.Runtime.CompilerServices;

namespace CoffeeHouse
{
    public class CoffeeHouse
    {
        public string Name { get; set; }
        private List<MenuItem> menuItems;

        public CoffeeHouse(string name)
        {
            Name = name;
            menuItems = new();
        }

        public void AddMenuItem(string name, decimal price, Barista barista)
        {
            MenuItem newItem = new(name, price, barista);
            menuItems.Add(newItem);
        }
        public void ShowMenu()
        {
            Console.WriteLine($"-------- {Name} Menu --------");
            foreach(MenuItem item in menuItems)
            {
                Console.WriteLine($"Name: {item.Name} // Price: {item.Price:C}");
            }
        }
        public void ShowDrinksMade()
        {
            Console.WriteLine("Drinks Made");
            foreach (MenuItem item in menuItems)
            {
                if (item is Drink)
                {
                    Console.WriteLine($"{item.GetInfo()}");
                }
            }
        }
        internal Drink? MakeDrink(string menuItemName, Drink.MilkType milkType, Barista barista)
        {
            foreach(MenuItem item in menuItems)
            {
                if(item.Name == menuItemName)
                {
                    Drink newDrink = new(menuItemName, item.Price, item.MadeBy, milkType);
                    Console.WriteLine($"{newDrink.GetInfo()}");
                    return newDrink;
                }
            }
            return null;
        }

    }
}