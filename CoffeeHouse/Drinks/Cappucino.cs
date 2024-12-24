namespace CoffeeHouse
{
    internal class Cappucino : Drink
    {
        internal bool ExtraShot;
        internal Cappucino(string name, decimal price, Barista barista, MilkType milkType, bool extraShot) : base(name, price, barista, milkType)
        {
            ExtraShot = extraShot;
            if (ExtraShot)
            {
                Price += 3.00m;
            }
        }
        internal override string GetInfo()
        {
            return $"{base.GetInfo()}\nExtra Shot: {ExtraShot}";
        }
    }
}