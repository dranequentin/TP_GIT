using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Entity
{
    class Enseignant
    {
        private int idEnseignant;
        private string nom, prenom, cp, ville, rue, tel, email;
        private DateTime dateEmbauch;

        public int IdEnseignant { get => idEnseignant; set => idEnseignant = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateEmbauch { get => dateEmbauch; set => dateEmbauch = value; }
    }
}
