using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VorontsovAS.Sprint1.Task2.V9.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            double v = 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
            return Math.Round(v, 3);
        }
    }
}
