using DesafioAlterdata.Application.Interfaces;
using DesafioAlterdata.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioAlterdata.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CotacaoController : ControllerBase
    {
        private readonly ICotacaoService _cotacaoService;

        public CotacaoController(ICotacaoService cotacaoService)
        {
            _cotacaoService = cotacaoService;
        }

        [HttpGet]
        public async Task<CurrencyResults> Get()
        {
            var cotacoes = await _cotacaoService.ObterCotacoes();
            return cotacoes;
        }
    }
}