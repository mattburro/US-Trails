using Microsoft.AspNetCore.Mvc;
using System.Reflection;
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
            List<TrailDto> states = await GetTrails();

            return View(states);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTrailViewModel model)
        {
            // TODO: Allow this in the UI
            model.DifficultyId = 1;
            model.StateIds = new List<short> { 1 };

            var newTrail = await CreateTrail(model);
            if (newTrail is not null)
            {
                return RedirectToAction("Index", "Trails");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var trailToEdit = await GetTrail(id);
            if (trailToEdit is not null)
            {
                return View(trailToEdit);
            }

            return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> Update(TrailDto trail)
        {
            var updatedTrail = await UpdateTrail(trail);
            if (updatedTrail is not null)
            {
                return RedirectToAction("Index", "Trails");
            }

            return View("Edit");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(TrailDto trail)
        {
            var deletedTrail = await DeleteTrail(trail);
            if (deletedTrail is not null)
            {
                return RedirectToAction("Index", "Trails");
            }

            return View("Edit");
        }

        private async Task<List<TrailDto>> GetTrails()
        {
            using var client = httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7016/api/trails?pageSize=100");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<TrailDto>>();
        }

        private async Task<TrailDto> GetTrail(Guid id)
        {
            using var client = httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7016/api/trails/{id}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<TrailDto>();
        }

        private async Task<TrailDto> CreateTrail(CreateTrailViewModel model)
        {
            using var client = httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:7016/api/trails"),
                Content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<TrailDto>();
        }

        private async Task<TrailDto> UpdateTrail(TrailDto trail)
        {
            using var client = httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri($"https://localhost:7016/api/trails/{trail.Id}"),
                Content = new StringContent(JsonSerializer.Serialize(trail), Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<TrailDto>();
        }

        private async Task<TrailDto> DeleteTrail(TrailDto trail)
        {
            using var client = httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:7016/api/trails/{trail.Id}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<TrailDto>();
        }
    }
}
