using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VorontsovAS.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            number -= Convert.ToInt32(number);
            string num = Convert.ToString(number);
            num = num[2..5];
            return num.Contains("0");
        }
    }
}