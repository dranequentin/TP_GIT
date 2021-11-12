using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Entity
{
    class Cours
    {
        private int idCours,dureeCours;
        private DateTime dateCours, heurCours;
        private bool isCancelled;

        public int IdCours { get => idCours; set => idCours = value; }
        public int DureeCours { get => dureeCours; set => dureeCours = value; }
        public DateTime DateCours { get => dateCours; set => dateCours = value; }
        public DateTime HeurCours { get => heurCours; set => heurCours = value; }
        public bool IsCancelled { get => isCancelled; set => isCancelled = value; }
    }
}
