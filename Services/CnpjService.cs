using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ApiConsultaCnpj.Models;
using Newtonsoft.Json;

namespace ApiConsultaCnpj.Services
{
    public class CnpjService
    {
        private readonly HttpClient _httpClient;

        public CnpjService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CnpjDto> ConsultarCnpjAsync(string cnpj)
        {
            var url = $"https://publica.cnpj.ws/cnpj/{cnpj}";
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();

            // Console.WriteLine("📦 JSON da API externa:"); // Recebe os dados do Json via terminal
            // Console.WriteLine(json);

            var cnpjDto = JsonConvert.DeserializeObject<CnpjDto>(json);

            return cnpjDto;


        }







    }
}