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
    /// Formulaire de la fiche enseignant
    /// </summary>
    public partial class ficheEnseignant : Form
    {
        Entity.Enseignant enseignants { get; set; }

        private int idEnseignant;
        /// <summary>
        /// Récupère et attribue l'id de l'objet Enseignant passé en paramétre 
        /// a l'idEnseignant du formulaire de la fiche enseignant
        /// correspond a la valeur passer dans le constructeur
        /// </summary>
        public int IdEnseignant { get => idEnseignant; set => idEnseignant = value; }
        /// <summary>
        /// Constructeur du formulaire fiche enseignant ayant pour paramétre un objet enseignant
        /// attribuant les informations de l'objet aux champs de texte du formulaire
        /// </summary>
        /// <param name="enseignants">Entity.Enseignant</param>
        public ficheEnseignant(Entity.Enseignant enseignants)
        {
            InitializeComponent();
            lbl_nomValue.Text = enseignants.Nom;
            lbl_prenomValue.Text = enseignants.Prenom;
            lbl_cpValue.Text = enseignants.Cp;
            lbl_villeValue.Text = enseignants.Ville;
            lbl_rueValue.Text = enseignants.Rue;
            lbl_telValue.Text = enseignants.Tel;
            lbl_emailValue.Text = enseignants.Email;
            lbl_dateEmbauchValue.Text = enseignants.DateEmbauch.ToString();
            idEnseignant = enseignants.IdEnseignant;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            Manager.EnseignantManager em = new Manager.EnseignantManager();
            bool isOk = em.DeleteEnseignant(this.IdEnseignant);
            if (isOk)
            {
                MessageBox.Show("Suppression réussie");
                this.Close();
            }
            else
            {
                MessageBox.Show("Une erreure est survenue");
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            Manager.EnseignantManager em = new Manager.EnseignantManager();
            enseignants = em.ReadEnseignantById(idEnseignant);
            Enseignants.updateEnseignant updateEnseignant = new Enseignants.updateEnseignant(enseignants);
            updateEnseignant.Show();
        }
    }
}
