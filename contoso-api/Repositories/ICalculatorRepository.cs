using ContosoApi.Models;
namespace ContosoApi.Repositories;

public interface ICalculatorRepository
{
    int Add(int x, int y);
    int Subtract(int x, int y);
    double Average(int[] values);
    bool HasMinimumAge(Student student);
}
