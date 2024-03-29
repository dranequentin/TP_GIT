﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Manager
{
    /// <summary>
    /// Manager de la classe Eleve
    /// </summary>
    class EleveManager
    {
        MySqlConnection connexion;
        public EleveManager()
        {
            connexion = Utilities.BddUtilities.Connexion();
        }
        /// <summary>
        /// Récupère tous les élèves de la base de données
        /// </summary>
        /// <param name="connexion"></param>
        /// <returns>List{Entity.Eleve}</returns>
        public List<Entity.Eleve> ReadAllStudents(MySqlConnection connexion)
        {
            List<Entity.Eleve> ListEleves = new List<Entity.Eleve>();
            MySqlDataReader eleves;
            string requeteSelect = "Select nom,prenom,nomClasse from eleve inner join classe on eleve.idClasse = classe.idClasse order by nom";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            eleves = commandeSql.ExecuteReader();
            if (eleves.HasRows)
            {
                while (eleves.Read())
                {
                    Entity.Eleve data = new Entity.Eleve();
                    Entity.Classe classe = new Entity.Classe();

                    data.Nom = eleves.GetString("nom");
                    data.Prenom = eleves.GetString("prenom");
                    classe.NomClasse = eleves.GetString("nomClasse");
                    data.MaClasse = classe;

                    ListEleves.Add(data);
                }
                eleves.Close();
            }
            return ListEleves;
        }
        /// <summary>
        /// Insertion d'un élève dans la base de données
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="ville"></param>
        /// <param name="cp"></param>
        /// <param name="rue"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <param name="dateValidation"></param>
        /// <returns>Booléen</returns>
        public bool InsertEleve(string nom, string prenom, string ville, string cp, string rue,
           string tel, string email, DateTime dateValidation)
        {
            connexion.Open();
            string requeteSelect = "insert into eleve (nom,prenom,ville," +
                "cp,rue,tel,email,dateValidation,dateFinEtude) VALUES (@nom,@prenom,@ville,@cp," +
                "@rue,@tel,@email,@dateValidation,NULL)";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@nom", nom);
            commandeSql.Parameters.AddWithValue("@prenom", prenom);
            commandeSql.Parameters.AddWithValue("@ville", ville);
            commandeSql.Parameters.AddWithValue("@cp", cp);
            commandeSql.Parameters.AddWithValue("@rue", rue);
            commandeSql.Parameters.AddWithValue("@tel", tel);
            commandeSql.Parameters.AddWithValue("@email", email);
            commandeSql.Parameters.AddWithValue("@dateValidation", dateValidation);

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
        /// Récupère la liste des élèves qui ne font plus partie du lycée
        /// </summary>
        /// <param name="connexion"></param>
        /// <returns>List{Entity.Eleve}</returns>
        public List<Entity.Eleve> ReadAllStillStudent(MySqlConnection connexion)
        {
            List<Entity.Eleve> ListEleves = new List<Entity.Eleve>();
            MySqlDataReader eleves;
            string requeteSelect = "Select nom,prenom from eleve WHERE idClasse IS NULL order by nom";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            eleves = commandeSql.ExecuteReader();
            if (eleves.HasRows)
            {
                while (eleves.Read())
                {
                    Entity.Eleve data = new Entity.Eleve();
                    Entity.Classe classe = new Entity.Classe();

                    data.Nom = eleves.GetString("nom");
                    data.Prenom = eleves.GetString("prenom");

                    ListEleves.Add(data);
                }
                eleves.Close();
            }
            return ListEleves;
        }

    }
}
