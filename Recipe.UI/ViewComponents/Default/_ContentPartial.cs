using CafeMenum.UI.DTO.Category;
using CafeMenum.UI.DTO.Food;
using CafeMenum.UI.DTO.FoodImage;
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
        /*public async Task<IViewComponentResult> InvokeAsync(int categoryId)
        {
            var client = _httpClientFactory.CreateClient();
            var responserMessage = await client.GetAsync($"http://localhost:8080/api/food/foodWithCategory/{categoryId}");
            if (responserMessage.IsSuccessStatusCode)
            {
                var jsonData = await responserMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<GetAllFoodResponse>>(jsonData);
                return View(values);
            }
            return View();
        }*/
        public async Task<IViewComponentResult> InvokeAsync(int categoryId)
        {
            var client = _httpClientFactory.CreateClient();

            // İlk istek: kategoriye göre yiyecekleri al
            var response = await client.GetAsync($"http://localhost:8080/api/food/foodWithCategory/{categoryId}");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var foods = JsonConvert.DeserializeObject<List<GetAllFoodResponse>>(jsonData);

                // Her yiyecek için resim URL'sini al
                foreach (var food in foods)
                {
                    var imageResponse = await client.GetAsync($"http://localhost:8080/api/foodImage/foodImageWithFood/{food.id}");
                    if (imageResponse.IsSuccessStatusCode)
                    {
                        var imageJson = await imageResponse.Content.ReadAsStringAsync();
                        var image = JsonConvert.DeserializeObject<GetFoodImageWithFoodResponse>(imageJson);
                        if (image != null && !string.IsNullOrEmpty(image.ImageUrl))
                        {
                            food.ImageUrl = image.ImageUrl;
                        }
                        else
                        {
                            
                            food.ImageUrl = "images/f5.png";
                        } 
                    }
                }
                return View(foods); 
            }
            return View();
        }

    }
}
