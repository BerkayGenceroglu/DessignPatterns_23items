namespace DesignPattern.Builder.BuilderPattern
{
    public class KasapBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger = new Burger();
        public void SetBread()
        {
            _burger.Bread = "Çavdar Ekmeği";
        }

        public void SetCheese()
        {
            _burger.Cheese = "Tulum Peyniri";
        }

        public void SetMeat()
        {
            _burger.Meat = "Dana Antrikot";
        }

        public void SetSauce()
        {
            _burger.Sauce = "Hardal Sosu";
        }
        public Burger GetBurger()
        {
            return _burger;
        }

    }
}
