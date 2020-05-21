using Newtonsoft.Json;

namespace DesafioAlterdata.Domain.Models
{
    public class CurrencyResults
    {
        [JsonProperty(PropertyName = "results")]
        public CurrencyQuote Resultados { get; set; }
    }
}
