using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.KarpenkoAL.Sprint6.Task2.V28.Lib
{
    public class DataService : ISprint6Task2V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double b = (3 * x) - 1;
                if (Math.Abs(b) < 1e-10)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    y = Math.Round(((Math.Sin(x) - (2 * x)) / ((3 * x) - 1)) + Math.Sin(x) - (3 * x) + 2, 2);
                    valueArray[count] = y;
                }
                count++;
            }
            return valueArray;
        }
    }
}
