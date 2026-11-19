using ContosoApi.Dtos;
using ContosoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController(ICalculatorService calculatorService) : ControllerBase
    {
        [HttpGet("validate-age")]
        public ActionResult<bool> ValidateStudentAge([FromQuery] StudentAgeDto studentAgeDto)
        {
            return calculatorService.HasMinimumAge(studentAgeDto.Age);
        }
    }
}
