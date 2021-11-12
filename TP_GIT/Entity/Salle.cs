using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Entity
{
    class Salle
    {
        private int idSalle;
        private string nomSalle;

        public int IdSalle { get => idSalle; set => idSalle = value; }
        public string NomSalle { get => nomSalle; set => nomSalle = value; }
    }
}
