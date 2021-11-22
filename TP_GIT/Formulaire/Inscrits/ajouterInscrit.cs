using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_GIT.Formulaire.Inscrits
{
    public partial class ajouterInscrit : Form
    {
        public ajouterInscrit()
        {
            InitializeComponent();
        }

        private void btn_addEleve_Click(object sender, EventArgs e)
        {
            string nom = txt_nomEleve.Text;
            string prenom = txt_prenomEleve.Text;
            DateTime dateValidation = date_validation.Value.Date;
            string ville = txt_ville.Text;
            string cp = txt_cp.Text;
            string rue = txt_rue.Text;
            string tel = txt_tel.Text;
            string email = txt_email.Text;
            Manager.EleveManager eleveManager = new Manager.EleveManager();
            if (eleveManager.InsertEleve(nom, prenom, ville, cp, rue, tel, email, dateValidation))
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
