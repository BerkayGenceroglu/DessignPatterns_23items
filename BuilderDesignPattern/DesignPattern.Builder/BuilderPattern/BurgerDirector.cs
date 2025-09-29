namespace DesignPattern.Builder.BuilderPattern
{
    public class BurgerDirector
    {
        private readonly IBurgerBuilder _burgerBuilder;

        public BurgerDirector(IBurgerBuilder burgerBuilder)
        {
            _burgerBuilder = burgerBuilder;
        }
        public void CreateBurger()
        {
            _burgerBuilder.SetMeat();
            _burgerBuilder.SetCheese();
            _burgerBuilder.SetBread();
            _burgerBuilder.SetSauce();
            _burgerBuilder.GetBurger();
        }
    }
}
