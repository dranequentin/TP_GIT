using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Manager
{
    class EnseignantManager
    {
        MySqlConnection connexion;
        public EnseignantManager()
        {
            connexion = Utilities.BddUtilities.Connexion();

        }
    }
}
