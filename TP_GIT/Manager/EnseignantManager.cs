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
        public bool InsertEnseignant(string nom, string prenom,DateTime dateEmbauche, string ville, string cp, string rue,
            string tel, string email)
        {
            connexion.Open();
            string requeteSelect = "insert into enseignant (nom,prenom,dateEmbauch,tel,ville," +
                "cp,rue,email) VALUES (@nom,@prenom,@dateEmbauche,@ville,@cp," +
                "@rue,@tel,@email)";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@nom", nom);
            commandeSql.Parameters.AddWithValue("@prenom", prenom);
            commandeSql.Parameters.AddWithValue("@dateEmbauche", dateEmbauche);
            commandeSql.Parameters.AddWithValue("@ville", ville);
            commandeSql.Parameters.AddWithValue("@cp", cp);
            commandeSql.Parameters.AddWithValue("@rue", rue);
            commandeSql.Parameters.AddWithValue("@tel", tel);
            commandeSql.Parameters.AddWithValue("@email", email);
            try
            {
                int Stop = commandeSql.ExecuteNonQuery();
                Utilities.BddUtilities.fermerConnexion(connexion);
                return true;
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Exception attrapée");
                Console.WriteLine(e.Message);
                Console.ResetColor();
                Utilities.BddUtilities.fermerConnexion(connexion);
                return false;
            }
        }
    }
}
