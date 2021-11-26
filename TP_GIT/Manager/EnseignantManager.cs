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
        //Fonction pour inserer un enseignant dans la base de données en récurerant les informations issu d'un formulaire 
        public bool InsertEnseignant(string nom, string prenom, string ville, string cp, string rue,
            string tel, string email, DateTime dateEmbauche)
        {
            connexion.Open();
            string requeteSelect = "insert into enseignant (nom,prenom,ville," +
                "cp,rue,tel,email,dateEmbauch) VALUES (@nom,@prenom,@ville,@cp," +
                "@rue,@tel,@email,@dateEmbauche)";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@nom", nom);
            commandeSql.Parameters.AddWithValue("@prenom", prenom);
            commandeSql.Parameters.AddWithValue("@ville", ville);
            commandeSql.Parameters.AddWithValue("@cp", cp);
            commandeSql.Parameters.AddWithValue("@rue", rue);
            commandeSql.Parameters.AddWithValue("@tel", tel);
            commandeSql.Parameters.AddWithValue("@email", email);
            commandeSql.Parameters.AddWithValue("@dateEmbauche", dateEmbauche);

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
        public List<Entity.Enseignant> ReadAllEnseignants()
        {
            connexion.Open();
            List<Entity.Enseignant> infos = new List<Entity.Enseignant>();
            MySqlDataReader enseignants;
            string requeteSelect = "Select * from enseignant";
            MySqlCommand commandeSql = connexion.CreateCommand();
            commandeSql.CommandText = requeteSelect;
            enseignants = commandeSql.ExecuteReader();
            if (enseignants.HasRows)
            {
                while (enseignants.Read())
                {
                    Entity.Enseignant data = new Entity.Enseignant();

                    data.IdEnseignant = enseignants.GetInt32("idEnseignant");
                    data.Nom = enseignants.GetString("nom");
                    data.Prenom = enseignants.GetString("prenom");
                    data.Tel = enseignants.GetString("tel");
                    data.Ville = enseignants.GetString("ville");
                    data.Cp = enseignants.GetString("cp");
                    data.Rue = enseignants.GetString("rue");
                    data.DateEmbauch = enseignants.GetDateTime("dateEmbauch");
                    
                    infos.Add(data);
                }
                enseignants.Close();
            }
            return infos;
        }
        public Entity.Enseignant ReadEnseignantById(int idEnseignant)
        {
            connexion.Open();
            Entity.Enseignant data = new Entity.Enseignant();
            MySqlDataReader enseignants;
            string requeteSelect = "Select * from enseignant where idEnseignant = @idEnseignant";
            MySqlCommand commandeSql = connexion.CreateCommand();
            commandeSql.CommandText = requeteSelect;
            commandeSql.Parameters.AddWithValue("@idEnseignant", idEnseignant);
            enseignants = commandeSql.ExecuteReader();
            if (enseignants.HasRows)
            {
                enseignants.Read();

                data.IdEnseignant = enseignants.GetInt32("idEnseignant");
                data.Nom = enseignants.GetString("nom");
                data.Prenom = enseignants.GetString("prenom");
                data.Tel = enseignants.GetString("tel");
                data.Ville = enseignants.GetString("ville");
                data.Cp = enseignants.GetString("cp");
                data.Rue = enseignants.GetString("rue");
                data.Email = enseignants.GetString("email");
                data.DateEmbauch = enseignants.GetDateTime("dateEmbauch");

                enseignants.Close();
            }
            return data;
        }
        public bool DeleteSite(int idEnseignant)
        {
            connexion.Open();
            string requeteSelect = "DELETE FROM enseignant where idEnseignant = @idEnseignant ";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@idEnseignant", idEnseignant);
            try
            {
                int Stop = commandeSql.ExecuteNonQuery();
                if (Stop == 0)
                {
                    return false;
                }
                Utilities.BddUtilities.fermerConnexion(connexion);
                return true;
            }
            catch (Exception e)
            {
                //On veut faire des jeux videos
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Exception attrapée");
                Console.WriteLine(e.Message);
                Console.ResetColor();
                Utilities.BddUtilities.fermerConnexion(connexion);
                return false;
            }
        }
        public bool updateEnseignant(int idEnseignant,string nom, string prenom, string ville ,string cp, string rue, string tel,string email)
        {
            connexion.Open();
            string requeteSelect = "UPDATE enseignant set nom = @nom, prenom = @prenom, " +
                "ville = @ville, cp = @cp, rue = @rue, tel = @tel, email = @email " +
                "where idEnseignant =@idEnseignant";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@nom", nom);
            commandeSql.Parameters.AddWithValue("@prenom", prenom);
            commandeSql.Parameters.AddWithValue("@ville", ville);
            commandeSql.Parameters.AddWithValue("@cp", cp);
            commandeSql.Parameters.AddWithValue("@rue", rue);
            commandeSql.Parameters.AddWithValue("@tel", tel);
            commandeSql.Parameters.AddWithValue("@email", email);
            commandeSql.Parameters.AddWithValue("@idEnseignant", idEnseignant);
            try
            {
                int Stop = commandeSql.ExecuteNonQuery();
                if (Stop == 0)
                {
                    return false;
                }
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
