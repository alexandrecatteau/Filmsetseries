using Newtonsoft.Json;

namespace Moteur.Metier
{
    public class MemeCollection
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nom { get; set; }

        [JsonProperty(PropertyName = "poster_path")]
        public string CheminAffiche { get; set; }

        [JsonProperty(PropertyName = "backdrop_path")]
        public string CheminImageFond { get; set; }
    }
}
