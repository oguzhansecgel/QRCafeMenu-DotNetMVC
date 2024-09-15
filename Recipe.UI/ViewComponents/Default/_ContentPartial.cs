using CafeMenum.UI.DTO.Category;
using CafeMenum.UI.DTO.Food;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CafeMenum.UI.ViewComponents.Default
{
    public class _ContentPartial : ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _ContentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responserMessage = await client.GetAsync("http://localhost:8080/api/food/getAllFood");
            if (responserMessage.IsSuccessStatusCode)
            {
                var jsonData = await responserMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetAllFoodResponse>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
