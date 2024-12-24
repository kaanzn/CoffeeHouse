using System.Runtime.ConstrainedExecution;

//When adding a new item to the menu, it should not need a barista parameter
//When making a drink, it should ask for the type instead of a string

namespace CoffeeHouse
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Creating a new Coffee House!");
            CoffeeHouse pakari = new("Pakari");

            Console.WriteLine("Creating some baristas!");
            Barista irmak = new("Irmak", "001");
            Barista kaan = new("Kaan", "002");
            Barista ege = new("Ege", "003");

            Console.WriteLine("Adding some items to the Menu!");
            pakari.AddMenuItem("Americano", 5.00m, irmak);
            pakari.AddMenuItem("Cappucino", 7.50m, kaan);
            pakari.AddMenuItem("Latte", 8.50m, ege);

            Console.WriteLine("Showing the menu!");
            pakari.ShowMenu();

            Console.WriteLine("Making some drinks!");
            pakari.MakeDrink("Americano", Drink.MilkType.NoMilk, ege);
            pakari.MakeDrink("Cappucino", Drink.MilkType.Almond, irmak);
            pakari.MakeDrink("Latte", Drink.MilkType.Coconut, kaan);
        }
    }
}