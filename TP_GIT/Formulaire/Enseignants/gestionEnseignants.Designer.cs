
namespace TP_GIT.Formulaire.Enseignants
{
    partial class gestionEnseignants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ajouterEnseignant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ajouterEnseignant
            // 
            this.btn_ajouterEnseignant.Location = new System.Drawing.Point(199, 234);
            this.btn_ajouterEnseignant.Name = "btn_ajouterEnseignant";
            this.btn_ajouterEnseignant.Size = new System.Drawing.Size(153, 38);
            this.btn_ajouterEnseignant.TabIndex = 0;
            this.btn_ajouterEnseignant.Text = "Ajouter un enseignant";
            this.btn_ajouterEnseignant.UseVisualStyleBackColor = true;
            this.btn_ajouterEnseignant.Click += new System.EventHandler(this.btn_ajouterEnseignant_Click);
            // 
            // gestionEnseignants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.btn_ajouterEnseignant);
            this.Name = "gestionEnseignants";
            this.Text = "gestionEnseignants";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouterEnseignant;
    }
}