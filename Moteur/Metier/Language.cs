using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Metier
{
    public class Language
    {
        [JsonProperty(PropertyName = "iso_639_1")]
        public string Iso { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nom { get; set; }
    }
}
