﻿using System;
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
    /// Formulaire de gestion des matières
    /// </summary>
    public partial class gestionMatieres : Form
    {
        Entity.Enseignant enseignants { get; set; }

        Entity.Matiere matieres { get; set; }
        List<Entity.Matiere> Matieres { get; set; }
        /// <summary>
        /// Constructeur du formulaire de gestion des matières contenant la fonction permettant 
        /// de récupèrer toutes les informations de toutes les matières
        /// </summary>
        public gestionMatieres()
        {
            Manager.MatiereManager managerMatiere = new Manager.MatiereManager();
            Matieres = managerMatiere.ReadAllMatiere();
            InitializeComponent();
        }

        private void btn_ajouterMatiere_Click(object sender, EventArgs e)
        {
            ajouterMatiere ajouterMatiere = new ajouterMatiere();
            this.Hide();
            ajouterMatiere.Show();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            accueil accueil = new accueil();
            accueil.Show();
            this.Close();
        }

        private void dgv_matiere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1)
            {
                int idMatiere = int.Parse(dgv_matiere.Rows[e.RowIndex].Cells[0].Value.ToString());
                Manager.MatiereManager mm = new Manager.MatiereManager();
                matieres = mm.ReadMatiereById(idMatiere);
                updateMatiere um = new updateMatiere(matieres);
                um.Show();
            }
        }

        private void gestionMatieres_Load(object sender, EventArgs e)
        {
            dgv_matiere.DataSource = Matieres;
            dgv_matiere.Columns[0].Visible = false;
        }

        private void btn_attribuerMatiere_Click(object sender, EventArgs e)
        {
            attribuerMatiere am = new attribuerMatiere();
            am.Show();
        }
    }
}
