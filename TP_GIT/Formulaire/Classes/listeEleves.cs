using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_GIT.Formulaire.Classes
{
    /// <summary>
    /// Formulaire de la liste des élèves
    /// </summary>
    public partial class listeEleves : Form
    {
        List<Entity.Eleve> Eleves { get; set; }
        /// <summary>
        /// Constructeur du formulaire de la liste des élèves avec pour paramétre l'id d'une classe
        /// et utilisant une fonction permettant de récupérer les informations de la classe
        /// lier a l'id 
        /// </summary>
        /// <param name="id">id d'une classe: entier</param>
        public listeEleves(int id)
        {
            Manager.ClasseManager classeManager = new Manager.ClasseManager();
            Eleves = classeManager.ReadAllClasseById(id);
            string nomClasse = classeManager.ReadNomClasseById(id);
            InitializeComponent();
            lbl_nomClasse.Text = lbl_nomClasse.Text + nomClasse;
        }

        private void listeEleves_Load(object sender, EventArgs e)
        {
            dgv_listeEleves.DataSource = Eleves;
            dgv_listeEleves.Columns[0].Visible = false;
            dgv_listeEleves.Columns[3].Visible = false;
            dgv_listeEleves.Columns[4].Visible = false;
            dgv_listeEleves.Columns[5].Visible = false;
            dgv_listeEleves.Columns[6].Visible = false;
            dgv_listeEleves.Columns[7].Visible = false;
            dgv_listeEleves.Columns[8].Visible = false;
            dgv_listeEleves.Columns[9].Visible = false;
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
