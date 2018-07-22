using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Moteur.Metier
{
    public class Film
    {
        [JsonProperty(PropertyName = "adult")]
        public bool EstPourAdulte { get; set; }

        [JsonProperty(PropertyName = "backdrop_path")]
        public string CheminImageFond { get; set; }

        [JsonProperty(PropertyName = "belongs_to_collection")]
        public MemeCollection MemeCollection { get; set; }

        [JsonProperty(PropertyName = "budget")]
        public int Budget { get; set; }

        [JsonProperty(PropertyName = "genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty(PropertyName = "homepage")]
        public string PageDuFilm { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "imdb_id")]
        public string Imdb_id { get; set; }

        [JsonProperty(PropertyName = "original_language")]
        public string LangueOriginale { get; set; }

        [JsonProperty(PropertyName = "original_title")]
        public string TitreOrigine { get; set; }

        [JsonProperty(PropertyName = "overview")]
        public string Resume { get; set; }

        [JsonProperty(PropertyName = "popularity")]
        public double Popularite { get; set; }

        [JsonProperty(PropertyName = "poster_path")]
        public string CheminAffiche { get; set; }

        [JsonProperty(PropertyName = "production_companies")]
        public List<SocieteProduction> SocieteProductions { get; set; }

        [JsonProperty(PropertyName = "production_countries")]
        public List<PaysProduction> PaysProductions { get; set; }

        [JsonProperty(PropertyName = "release_date")]
        public DateTime DateSortie { get; set; }

        [JsonProperty(PropertyName = "revenue")]
        public int Revenue { get; set; }

        [JsonProperty(PropertyName = "runtime")]
        public int Duree { get; set; }

        [JsonProperty(PropertyName = "spoken_languages")]
        public List<Language> Languages { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "tagline")]
        public string Slogan { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Titre { get; set; }

        [JsonProperty(PropertyName = "video")]
        public bool Video { get; set; }

        [JsonProperty(PropertyName = "vote_average")]
        public double MoyenneVote { get; set; }

        [JsonProperty(PropertyName = "vote_count")]
        public int TotalVote { get; set; }
    }
}
