using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_GIT.Formulaire.Enseignants
{
    /// <summary>
    /// Formulaire de gestion des enseignants
    /// </summary>
    public partial class gestionEnseignants : Form
    {
        Entity.Enseignant enseignants { get; set; }
        List<Entity.Enseignant> ListeEnseignants { get; set; }
        /// <summary>
        /// Constructeur du formulaire de la gestion des enseignants contenant la fonction
        /// permettant de lire tous les enseignants de la base de données
        /// </summary>
        public gestionEnseignants()
        {
            Manager.EnseignantManager em = new Manager.EnseignantManager();
            ListeEnseignants = em.ReadAllEnseignants();
            InitializeComponent();
        }

        private void btn_ajouterEnseignant_Click(object sender, EventArgs e)
        {
            Enseignants.ajouterEnseignant ajouterEnseignants = new Enseignants.ajouterEnseignant();
            ajouterEnseignants.Show();

        }

        private void gestionEnseignants_Load(object sender, EventArgs e)
        {
            dgv_enseignants.DataSource = ListeEnseignants;
            this.dgv_enseignants.Columns[0].Visible = false;
            this.dgv_enseignants.Columns[3].Visible = false;
            this.dgv_enseignants.Columns[4].Visible = false;
            this.dgv_enseignants.Columns[5].Visible = false;
            this.dgv_enseignants.Columns[6].Visible = false;
            this.dgv_enseignants.Columns[7].Visible = false;
            this.dgv_enseignants.Columns[8].Visible = false;
        }

        private void dgv_enseignants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int idEnseignant = int.Parse(dgv_enseignants.Rows[e.RowIndex].Cells[0].Value.ToString());
                Manager.EnseignantManager em = new Manager.EnseignantManager();
                enseignants = em.ReadEnseignantById(idEnseignant);
                ficheEnseignant fe = new ficheEnseignant(enseignants);
                fe.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            accueil accueil = new accueil();
            accueil.Show();
        }
    }
}
