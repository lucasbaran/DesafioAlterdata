using Newtonsoft.Json;

namespace DesafioAlterdata.Domain.Models
{

    public class CurrencyQuote
    {
        [JsonProperty(PropertyName = "currencies")]
        public Currency Cotacoes { get; set; }

    }

    public class Currency
    {
        [JsonProperty(PropertyName = "USD")]
        public Coin Dolar { get; set; }

        [JsonProperty(PropertyName = "EUR")]
        public Coin Euro { get; set; }

        [JsonProperty(PropertyName = "BTC")]
        public Coin Bitcoin { get; set; }
    }
    public class Coin
    {
        [JsonProperty(PropertyName = "name")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "buy")]
        public double ValorCompra { get; set; }

        [JsonProperty(PropertyName = "sell")]
        public double ValorVenda { get; set; }

        [JsonProperty(PropertyName = "variation")]
        public double VariacaoPercentual { get; set; }
    }
}
