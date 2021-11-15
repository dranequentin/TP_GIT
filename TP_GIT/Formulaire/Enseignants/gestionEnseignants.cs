using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_GIT.Formulaire.Enseignants
{
    public partial class gestionEnseignants : Form
    {
        public gestionEnseignants()
        {
            InitializeComponent();
        }

        private void btn_ajouterEnseignant_Click(object sender, EventArgs e)
        {
            Enseignants.ajouterEnseignant ajouterEnseignants = new Enseignants.ajouterEnseignant();
            ajouterEnseignants.Show();

        }
    }
}
