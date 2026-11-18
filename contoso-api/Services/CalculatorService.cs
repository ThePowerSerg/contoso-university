using ContosoApi.Models;
namespace ContosoApi.Services;

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

    // create a DTO for this part
    public bool HasMinimumAge(Student student)
    {
        if (student.Age >= 18)
        {
            return true;
        }
        else return false;
    }
}