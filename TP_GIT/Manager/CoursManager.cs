using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Manager
{
    class CoursManager
    {
        /// <summary>
        /// Manager de la classe Cours
        /// </summary>
        MySqlConnection connexion;
        public CoursManager()
        {
            connexion = Utilities.BddUtilities.Connexion();

        }
    }
}
