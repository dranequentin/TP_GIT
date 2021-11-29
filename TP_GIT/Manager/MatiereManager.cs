using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Manager
{
    /// <summary>
    /// Manager de l'entité Matiere 
    /// </summary>
    class MatiereManager
    {
        MySqlConnection connexion;
        public MatiereManager()
        {
            connexion = Utilities.BddUtilities.Connexion();

        }
        /// <summary>
        /// Recupère la liste de toutes les matières
        /// </summary>
        /// <returns>List{Entity.Matiere}</returns>
        public List<Entity.Matiere> ReadAllMatiere()
        {
            connexion.Open();
            List<Entity.Matiere> ListMatiere = new List<Entity.Matiere>();
            MySqlDataReader matieres;
            string requeteSelect = "Select idMatiere,nomMatiere from matiere";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            matieres = commandeSql.ExecuteReader();
            if (matieres.HasRows)
            {
                while (matieres.Read())
                {
                    Entity.Matiere data = new Entity.Matiere();

                    data.IdMatiere = matieres.GetInt32("idMatiere");
                    data.NomMatiere = matieres.GetString("nomMatiere");
                    ListMatiere.Add(data);
                }
                matieres.Close();
            }
            Utilities.BddUtilities.fermerConnexion(connexion);
            return ListMatiere;
        }
        /// <summary>
        /// Insertion d'une matiere dans la base de donnée
        /// </summary>
        /// <param name="nomMatiere">nom de la matière à ajouter: chaine de caractère</param>
        /// <returns>Booléen</returns>
        public bool InsertMatiere(string nomMatiere)
        {
            connexion.Open();
            string requeteSelect = "insert into matiere (nomMatiere) VALUES (@nomMatiere)";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@nomMatiere", nomMatiere);
            int Stop = commandeSql.ExecuteNonQuery();
            Utilities.BddUtilities.fermerConnexion(connexion);
            connexion.Close();
            return true;

        }
        /// <summary>
        /// Attribue une matiere a un enseignant
        /// </summary>
        /// <param name="idMatiere">id de la matiere a attribuer: entier</param>
        /// <param name="idEnseignant">id de l'enseignant a assigner a la matière: chaine de caractère</param>
        /// <returns>Booléen</returns>
        public bool AttribuerMatiere(int idMatiere, int idEnseignant)
        {
            connexion.Open();
            string requeteSelect = "insert into matiereattribuer (idEnseignant,idMatière) VALUES (@idEnseignant,@idMatiere)";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@idMatiere", idMatiere);
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
        /// <summary>
        /// Lit les informations d'une matière grâce a son id
        /// </summary>
        /// <param name="idMatiere">id de la matière rechercher: entier</param>
        /// <returns>Entity.Matier</returns>
        public Entity.Matiere ReadMatiereById(int idMatiere)
        {
            connexion.Open();
            Entity.Matiere data = new Entity.Matiere();
            MySqlDataReader matieres;
            string requeteSelect = "Select * from matiere where idMatiere = @idMatiere";
            MySqlCommand commandeSql = connexion.CreateCommand();
            commandeSql.CommandText = requeteSelect;
            commandeSql.Parameters.AddWithValue("@idMatiere", idMatiere);
            matieres = commandeSql.ExecuteReader();
            if (matieres.HasRows)
            {
                matieres.Read();

                data.IdMatiere = matieres.GetInt32("idMatiere");
                data.NomMatiere = matieres.GetString("nomMatiere");

                matieres.Close();
            }
            return data;
        }
        /// <summary>
        /// Met à jour le nom de la matière selectionner 
        /// </summary>
        /// <param name="idMatiere">id de la matière selectonner: entier</param>
        /// <param name="nomMatiere">nouveau nom de la matière: chaine de caractère</param>
        /// <returns>Booléen </returns>
        public bool updateMatiere(int idMatiere, string nomMatiere)
        {
            connexion.Open();
            string requeteSelect = "UPDATE matiere set nomMatiere = @nomMatiere where idMatiere =@idMatiere";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@nomMatiere", nomMatiere);
            commandeSql.Parameters.AddWithValue("@idMatiere", idMatiere);
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
