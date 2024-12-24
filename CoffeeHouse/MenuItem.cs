namespace CoffeeHouse
{
    internal class MenuItem
    {
        internal string Name { get; private set; }
        internal decimal Price { get; set; }
        public Barista MadeBy { get; private set; }

        internal MenuItem(string name, decimal price, Barista barista)
        {
            Name = name;
            Price = price;
            MadeBy = barista;
        }
        internal virtual string GetInfo()
        {
            return $"{Name} -- {Price} (Made By: {MadeBy.GetInfo()})";
        }
    }
}