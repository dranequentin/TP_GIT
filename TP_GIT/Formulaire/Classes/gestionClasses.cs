using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_GIT.Formulaire.Classes
{
    /// <summary>
    /// Formulaire de la gestion des classes
    /// </summary>
    public partial class gestionClasses : Form
    {
        Entity.Eleve classe { get; set; }

        List<Entity.Classe> Classes { get; set; }
        /// <summary>
        /// Constructeur du formulaire de gestion des classes contenant
        /// une fonction pour lire toutes les classes de la base de données
        /// </summary>
        public gestionClasses()
        {
            Manager.ClasseManager classeManager = new Manager.ClasseManager();
            Classes = classeManager.ReadAllClasses(Utilities.BddUtilities.OuvrirConnexion());
            InitializeComponent();
        }

        private void btn_ajouterClasse_Click(object sender, EventArgs e)
        {
            ajouterClasse ajouterClasse = new ajouterClasse();
            ajouterClasse.Show();
        }

        private void gestionClasses_Load(object sender, EventArgs e)
        {
            dgv_classes.DataSource = Classes;
            dgv_classes.Columns[0].Visible = false;
        }

        private void dgv_classes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int idClasse = int.Parse(dgv_classes.Rows[e.RowIndex].Cells[0].Value.ToString());
                listeEleves listeEleves = new listeEleves(idClasse);
                listeEleves.Show();

            }
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            accueil accueil = new accueil();
            accueil.Show();
            this.Close();
        }
    }
}
