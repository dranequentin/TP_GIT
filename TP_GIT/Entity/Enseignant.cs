using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Entity
{
    /// <summary>
    /// Class Enseignant représente un enseignant du lycée
    /// </summary>
    public class Enseignant
    {
        private int idEnseignant;
        private string nom, prenom, cp, ville, rue, tel, email;
        private DateTime dateEmbauch;

        /// <summary>
        /// Récupère et attribue l'id de l'objet Enseignant 
        /// </summary>
        public int IdEnseignant { get => idEnseignant; set => idEnseignant = value; }
        /// <summary>
        /// Récupère et attribue le nom de l'objet Enseignant 
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
        /// <summary>
        /// Récupère et attribue le prenom de l'objet Enseignant 
        /// </summary>
        public string Prenom { get => prenom; set => prenom = value; }
        /// <summary>
        /// Récupère et attribue le code postale de l'objet Enseignant 
        /// </summary>
        public string Cp { get => cp; set => cp = value; }
        /// <summary>
        /// Récupère et attribue la ville de l'objet Enseignant 
        /// </summary>
        public string Ville { get => ville; set => ville = value; }
        /// <summary>
        /// Récupère et attribue le rue de l'objet Enseignant 
        /// </summary>
        public string Rue { get => rue; set => rue = value; }
        /// <summary>
        /// Récupère et attribue le numéro de téléphone de l'objet Enseignant 
        /// </summary>
        public string Tel { get => tel; set => tel = value; }
        /// <summary>
        /// Récupère et attribue l'email de l'objet Enseignant 
        /// </summary>
        public string Email { get => email; set => email = value; }
        /// <summary>
        /// Récupère et attribue la date d'embauche de l'objet Enseignant 
        /// </summary>
        public DateTime DateEmbauch { get => dateEmbauch; set => dateEmbauch = value; }
    }
}
