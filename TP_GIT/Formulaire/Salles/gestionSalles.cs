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
    public partial class gestionSalles : Form
    {
        Entity.Enseignant enseignants { get; set; }

        Entity.Salle salle { get; set; }
        List<Entity.Salle> Salles { get; set; }
        public gestionSalles()
        {
            Manager.SallesManager sallesManager = new Manager.SallesManager();
            Salles = sallesManager.ReadAllSalle();
            InitializeComponent();
        }

        private void btn_ajouterSalle_Click(object sender, EventArgs e)
        {
            ajouterSalle ajouterSalle = new ajouterSalle();
            this.Hide();
            ajouterSalle.Show();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            accueil accueil = new accueil();
            accueil.Show();
            this.Close();
        }

        private void gestionSalles_Load(object sender, EventArgs e)
        {
            dgv_salles.DataSource = Salles;
            dgv_salles.Columns[0].Visible = false;
        }

        private void dgv_salles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int idSalle = int.Parse(dgv_salles.Rows[e.RowIndex].Cells[0].Value.ToString());
                Manager.SallesManager sm = new Manager.SallesManager();
                salle = sm.ReadSalleById(idSalle);
                updateSalle us = new updateSalle(salle);
                us.Show();
            }
        }
    }
}
