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
    /// Formulaire d'ajout d'un enseignant
    /// </summary>
    public partial class ajouterEnseignant : Form
    {
        /// <summary>
        /// Constructeur du formulaire d'ajour d'un enseignant
        /// </summary>
        public ajouterEnseignant()
        {
            InitializeComponent();
        }

        private void btn_addEnseignant_Click(object sender, EventArgs e)
        {
            string nom = txt_nomEnseignant.Text;
            string prenom = txt_prenomEnseignant.Text;
            DateTime dateEmbauche = date_embauche.Value.Date;
            string ville = txt_ville.Text;
            string cp = txt_cp.Text;
            string rue = txt_rue.Text;
            string tel = txt_tel.Text;
            string email = txt_email.Text;
            Manager.EnseignantManager em = new Manager.EnseignantManager();
            if (em.InsertEnseignant(nom, prenom, ville, cp, rue, tel, email, dateEmbauche))
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
