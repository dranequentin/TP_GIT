using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Utilities
{
    class BddUtilities
    {
        public static MySqlConnection Connexion()
        {
            string host = "localhost"; // adresse du serveur sur lequel ouvrir la connexion
            string databaseName = "lyceegit"; // Nom de la base de données
            string user = "Manu"; // nom de l'utilisateur de la base de données
            string password = "toto"; // mot de passe de l'utilisateur
            int port = 3307; // numéro de port utilisé par le serveur de base de données

            // Ajout des paramètres de connexion
            MySqlConnection connexion = new MySqlConnection("server=" + host + ";database=" + databaseName + ";port=" + port + ";user=" + user + ";password=" + password + ";SSL Mode=None");
            return connexion;
        }
        public static MySqlConnection OuvrirConnexion()
        {
            MySqlConnection connexion = Connexion();
            connexion.Open();
            return connexion;

        }
        public static void fermerConnexion(MySqlConnection maConnexion)
        {
            maConnexion.Close();
        }
    }
}
