using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Entity
{
    /// <summary>
    /// Class Classe répresente un classe du lycée
    /// </summary>
    public class Classe
    {
      
        private int idClasse;

        private string nomClasse;
        /// <summary>
        /// Récupère et attribue l'id de l'objet classe 
        /// </summary>
        public int IdClasse { get => idClasse; set => idClasse = value; }
        /// <summary>
        /// Récupère et attribue le nom de l'objet classe 
        /// </summary>
        public string NomClasse { get => nomClasse; set => nomClasse = value; }
        /// <summary>
        /// Affiche le nom de la classe
        /// </summary>
        /// <returns>NomClasse</returns>
        public override string ToString()
        {
            return NomClasse;
        }
    }
}
