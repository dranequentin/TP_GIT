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
    /// Formulaire d'ajout d'une classe
    /// </summary>
    public partial class ajouterClasse : Form
    {
        /// <summary>
        /// Constructeure du formulaire d'ajout de classes
        /// </summary>
        public ajouterClasse()
        {
            InitializeComponent();
        }

        private void btn_ajouterClasse_Click(object sender, EventArgs e)
        {
            Manager.ClasseManager classeManager = new Manager.ClasseManager();
            bool result = classeManager.InsertClasse(txt_Classe.Text);
            string titre = "Résultat";
            if (result)
            {
                MessageBox.Show("La classe a bien été ajouté.", titre);
                this.Close();
            }
            else
            {
                MessageBox.Show("Échec de l'ajout de la classe.", titre);
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
