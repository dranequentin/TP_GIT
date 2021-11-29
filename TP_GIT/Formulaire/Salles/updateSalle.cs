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
    /// Formulaire de mise à jour des salles de classes
    /// </summary>
    public partial class updateSalle : Form
    {
        Entity.Salle salles { get; set; }

        private int idSalle;
        /// <summary>
        /// Récupère et attribue un id à l'ojet salle du formulaire
        /// </summary>
        public int IdSalle { get => idSalle; set => idSalle = value; }
        /// <summary>
        /// Constructeur du fromulaire de mise a jour de la salle de classe 
        /// </summary>
        /// <param name="salles">Entity.Salle</param>
        public updateSalle(Entity.Salle salles)
        {
            InitializeComponent();
            txt_updateNom.Text = salles.NomSalle;
            IdSalle = salles.IdSalle;
        }

        private void btn_updateSalle_Click(object sender, EventArgs e)
        {
            string nomSalle = txt_updateNom.Text;

        Manager.SallesManager sm = new Manager.SallesManager();
            if (sm.updateSalle(idSalle,nomSalle))
            {
                MessageBox.Show("Modification réussie");
            }
            else
            {
                MessageBox.Show("Une erreure est survenue");
            }
        }
    }
}
