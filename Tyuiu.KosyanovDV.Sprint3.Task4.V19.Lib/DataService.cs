using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KosyanovDV.Sprint3.Task4.V19.Lib
{
    public class DataService : ISprint3Task4V19
    {
        public double Calculate(int startValue, int stopValue)
        {
            double mult = 1;
            int i = 0;
            for (int x = startValue; x<=stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    mult = mult * ((x/(Math.Cos(x)+x))+0.5);
                }
            }
            return Math.Round(mult, 3);
        }
    }
}
