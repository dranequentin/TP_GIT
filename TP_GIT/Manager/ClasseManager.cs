using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP_GIT.Manager
{
    class ClasseManager
    {
        MySqlConnection connexion;
        public ClasseManager()
        {
            connexion = Utilities.BddUtilities.Connexion();

        }
    }
}
