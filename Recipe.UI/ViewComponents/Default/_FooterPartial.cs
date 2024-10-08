﻿using CafeMenum.UI.DTO.About;
using CafeMenum.UI.DTO.FooterContact;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CafeMenum.UI.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _FooterPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responserMessage = await client.GetAsync("http://localhost:8080/api/contact/getAllContact");
            if (responserMessage.IsSuccessStatusCode)
            {
                var jsonData = await responserMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FooterContactResponse>>(jsonData);
                return View(values);
            }
            return View();
        }

    }
}
