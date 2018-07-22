using Moteur.Enum;
using Moteur.Utilitaires;
using Moteur.Utilitaires.Validateur;
using System;

namespace Moteur.Metier
{
    /// <summary>
    /// Construction de l'URL.
    /// </summary>
    public class URL
    {
        #region Propriétés
        /// <summary>
        /// Type de recherche.
        /// </summary>
        public EnumTypeRecherche TypeRecherche { get; set; }

        /// <summary>
        /// Id à rechercher.
        /// </summary>
        public string Id { get; set; }
        #endregion

        #region Constantes
        /// <summary>
        /// Début de l'URL.
        /// </summary>
        private const string DEBUT_URL = @"https://api.themoviedb.org/3";

        /// <summary>
        /// Clé Api.
        /// </summary>
        private const string CLE_API = "5619b1f62d9abc240108f40c5cc20861";

        /// <summary>
        /// Language francais par défaut.
        /// </summary>
        private const string LANGUAGE = "fr-FR";
        #endregion

        #region Propriétés dynamiques
        /// <summary>
        /// Description du type de recherche.
        /// </summary>
        public string TypeRechercheDescription
        {
            get
            {
                return this.TypeRecherche.ToName();
            }
        }

        /// <summary>
        /// Url construit pour la recherche.
        /// </summary>
        public string Url
        {
            get
            {
                return $"{DEBUT_URL}/{this.TypeRechercheDescription}/{this.Id}?api_key={CLE_API}&language={LANGUAGE}";
            }
        }
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="typeRecherche">Type de la recherche.</param>
        public URL(string id, EnumTypeRecherche typeRecherche)
        {
            id.Valider(nameof(id));
            typeRecherche.Valider(nameof(typeRecherche));

            this.Id = id;
            this.TypeRecherche = typeRecherche;
        }
        #endregion

        #region Méthodes privée
        #endregion
    }
}
