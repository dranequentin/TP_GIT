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
    public partial class attribuerMatiere : Form
    {
        Entity.Enseignant enseignants { get; set; }

        Entity.Matiere matiere { get; set; }
        List<Entity.Matiere> Matieres { get; set; }
        List<Entity.Enseignant> Enseignants { get; set; }
        public attribuerMatiere()
        {
            Manager.MatiereManager managerMatiere = new Manager.MatiereManager();
            Matieres = managerMatiere.ReadAllMatiere();
            Manager.EnseignantManager em = new Manager.EnseignantManager();
            Enseignants = em.ReadAllEnseignants();
            InitializeComponent();
            foreach (var nomEnseignant in Enseignants)
            {
                cbb_enseignants.Items.Add(nomEnseignant.Nom+" "+nomEnseignant.Prenom);
            }
            foreach (Entity.Matiere matiere in Matieres)
            {
                clb_matiere.Items.Add(matiere.NomMatiere);
            }
        }

        private void attribuerMatiere_Load(object sender, EventArgs e)
        {

        }

        private void btn_attribuerMatiere_Click(object sender, EventArgs e)
        {
            int indexEnseignant = cbb_enseignants.SelectedIndex;
            int idEnseignant = Enseignants[indexEnseignant].IdEnseignant;
            
            foreach (int indexChecked in clb_matiere.CheckedIndices)
            {
                int idMatiere = Matieres[indexChecked].IdMatiere;
                Manager.MatiereManager mm = new Manager.MatiereManager();
                bool result = mm.AttribuerMatiere(idMatiere,idEnseignant);
                string titre = "Résultat";
                if (result)
                {
                    MessageBox.Show("La matière :"+ Matieres[indexChecked].NomMatiere+
                        " a bien été attitré à "+ Enseignants[indexEnseignant].Nom+" "+
                        Enseignants[indexEnseignant].Prenom, titre);
                    
                }
                else
                {
                    MessageBox.Show("Échec de l'attribution de la matière : "+ Matieres[indexChecked].NomMatiere, titre);
                }
            }
            this.Close();
            gestionMatieres gm = new gestionMatieres();
            gm.Show();
        }
    }
}