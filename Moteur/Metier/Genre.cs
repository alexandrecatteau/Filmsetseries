using Newtonsoft.Json;

namespace Moteur.Metier
{
    public class Genre
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nom { get; set; }
    }
}
