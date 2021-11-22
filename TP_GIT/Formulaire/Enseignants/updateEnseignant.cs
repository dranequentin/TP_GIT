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
    public partial class updateEnseignant : Form
    {
        Entity.Enseignant enseignants { get; set; }

        private int idEnseignant;
        public int IdEnseignant { get => idEnseignant; set => idEnseignant = value; }
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
            string ville = txt_ville.Text;
            string cp = txt_cp.Text;
            string rue = txt_rue.Text;
            string tel = txt_tel.Text;
            string email = txt_email.Text;
            Manager.EnseignantManager em = new Manager.EnseignantManager();
            if (em.updateEnseignant(idEnseignant,ville, cp, rue, tel, email))
            {
                MessageBox.Show("Ajout réussie");
            }
            else
            {
                MessageBox.Show("Une erreure est survenue");
            }
        }
    }
}
