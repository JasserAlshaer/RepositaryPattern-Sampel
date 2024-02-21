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

        public HomeController(ISharedInterface sharedInterface)
        {
            _sharedInterface = sharedInterface;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Test()
        {
            return Ok(await _sharedInterface.GetSampleRequest());
        }
    }
}
