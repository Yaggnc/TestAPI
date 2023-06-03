using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestClassController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TestClass>>> Get()
        {
            var testObjects = new List<TestClass> 
            {
                new TestClass{Id=1,FirstName="ddfshds",LastName="dshfhf"},
                new TestClass{Id=2,FirstName="trutut",LastName="kekekekek"}            
            };

            return Ok(testObjects);
        }
    }
}
