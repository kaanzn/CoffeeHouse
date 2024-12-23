using System.Runtime.CompilerServices;

namespace CoffeeHouse
{
    public class CoffeeHouse
    {
        public string Name { get; set; }
        private List<Drink> drinksMade;
        private List<MenuItem> menuItems;

        public CoffeeHouse(string name)
        {
            Name = name;
            drinksMade = new();
            menuItems = new();
        }

        public void AddMenuItem(string name, decimal price)
        {
            MenuItem newItem = new(name, price);
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
            foreach (Drink drink in drinksMade)
            {
                Console.WriteLine($"{drink.GetInfo()}");
            }
        }
        internal Drink? MakeDrink(string menuItemName, Barista barista)
        {
            foreach(MenuItem item in menuItems)
            {
                if(item.Name == menuItemName)
                {
                    Drink newDrink = new Drink(item, barista);
                    drinksMade.Add(newDrink);
                    return newDrink;
                }
            }
            return null;
        }

    }
}