using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Manager
{
    class MatiereManager
    {
        MySqlConnection connexion;
        public MatiereManager()
        {
            connexion = Utilities.BddUtilities.Connexion();

        }
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
    }
}
