using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositaryPattern_Sampel_Repos.Interfaces;

namespace RepositaryPattern_Sampel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IJasserInterface _jasserInterface;

        public ValuesController(IJasserInterface jasserInterface)
        {
            _jasserInterface = jasserInterface;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> jkgjkgfkfkfks()
        {
            return Ok(await _jasserInterface.GetMarks());
        }
    }
}
