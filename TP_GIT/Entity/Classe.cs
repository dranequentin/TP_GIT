using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Entity
{
    class Classe
    {
        private int idClasse;
        private string nomClasse;

        public int IdClasse { get => idClasse; set => idClasse = value; }
        public string NomClasse { get => nomClasse; set => nomClasse = value; }

        public override string ToString()
        {
            return NomClasse;
        }
    }
}
