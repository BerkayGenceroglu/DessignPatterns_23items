namespace DesignPattern.Builder.BuilderPattern
{
    public class CheeseBurgerBuilder:IBurgerBuilder
    {
        private Burger _burger = new Burger();

        public void SetBread()
        {
            _burger.Bread = "Somon Ekmeği";
        }

        public void SetCheese()
        {
            _burger.Cheese = "Cheddar Peyniri";
        }

        public void SetMeat()
        {
            _burger.Meat = "Dana Köftesi";
        }

        public void SetSauce()
        {
            _burger.Sauce = "Barbekü Sosu";
        }
        public Burger GetBurger()
        {
            return _burger;
        }

    }
}
