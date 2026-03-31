using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SavchenkoEI.Sprint2.Task1.V25.Lib
{
    public class DataService : ISprint2Task1V25
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = ((a < d) | (b > d));
            res[1] = ((a < b) & (c > b));
            res[2] = ((a < c) || (d > c));
            res[3] = ((a > d) && (d < a));
            res[4] = !(!res[0]);
            res[5] = ((a > d) ^ (d < b));
            return res;
        }
    }
}
