using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ContosoApi.Dtos
{
    public class StudentAgeDto
    {
        [BindRequired]
        public int Age { get; set; }
    }
}
