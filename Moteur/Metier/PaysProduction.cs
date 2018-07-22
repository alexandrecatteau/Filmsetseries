using Newtonsoft.Json;

namespace Moteur.Metier
{
    public class PaysProduction
    {
        [JsonProperty(PropertyName = "iso_3166_1")]
        public string Iso { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nom { get; set; }
    }
}
