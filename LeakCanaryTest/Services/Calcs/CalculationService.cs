namespace LeakCanaryTest.Services.Calcs
{
    public class CalculationService : ICalculationService
    {
        public double TipAmount(double subTotal, int generosity)
        {
            return (generosity*subTotal)/100.0;
        }
    }
}