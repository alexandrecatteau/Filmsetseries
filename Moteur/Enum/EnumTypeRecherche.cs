using System.ComponentModel;

namespace Moteur.Enum
{
    /// <summary>
    /// Typoe de recherche.
    /// </summary>
    public enum EnumTypeRecherche
    {
        /// <summary>
        /// Non défini.
        /// </summary>
        [Description("Non défini")]
        NA = 0,

        /// <summary>
        /// Rechercher un film.
        /// </summary>
        [Description("movie")]
        Film = 1,

        /// <summary>
        /// Rechercher une série.
        /// </summary>
        [Description("tv")]
        Serie = 2
    }
}
