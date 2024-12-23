namespace CoffeeHouse
{
    public class Barista
    {
        public string Name { get; private set; }
        public string Id { get; private set; }

        public Barista(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string GetInfo()
        {
            return $"Name: {Name} ID: {Id}";
        }
    }
}