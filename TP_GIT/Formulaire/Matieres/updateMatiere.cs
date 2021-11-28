using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_GIT.Formulaire.Matieres
{
    public partial class updateMatiere : Form
    {
        Entity.Matiere matieres { get; set; }

        private int idMatiere;
        public int IdMatiere { get => idMatiere; set => idMatiere = value; }
        public updateMatiere(Entity.Matiere matieres)
        {
            InitializeComponent();
            txt_updateNomMatiere.Text = matieres.NomMatiere;
            idMatiere = matieres.IdMatiere;
        }

        private void btn_updateMatiere_Click(object sender, EventArgs e)
        {
            string nomMatiere = txt_updateNomMatiere.Text;

            Manager.MatiereManager mm = new Manager.MatiereManager();
            if (mm.updateMatiere(idMatiere, nomMatiere))
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
