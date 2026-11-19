namespace ContosoApi.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => y - x;
        public double Average(int[] values)
        {
            int sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }

            return sum / values.Length;
        }

        public bool HasMinimumAge(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else return false;
        }
    }
}
