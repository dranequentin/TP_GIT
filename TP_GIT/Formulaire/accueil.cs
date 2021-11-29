using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_GIT.Formulaire
{
    /// <summary>
    /// Formulaire d'accueil
    /// </summary>
    public partial class accueil : Form
    {
        /// <summary>
        /// Constructeur du formulaire d'accueil
        /// </summary>
        public accueil()
        {
            InitializeComponent();
        }

        private void btn_gestionSalles_Click(object sender, EventArgs e)
        {
            Salles.gestionSalles pageSalles = new Salles.gestionSalles();
            pageSalles.Show();
            this.Hide();
        }

        private void btn_gestionInscription_Click(object sender, EventArgs e)
        {
            Inscrits.gestionInscrits pageInscrits = new Inscrits.gestionInscrits();
            pageInscrits.Show();
            this.Hide();
        }

        private void btn_gestionEnseignants_Click(object sender, EventArgs e)
        {
            Enseignants.gestionEnseignants pageEnseignants = new Enseignants.gestionEnseignants();
            pageEnseignants.Show();
            this.Hide();
        }

        private void btn_gestionMatieres_Click(object sender, EventArgs e)
        {
            Matieres.gestionMatieres pageMatieres = new Matieres.gestionMatieres();
            pageMatieres.Show();
            this.Hide();
        }

        private void btn_gestionClasses_Click(object sender, EventArgs e)
        {
            Classes.gestionClasses pageClasses = new Classes.gestionClasses();
            pageClasses.Show();
            this.Hide();
        }

        private void btn_gestionCours_Click(object sender, EventArgs e)
        {
            Cours.gestionCours pageCours = new Cours.gestionCours();
            pageCours.Show();
            this.Hide();
        }
    }
}
