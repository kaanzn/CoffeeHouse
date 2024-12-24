namespace CoffeeHouse
{
    internal class Drink : MenuItem
    {
        internal enum MilkType {Whole, LowFat, NoFat, Almond, Soy, Coconut, NoMilk}
        internal MilkType Milk;
        internal DateTime TimeStamp { get; }

        internal Drink(string name, decimal price, Barista barista, MilkType milkType) : base(name, price, barista)
        {
            TimeStamp = DateTime.Now;
            Milk = milkType;
        }

        internal override string GetInfo()
        {
            
            return $"{base.GetInfo()} at {TimeStamp}\nMilk Type: {Milk}";
        }
    }
}