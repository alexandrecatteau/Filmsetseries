using Moteur.Metier;

namespace Moteur.Utilitaires.Interface
{
    public interface ITelecharcherData
    {
        /// <summary>
        /// Récupère les données.
        /// </summary>
        /// <param name="url">Objet URL.</param>
        /// <returns>Data</returns>
        string ObtenirData(URL url);
    }
}
