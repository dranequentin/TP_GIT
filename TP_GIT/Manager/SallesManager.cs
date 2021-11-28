using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GIT.Manager
{
    class SallesManager
    {
        MySqlConnection connexion;
        public SallesManager()
        {
            connexion = Utilities.BddUtilities.Connexion();

        }
        public List<Entity.Salle> ReadAllSalle()
        {
            connexion.Open();
            List<Entity.Salle> ListSalle = new List<Entity.Salle>();
            MySqlDataReader salles;
            string requeteSelect = "Select idSalle,nomSalle from salle";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            salles = commandeSql.ExecuteReader();
            if (salles.HasRows)
            {
                while (salles.Read())
                {
                    Entity.Salle data = new Entity.Salle();

                    data.IdSalle = salles.GetInt32("idSalle");
                    data.NomSalle = salles.GetString("nomSalle");
                    ListSalle.Add(data);
                }
                salles.Close();
            }
            Utilities.BddUtilities.fermerConnexion(connexion);
            return ListSalle;
        }
        public bool InsertSalle(string nomSalle)
        {
            connexion.Open();
            string requeteSelect = "insert into salle (nomSalle) VALUES (@nomSalle)";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@nomSalle", nomSalle);
            int Stop = commandeSql.ExecuteNonQuery();
            Utilities.BddUtilities.fermerConnexion(connexion);
            connexion.Close();
            return true;

        }
        public bool updateSalle(int idSalle, string nomSalle)
        {
            connexion.Open();
            string requeteSelect = "UPDATE salle set nomSalle = @nomSalle where idSalle =@idSalle";
            MySqlCommand commandeSql = new MySqlCommand(requeteSelect, connexion);
            commandeSql.Parameters.AddWithValue("@nomSalle", nomSalle);
            commandeSql.Parameters.AddWithValue("@idSalle", idSalle);
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
        public Entity.Salle ReadSalleById(int idSalle)
        {
            connexion.Open();
            Entity.Salle data = new Entity.Salle();
            MySqlDataReader salles;
            string requeteSelect = "Select * from salle where idSalle = @idSalle";
            MySqlCommand commandeSql = connexion.CreateCommand();
            commandeSql.CommandText = requeteSelect;
            commandeSql.Parameters.AddWithValue("@idSalle", idSalle);
            salles = commandeSql.ExecuteReader();
            if (salles.HasRows)
            {
                salles.Read();

                data.IdSalle = salles.GetInt32("idSalle");
                data.NomSalle = salles.GetString("nomSalle");

                salles.Close();
            }
            return data;
        }
    }
}
