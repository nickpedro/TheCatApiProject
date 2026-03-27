using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using TheCatApiProject.Models;
using System;

namespace TheCatApiProject.Service
{

    //🧠 O que esse código faz

    //🔹 Faz requisição HTTP

    //🔹 Recebe JSON da API

    //🔹 Converte pra List<Cat>

    //🔹 Retorna 1 gato

    public class CatService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Cat> GetRandomCat()
        {
            string url = "https://api.thecatapi.com/v1/images/search";

            var response = await _httpClient.GetStringAsync(url);

            var cats = JsonConvert.DeserializeObject<List<Cat>>(response);

            return cats[0];
        }
    }
}
