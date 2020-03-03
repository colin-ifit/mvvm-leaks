namespace LeakCanaryTest.Services.Calcs
{
    public interface ICalculationService
    {
        double TipAmount(double subTotal, int generosity);
    }
}