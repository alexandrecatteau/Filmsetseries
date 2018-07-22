using System;

namespace Moteur.Utilitaires.Validateur
{
    /// <summary>
    /// Valide les entrées.
    /// </summary>
    public static partial class Validateur
    {
        /// <summary>
        /// Objet pour récupérer le nom du paramétre.
        /// </summary>
        private static ValidateurObjet _validateurObjet;

        /// <summary>
        /// Lève une exception si le paramètre est null.
        /// </summary>
        /// <param name="nomParametre">Nom du paramètre.</param>
        public static T Valider<T>(this T t, string nomParametre)
        {
            _validateurObjet = new ValidateurObjet { NomParametre = nomParametre };
            
            if (t == null)
            {
                throw new ArgumentNullException($"Le paramètre {_validateurObjet.NomParametre} doit être différent de null.");
            }

            return t;
        }
    }
}
