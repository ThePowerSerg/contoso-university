using ContosoApi.Models;
namespace ContosoApi.Services;

public interface ICalculatorService
{
    int Add(int x, int y);
    int Subtract(int x, int y);
    double Average(int[] values);
    
    // use Student DTO for the service
    bool HasMinimumAge(Student age);
}