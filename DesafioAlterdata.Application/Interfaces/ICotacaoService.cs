using DesafioAlterdata.Domain.Models;
using System;
using System.Threading.Tasks;

namespace DesafioAlterdata.Application.Interfaces
{
    public interface ICotacaoService : IDisposable
    {
        public Task<CurrencyResults> ObterCotacoes();
    }
}
