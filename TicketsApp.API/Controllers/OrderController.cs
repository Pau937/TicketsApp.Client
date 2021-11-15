using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TicketsApp.Client.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Order(int id)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync($"http://localhost:5274/api/order?id={id}");

            if (response.IsSuccessStatusCode)
            {
                return Ok(response.Content.ReadAsStringAsync().Result);
            }

            return BadRequest();
        }
    }
}
