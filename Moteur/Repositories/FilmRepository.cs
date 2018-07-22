using Moteur.Metier;
using Moteur.Repositories.Interface;
using Moteur.Utilitaires;
using Moteur.Utilitaires.Interface;
using Moteur.Utilitaires.Validateur;
using Newtonsoft.Json;

namespace Moteur.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        /// <summary>
        /// Objet pour télécharger depuis une URL.
        /// </summary>
        private ITelecharcherData _telechargerData;

        /// <summary>
        /// Rechercher un film avec son Id.
        /// </summary>
        /// <param name="id">Id du film.</param>
        /// <returns>Détail du film.</returns>
        public Film ObtenirFilmParId(int id)
        {
            id.Valider(nameof(id)).StrictementPositif();

            URL url = new URL(id.ToString(), Enum.EnumTypeRecherche.Film);
            url.Valider(nameof(url));

            _telechargerData = new TelecharcherData();

            string data = _telechargerData.ObtenirData(url);
            data.Valider(nameof(data));

            return JsonConvert.DeserializeObject<Film>(data);
        }
    }
}
