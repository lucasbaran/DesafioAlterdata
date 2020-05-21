using DesafioAlterdata.Application.Interfaces;
using DesafioAlterdata.Domain.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DesafioAlterdata.Application.Services
{
    public class CotacaoService : ICotacaoService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;

        public CotacaoService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _configuration = configuration;
        }

        public async Task<CurrencyResults> ObterCotacoes()
        {
            var baseURL = _configuration.GetSection("HG_Brasil_API:BaseURL").Value;
            var response = await _httpClient.GetAsync(baseURL);
            var obj = response.Content.ReadAsStringAsync().Result;
            var cotacoes = JsonConvert.DeserializeObject<CurrencyResults>(obj);

            return cotacoes;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
