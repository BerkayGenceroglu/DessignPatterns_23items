namespace DesignPatterns.Prototype.PrototypePattern
{
    public class Enemy : IPrototype<Enemy>
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Enemy(string name, int health)
        {
            Name = name;
            Health = health;
        }

        // Klonlama işlemi
        public Enemy Clone()
        {
            return new Enemy(Name, Health);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Düşman: {Name}, Can: {Health}");
        }
    }
}
