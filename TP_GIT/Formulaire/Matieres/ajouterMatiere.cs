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
    /// <summary>
    /// Formulaire d'ajout d'une matière
    /// </summary>
    public partial class ajouterMatiere : Form
    {
        /// <summary>
        /// Constructeur du formulaire d'ajout d'une matière
        /// </summary>
        public ajouterMatiere()
        {
            InitializeComponent();
        }

        private void btn_ajouterClasse_Click(object sender, EventArgs e)
        {
            Manager.MatiereManager matiereManager = new Manager.MatiereManager();
            bool result = matiereManager.InsertMatiere(txt_matiere.Text);
            string titre = "Résultat";
            if (result)
            {
                MessageBox.Show("La matière a bien été ajouté.", titre);
                this.Close();
                gestionMatieres gm = new gestionMatieres();
                gm.Show();
            }
            else
            {
                MessageBox.Show("Échec de l'ajout de la matière.", titre);
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
