using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SavchenkoEI.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            n += 1;
            if (n == 0)
            {
                m += 1;
                switch (m)
                {
                    case 1: n = 31; break;
                    case 2: n = 28; break;
                    case 3: n = 31; break;
                    case 4: n = 30; break;
                    case 5: n = 31; break;
                    case 6: n = 30; break;
                    case 7: n = 31; break;
                    case 8: n = 31; break;
                    case 9: n = 30; break;
                    case 10: n = 31; break;
                    case 11: n = 30; break;
                    case 12: n = 31; break;
                    default: throw new ArgumentException("Число должно быть от 1 до 30");
                }
            }
            switch (m)
            {
                case 1: return $"0{n}.0{m}.{g}";
                case 2: return $"0{n}.0{m}.{g}";
                case 3: return $"0{n}.0{m}.{g}"; ;
                case 4: return $"0{n}.0{m}.{g}";
                case 5: return $"0{n}.0{m}.{g}";
                case 6: return $"0{n}.0{m}.{g}";
                case 7: return $"0{n}.0{m}.{g}";
                case 8: return $"0{n}.0{m}.{g}";
                case 9: return $"0{n}.0{m}.{g}"; ;
                case 10: return $"{n}.{m}.{g}"; ;
                case 11: return $"{n}.{m}.{g}";
                case 12: return $"{n}.{m}.{g}";
                default: throw new ArgumentException("Месяц должен быть от 1 до 12");
            }
        }
    }
}
