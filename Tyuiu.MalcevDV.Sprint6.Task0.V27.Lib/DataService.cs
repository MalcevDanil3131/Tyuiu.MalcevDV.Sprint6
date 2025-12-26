using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MalcevDV.Sprint6.Task0.V27.Lib
{
    public class DataService : ISprint6Task0V27
    {
        public double Calculate(int x)
        {
            return (-x * x * x) + (4 * x * x) - (3.0 / 2 * x);
        }
    }
}
