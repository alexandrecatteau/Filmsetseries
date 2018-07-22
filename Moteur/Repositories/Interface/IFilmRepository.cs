using Moteur.Metier;

namespace Moteur.Repositories.Interface
{
    public interface IFilmRepository
    {
        /// <summary>
        /// Rechercher un film avec son Id.
        /// </summary>
        /// <param name="id">Id du film.</param>
        /// <returns>Détail du film.</returns>
        Film ObtenirFilmParId(int id);
    }
}
