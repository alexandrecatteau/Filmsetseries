using Newtonsoft.Json;

namespace Moteur.Metier
{
    public class SocieteProduction
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "logo_path")]
        public string CheminLogo { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nom { get; set; }

        [JsonProperty(PropertyName = "origin_country")]
        public string PaysOrigine { get; set; }
    }
}
