using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TicketsApp.Client.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Test(string text)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync($"http://localhost:5274/api/test?text={text}");

            if (response.IsSuccessStatusCode)
            {
                return Ok(response.Content.ReadAsStringAsync().Result);
            }

            return BadRequest();
        }
    }
}
