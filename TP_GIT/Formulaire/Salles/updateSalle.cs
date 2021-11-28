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
    public partial class updateSalle : Form
    {
        Entity.Salle salles { get; set; }

        private int idSalle;
        public int IdSalle { get => idSalle; set => idSalle = value; }
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
