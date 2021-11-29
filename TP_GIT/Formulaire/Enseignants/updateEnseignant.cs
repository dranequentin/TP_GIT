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
    /// Formulaire de modification d'un enseignant 
    /// </summary>
    public partial class updateEnseignant : Form
    {
        Entity.Enseignant enseignants { get; set; }

        private int idEnseignant;
        /// <summary>
        /// Récupère et attribue l'id de l'objet Enseignant du formulaire de mise a jour d'un enseignant
        /// </summary>
        public int IdEnseignant { get => idEnseignant; set => idEnseignant = value; }
        /// <summary>
        /// Constucteur du formulaire de mise à jour d'un enseignant ayant comme paramétre
        /// un objet enseignant
        /// </summary>
        /// <param name="enseignants">Entity.Enseignant</param>
        public updateEnseignant(Entity.Enseignant enseignants)
        {
            InitializeComponent();
            txt_nomEnseignant.Text = enseignants.Nom;
            txt_prenomEnseignant.Text = enseignants.Prenom;
            txt_cp.Text = enseignants.Cp;
            txt_ville.Text = enseignants.Ville;
            txt_rue.Text = enseignants.Rue;
            txt_tel.Text = enseignants.Tel;
            txt_email.Text = enseignants.Email;
            idEnseignant = enseignants.IdEnseignant;
        }

        private void btn_updateEnseignant_Click(object sender, EventArgs e)
        {
            string nom = txt_nomEnseignant.Text;
            string prenom = txt_prenomEnseignant.Text;
            string ville = txt_ville.Text;
            string cp = txt_cp.Text;
            string rue = txt_rue.Text;
            string tel = txt_tel.Text;
            string email = txt_email.Text;
            Manager.EnseignantManager em = new Manager.EnseignantManager();
            if (em.updateEnseignant(idEnseignant,nom,prenom,ville, cp, rue, tel, email))
            {
                MessageBox.Show("Modification réussie");
            }
            else
            {
                MessageBox.Show("Une erreure est survenue");
            }
        }
    }
}
