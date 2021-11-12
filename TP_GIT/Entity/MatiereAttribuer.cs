using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Entity
{
    class MatiereAttribuer
    {
        private Enseignant enseignants;
        private Matiere matieres;

        internal Enseignant Enseignants { get => enseignants; set => enseignants = value; }
        internal Matiere Matieres { get => matieres; set => matieres = value; }
    }
}
