using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
using USTrails.UI.Models;
using USTrails.UI.Models.DTO;

namespace USTrails.UI.Controllers
{
    public class TrailsController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public TrailsController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // Get all trails from API
            var client = httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7016/api/trails?pageSize=100");
            response.EnsureSuccessStatusCode();

            List<TrailDto> states = await response.Content.ReadFromJsonAsync<List<TrailDto>>();

            return View(states);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(CreateTrailViewModel model)
        {
            // Fill out remaining model properties
            model.DifficultyId = 1;
            model.StateIds = new List<short> { 1 };

            var client = httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:7016/api/trails?pageSize=100"),
                Content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json"),
            };

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var trail = await response.Content.ReadFromJsonAsync<TrailDto>();
            if (trail != null)
            {
                return RedirectToAction("Index", "Trails");
            }

            return View();
        }
    }
}
