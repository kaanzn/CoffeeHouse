namespace CoffeeHouse
{
    internal class Latte : Drink
    {
        internal Latte(string name, decimal price, Barista barista, MilkType milkType) : base(name, price, barista, milkType)
        {
            if ( milkType == MilkType.Almond || milkType == MilkType.Coconut || milkType == MilkType.Soy)
            {
                Price += 5.00m;
            }
        }
    }
}