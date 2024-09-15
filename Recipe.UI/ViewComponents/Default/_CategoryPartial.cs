using CafeMenum.UI.DTO.Category;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CafeMenum.UI.ViewComponents.Default
{
    public class _CategoryPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _CategoryPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responserMessage = await client.GetAsync("http://localhost:8080/api/category/getAllCategory");
            if (responserMessage.IsSuccessStatusCode)
            {
                var jsonData = await responserMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetAllCategoryResponse>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
