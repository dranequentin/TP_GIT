using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Entity
{
    /// <summary>
    /// Class Cours représente un cours du lycée
    /// </summary>
    class Cours
    {
        private int idCours,dureeCours;
        private DateTime dateCours, heureCours;
        private bool isCancelled;
        /// <summary>
        /// Récupère et attribue l'id de l'objet Cours 
        /// </summary>
        public int IdCours { get => idCours; set => idCours = value; }
        /// <summary>
        /// Récupère et attribue la durée du cours de l'objet Cours 
        /// </summary>
        public int DureeCours { get => dureeCours; set => dureeCours = value; }
        /// <summary>
        /// Récupère et attribue la date de l'objet Cours 
        /// </summary>
        public DateTime DateCours { get => dateCours; set => dateCours = value; }
        /// <summary>
        /// Récupère et attribue l'heure de l'objet Cours 
        /// </summary>
        public DateTime HeureCours { get => heureCours; set => heureCours = value; }
        /// <summary>
        /// Récupère et attribue l'état de l'objet Cours 
        /// </summary>
        public bool IsCancelled { get => isCancelled; set => isCancelled = value; }
    }
}
