using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestClassController : ControllerBase
    {
        private static List<TestClass> testObjects = new List<TestClass> 
            {
                new TestClass{Id=1,FirstName="ddfshds",LastName="dshfhf"},
                new TestClass{Id=2,FirstName="trutut",LastName="kekekekek"}                       
        };


        [HttpGet]
        public async Task<ActionResult<List<TestClass>>> Get()
        {            
            return Ok(testObjects);
        }

        [HttpPost]
        public async Task<ActionResult<List<TestClass>>> AddTestClass(TestClass testClass)
        {
            testObjects.Add(testClass);
            return Ok(testObjects);
        }
    }
}
