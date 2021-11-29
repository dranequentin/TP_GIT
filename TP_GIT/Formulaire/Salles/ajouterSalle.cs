using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_GIT.Formulaire.Salles
{
    /// <summary>
    /// Formulaire d'ajout d'une salle de classe
    /// </summary>
    public partial class ajouterSalle : Form
    {
        /// <summary>
        /// Constructeur du formulaire d'ajout d'une salle de classe
        /// </summary>
        public ajouterSalle()
        {
            InitializeComponent();
        }

        private void btn_ajouterSalle_Click(object sender, EventArgs e)
        {
            Manager.SallesManager salleManager = new Manager.SallesManager();
            bool result = salleManager.InsertSalle(txt_salle.Text);
            string titre = "Résultat";
            if (result)
            {
                MessageBox.Show("La salle a bien été ajouté.", titre);
                this.Close();
                gestionSalles gs = new gestionSalles();
                gs.Show();
            }
            else
            {
                MessageBox.Show("Échec de l'ajout de la salle.", titre);
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
            gestionSalles gs = new gestionSalles();
            gs.Show();
        }
    }
}
