using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VorontsovAS.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            double z = (Math.Sqrt(((x1 - y1) * (x1 - y1)) + ((x2 - y2) * (x2 - y2))));
            int g = Convert.ToInt32(z);
            return g;
        }
    }
}
