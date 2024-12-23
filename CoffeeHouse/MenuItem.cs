namespace CoffeeHouse
{
    internal class MenuItem
    {
        internal string Name { get; private set; }
        internal decimal Price { get; private set; }

        internal MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}