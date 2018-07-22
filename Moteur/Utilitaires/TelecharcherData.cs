using Moteur.Metier;
using Moteur.Utilitaires.Interface;
using Moteur.Utilitaires.Validateur;
using System.Net;
using System.Security.Policy;

namespace Moteur.Utilitaires
{
    public class TelecharcherData : ITelecharcherData
    {
        /// <summary>
        /// Récupère les données.
        /// </summary>
        /// <param name="url">Objet URL.</param>
        /// <returns>Data</returns>
        public string ObtenirData(URL url)
        {
            url.Valider(nameof(url));
            url.Url.Valider(nameof(url.Url));

            string retour = string.Empty;

            using (WebClient webClient = new WebClient())
            {
              retour =   webClient.DownloadString(url.Url);
            }

            return retour;
        }

        public string ObtenirData(Url url)
        {
            throw new System.NotImplementedException();
        }
    }
}
