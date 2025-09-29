namespace DesignPattern.Builder.BuilderPattern
{
    public class Burger
    {
        public string Bread { get; set; }
        public string Meat { get; set; }
        public string Cheese { get; set; }
        public string Sauce { get; set; }

        public void ShowBurger()
        {
            Console.WriteLine($"Burger: {Bread}, {Meat}, {Cheese}, {Sauce}");
        }
    }
}
