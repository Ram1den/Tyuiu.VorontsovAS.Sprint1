using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VorontsovAS.Sprint1.Task4.V27.Lib
{
    public class DataService : ISprint1Task4V27
    {
        public double Calculate(double x, double y)
        {
            double z = (1.0 + Math.Sin(x * Math.PI)) / (x - Math.Sqrt(y));
            return Math.Round(z, 3);
        }
    }
}
