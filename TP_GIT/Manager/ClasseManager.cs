using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP_GIT.Manager
{
    /// <summary>
    /// Manager de l'entity Classe
    /// </summary>
    class ClasseManager
    {
        MySqlConnection connexion;
        public ClasseManager()
        {
            connexion = Utilities.BddUtilities.Connexion();

        }
        /// <summary>
        /// Récupère toutes les classes de la base de données
        /// </summary>
        /// <param name="connexion">Connexion a la base de donnée</param>
        /// <returns>List{Entity.Classe}</returns>
        public List<Entity.Classe> ReadAllClasses(MySqlConnection connexion)
        {
            List<Entity.Classe> ListClasse = new List<Entity.Classe>();
            MySqlDataReader classes;
            string requeteSelect = "Select idClasse,nomClasse from classe";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            classes = commandeSql.ExecuteReader();
            if (classes.HasRows)
            {
                while (classes.Read())
                {
                    Entity.Classe data = new Entity.Classe();

                    data.IdClasse = classes.GetInt32("idClasse");
                    data.NomClasse = classes.GetString("nomClasse");
                    ListClasse.Add(data);
                }
                classes.Close();
            }
            return ListClasse;
        }
        /// <summary>
        /// Insertion de la classe dans la base de données
        /// </summary>
        /// <param name="nomClasse">Nom de la nouvelle classe à ajouter: chaine de caractère</param>
        /// <returns>Booléen</returns>
        public bool InsertClasse(string nomClasse)
        {
            connexion.Open();
            string requeteSelect = "insert into classe (nomClasse) VALUES (@nomClasse)";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@nomClasse", nomClasse);
            int Stop = commandeSql.ExecuteNonQuery();
            Utilities.BddUtilities.fermerConnexion(connexion);
            connexion.Close();
            return true;

        }
        /// <summary>
        /// Récupère tous les élèves de la classe selectionnée
        /// </summary>
        /// <param name="idClasse">Id de la classe selectionnée : entier</param>
        /// <returns>List{Entity.Eleve}</returns>
        public List<Entity.Eleve> ReadAllClasseById(int idClasse)
        {
            List<Entity.Eleve> listEleve = new List<Entity.Eleve>();
            connexion.Open();
            MySqlDataReader classe;
            string requeteSelect = "Select nom,prenom from classe inner join eleve on eleve.idClasse = classe.idClasse where eleve.idClasse = @idClasse order by nom";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@idClasse", idClasse);
            Entity.Eleve eleve = new Entity.Eleve();
            classe = commandeSql.ExecuteReader();
            if (classe.HasRows)
            {
                while (classe.Read())
                {
                    Entity.Eleve data = new Entity.Eleve();

                    data.Nom = classe.GetString("nom");
                    data.Prenom = classe.GetString("prenom");
                    listEleve.Add(data);
                }
                classe.Close();
            }
            Utilities.BddUtilities.fermerConnexion(connexion);
            connexion.Close();
            return listEleve;
        }
        /// <summary>
        /// Récupère le nom de la classe selon son id
        /// </summary>
        /// <param name="idClasse">Id de la classe </param>
        /// <returns>nomClasse</returns>
        public string ReadNomClasseById(int idClasse)
        {

            connexion.Open();
            string requeteSelect = "Select nomClasse from classe where idClasse = @idClasse";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@idClasse", idClasse);
            MySqlDataReader classe = commandeSql.ExecuteReader();
            classe.Read();
            string nomClasse = classe.GetString("nomClasse");
            return nomClasse;
        }
    }
}
