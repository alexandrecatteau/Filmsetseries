using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Utilitaires.Validateur
{
    /// <summary>
    /// Valide les entrées.
    /// </summary>
    public static partial class Validateur
    {
        /// <summary>
        /// Lève une exception si le string est vide ou null.
        /// </summary>
        /// <param name="s"></param>
        public static void NonVide(this string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentException($"Le paramétre {_validateurObjet.NomParametre} doit être renseigné.");
            }
        }
    }
}
