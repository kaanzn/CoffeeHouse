namespace CoffeeHouse
{
    internal class Drink
    {
        internal MenuItem MenuItem { get; private set; }
        public Barista MadeBy { get; private set; }
        public DateTime TimeStamp { get; private set; }

        internal Drink(MenuItem menuItem, Barista barista)
        {
            MenuItem = menuItem;
            MadeBy = barista;
            TimeStamp = DateTime.Now;
        }

        public string GetInfo()
        {
            return $"{MenuItem.Name} (Made By: {MadeBy.GetInfo()} at {TimeStamp})";
        }
    }
}