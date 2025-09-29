namespace DesignPattern.TemplateMethod.TemplatePattern
{
    public class BasicPlan : NetflixPlans
    {
        public override string Content(string content)
        {
            return "Ücretsiz";
        }

        public override int CountPerson(int countPerson)
        {
            return 20;
        }

        public override string PlanType(string plantype)
        {
            return "Basic";
        }

        public override double Price(double price)
        {
            return 150;
        }

        public override string Resolution(string resolution)
        {
           return "480p";
        }
    }
}
