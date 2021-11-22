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
    public partial class gestionInscrits : Form
    {

        List<Entity.Eleve> Eleves { get; set; }
        public gestionInscrits()
        {
            Manager.EleveManager eleveManager = new Manager.EleveManager();
            Eleves = eleveManager.ReadAllStudents(Utilities.BddUtilities.OuvrirConnexion());
            InitializeComponent();
        }

        private void btn_ajouterInscrit_Click(object sender, EventArgs e)
        {
            ajouterInscrit ajouterInscrit = new ajouterInscrit();
            ajouterInscrit.Show();
        }

        private void gestionInscrits_Load(object sender, EventArgs e)
        {
            dgv_inscrits.DataSource = Eleves;
            dgv_inscrits.Columns[0].Visible = false;
            dgv_inscrits.Columns[3].Visible = false;
            dgv_inscrits.Columns[4].Visible = false;
            dgv_inscrits.Columns[5].Visible = false;
            dgv_inscrits.Columns[6].Visible = false;
            dgv_inscrits.Columns[7].Visible = false;
            dgv_inscrits.Columns[8].Visible = false;
            dgv_inscrits.Columns[9].Visible = false;
        }

        private void btn_retour_Click_1(object sender, EventArgs e)
        {
            accueil accueil = new accueil();
            accueil.Show();
            this.Close();
        }
    }
}
