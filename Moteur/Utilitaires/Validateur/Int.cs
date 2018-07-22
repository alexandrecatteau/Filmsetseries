using System;

namespace Moteur.Utilitaires.Validateur
{
    /// <summary>
    /// Valide les entrées.
    /// </summary>
    public static partial class Validateur
    {
        /// <summary>
        /// Léve une exception si le paramètre est inférieur à 0.
        /// </summary>
        public static void StrictementPositif(this int i)
        {
            if (i < 1)
            {
                throw new ArgumentException($"Le paramétre {_validateurObjet.NomParametre} doit être supérieur à 1.");
                qsdaze qsdaze qsdzae
            }
        }
    }
}
