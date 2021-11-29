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
        /// <summary>
        /// Manager de la classe Enseignant
        /// </summary>
        MySqlConnection connexion;
        public EnseignantManager()
        {
            connexion = Utilities.BddUtilities.Connexion();

        }
        /// <summary>
        /// Insertion d'un enseignant dans la base de données
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="ville"></param>
        /// <param name="cp"></param>
        /// <param name="rue"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <param name="dateEmbauche"></param>
        /// <returns>Booléen</returns>
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
        /// <summary>
        /// Récupère tous les enseignants de la base de données
        /// </summary>
        /// <returns>List{Entity.Enseignant}</returns>
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
        /// <summary>
        /// Récupère les informations de l'enseignant correspondant à l'id renseigné
        /// </summary>
        /// <param name="idEnseignant">id de l'enseignant : entier</param>
        /// <returns>Entity.Enseignant</returns>
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
        /// <summary>
        /// Supprime l'enseignant de la base de données
        /// </summary>
        /// <param name="idEnseignant">id de l'enseignant à supprimer: entier</param>
        /// <returns>Booléen</returns>
        public bool DeleteEnseignant(int idEnseignant)
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
        /// <summary>
        /// Met à jour les informations d'un enseignant
        /// </summary>
        /// <param name="idEnseignant"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="ville"></param>
        /// <param name="cp"></param>
        /// <param name="rue"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <returns>Booléen</returns>
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
