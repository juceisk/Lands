
namespace Lands.Models
{
    using Newtonsoft.Json;
    public class Currency
    {

        // Se hace esta conversion para respetar los estandaras de clases en c#, no son en miniscula
        // el JsonProperty convierte lo q se recibe del json y como lo encuentra en c#
        [JsonProperty(PropertyName ="code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }
    }
}
