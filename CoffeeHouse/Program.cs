using System.Runtime.ConstrainedExecution;

namespace CoffeeHouse
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Creating the coffee house!");
            CoffeeHouse coffeehouse = new("Pakari Coffee");

            System.Console.WriteLine("Adding Menu Items!");
            coffeehouse.AddMenuItem("Matcha Latte", 125.00m);
            coffeehouse.AddMenuItem("Cool Lime", 110.00m);
            coffeehouse.AddMenuItem("Americano", 90.00m);

            System.Console.WriteLine("Showing the Menu!");
            coffeehouse.ShowMenu();

            System.Console.WriteLine("Creating the Baristas!");
            Barista irmak = new("Irmak", "001");
            Barista kaan = new("Kaan", "002");
            Barista ege = new("Ege", "003");

            System.Console.WriteLine("Making Some Drinks!");
            coffeehouse.MakeDrink("Cool Lime", irmak);
            coffeehouse.MakeDrink("Matcha Latte", ege);
            coffeehouse.MakeDrink("Americano", kaan);

            System.Console.WriteLine("Showing All the Drinks Made!");
            coffeehouse.ShowDrinksMade();

        }
    }
}