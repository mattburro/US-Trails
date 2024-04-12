using Microsoft.AspNetCore.Mvc;
using USTrails.UI.Models.DTO;

namespace USTrails.UI.Controllers
{
    public class StatesController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public StatesController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // Get all states from API
            using var client = httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7016/api/states");

            response.EnsureSuccessStatusCode();

            List<StateDto> states = await response.Content.ReadFromJsonAsync<List<StateDto>>();

            return View(states);
        }
    }
}
