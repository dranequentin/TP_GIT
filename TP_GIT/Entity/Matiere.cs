using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Entity
{
    /// <summary>
    /// Class Matiere représente une matiere enseigné au lycée
    /// </summary>
    public class Matiere
    {
        private int idMatiere;
        private string nomMatiere;
        /// <summary>
        /// Récupère et attribue l'id de l'objet Matière 
        /// </summary>
        public int IdMatiere { get => idMatiere; set => idMatiere = value; }
        /// <summary>
        /// Récupère et attribue le nom de l'objet Matière 
        /// </summary>
        public string NomMatiere { get => nomMatiere; set => nomMatiere = value; }
    }
}
