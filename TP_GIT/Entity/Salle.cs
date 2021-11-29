using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Entity
{
    /// <summary>
    /// Class Salle représente une salle du lycée
    /// </summary>
    public class Salle
    {
        private int idSalle;
        private string nomSalle;
        /// <summary>
        /// Récupère et attribue l'id de l'objet Salle 
        /// </summary>
        public int IdSalle { get => idSalle; set => idSalle = value; }
        /// <summary>
        /// Récupère et attribue le nom de l'objet Salle 
        /// </summary>
        public string NomSalle { get => nomSalle; set => nomSalle = value; }
    }
}
