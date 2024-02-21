using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositaryPattern_Sampel_Repos.Interfaces;

namespace RepositaryPattern_Sampel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ISharedInterface _sharedInterface;
        private readonly IJasserInterface _jasserInterface;

        public HomeController(ISharedInterface sharedInterface, IJasserInterface jasserInterface)
        {
            _sharedInterface = sharedInterface;
            _jasserInterface = jasserInterface;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Test()
        {
            return Ok(await _sharedInterface.GetSampleRequest());
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetMarks()
        {
            return Ok(await _jasserInterface.GetMarks());
        }
    }
}
