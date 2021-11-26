using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Entity
{
    public class Matiere
    {
        private int idMatiere;
        private string nomMatiere;

        public int IdMatiere { get => idMatiere; set => idMatiere = value; }
        public string NomMatiere { get => nomMatiere; set => nomMatiere = value; }
    }
}
