﻿//using KursProjectWebUI.Dtos.SocialMediaDtos;
//using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;

//namespace KursProjectWebUI.ViewComponents.UILayoutComponents
//{
//    public class _UILayoutSocialMediaComponentPartial:ViewComponent
//    {
//             private readonly IHttpClientFactory _httpClientFactory;

//        public _UILayoutSocialMediaComponentPartial(IHttpClientFactory httpClientFactory)
//        {
//            _httpClientFactory = httpClientFactory;
//        }

//        public async Task<IViewComponentResult> Invoke()
//        {
//            var client = _httpClientFactory.CreateClient();
//            var responseMessage = await client.GetAsync("https://localhost:7255/api/SocialMedia");
//            if (responseMessage.IsSuccessStatusCode)
//            {
//                var jsonData = await responseMessage.Content.ReadAsStringAsync();
//                var values = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(jsonData);
//                return View(values);
//            }

//            return View();
//        }
//    }
//}
