
namespace TP_GIT.Formulaire
{
    partial class accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accueil));
            this.lbl_accueil = new System.Windows.Forms.Label();
            this.btn_gestionInscription = new System.Windows.Forms.Button();
            this.btn_gestionEnseignants = new System.Windows.Forms.Button();
            this.btn_gestionClasses = new System.Windows.Forms.Button();
            this.btn_gestionCours = new System.Windows.Forms.Button();
            this.btn_gestionMatieres = new System.Windows.Forms.Button();
            this.btn_gestionSalles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_accueil
            // 
            this.lbl_accueil.AutoSize = true;
            this.lbl_accueil.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accueil.Location = new System.Drawing.Point(13, 13);
            this.lbl_accueil.Name = "lbl_accueil";
            this.lbl_accueil.Size = new System.Drawing.Size(73, 26);
            this.lbl_accueil.TabIndex = 0;
            this.lbl_accueil.Text = "Accueil";
            // 
            // btn_gestionInscription
            // 
            this.btn_gestionInscription.Location = new System.Drawing.Point(33, 75);
            this.btn_gestionInscription.Name = "btn_gestionInscription";
            this.btn_gestionInscription.Size = new System.Drawing.Size(145, 35);
            this.btn_gestionInscription.TabIndex = 1;
            this.btn_gestionInscription.Text = "Gestion Inscriptions";
            this.btn_gestionInscription.UseVisualStyleBackColor = true;
            this.btn_gestionInscription.Click += new System.EventHandler(this.btn_gestionInscription_Click);
            // 
            // btn_gestionEnseignants
            // 
            this.btn_gestionEnseignants.Location = new System.Drawing.Point(33, 187);
            this.btn_gestionEnseignants.Name = "btn_gestionEnseignants";
            this.btn_gestionEnseignants.Size = new System.Drawing.Size(145, 35);
            this.btn_gestionEnseignants.TabIndex = 2;
            this.btn_gestionEnseignants.Text = "Gestion Enseignants";
            this.btn_gestionEnseignants.UseVisualStyleBackColor = true;
            this.btn_gestionEnseignants.Click += new System.EventHandler(this.btn_gestionEnseignants_Click);
            // 
            // btn_gestionClasses
            // 
            this.btn_gestionClasses.Location = new System.Drawing.Point(33, 296);
            this.btn_gestionClasses.Name = "btn_gestionClasses";
            this.btn_gestionClasses.Size = new System.Drawing.Size(145, 35);
            this.btn_gestionClasses.TabIndex = 3;
            this.btn_gestionClasses.Text = "Gestion Classes";
            this.btn_gestionClasses.UseVisualStyleBackColor = true;
            this.btn_gestionClasses.Click += new System.EventHandler(this.btn_gestionClasses_Click);
            // 
            // btn_gestionCours
            // 
            this.btn_gestionCours.Location = new System.Drawing.Point(356, 296);
            this.btn_gestionCours.Name = "btn_gestionCours";
            this.btn_gestionCours.Size = new System.Drawing.Size(145, 35);
            this.btn_gestionCours.TabIndex = 6;
            this.btn_gestionCours.Text = "Gestion Cours";
            this.btn_gestionCours.UseVisualStyleBackColor = true;
            this.btn_gestionCours.Click += new System.EventHandler(this.btn_gestionCours_Click);
            // 
            // btn_gestionMatieres
            // 
            this.btn_gestionMatieres.Location = new System.Drawing.Point(356, 187);
            this.btn_gestionMatieres.Name = "btn_gestionMatieres";
            this.btn_gestionMatieres.Size = new System.Drawing.Size(145, 35);
            this.btn_gestionMatieres.TabIndex = 5;
            this.btn_gestionMatieres.Text = "Gestion Matières";
            this.btn_gestionMatieres.UseVisualStyleBackColor = true;
            this.btn_gestionMatieres.Click += new System.EventHandler(this.btn_gestionMatieres_Click);
            // 
            // btn_gestionSalles
            // 
            this.btn_gestionSalles.Location = new System.Drawing.Point(356, 75);
            this.btn_gestionSalles.Name = "btn_gestionSalles";
            this.btn_gestionSalles.Size = new System.Drawing.Size(145, 35);
            this.btn_gestionSalles.TabIndex = 4;
            this.btn_gestionSalles.Text = "Gestion Salles";
            this.btn_gestionSalles.UseVisualStyleBackColor = true;
            this.btn_gestionSalles.Click += new System.EventHandler(this.btn_gestionSalles_Click);
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(557, 424);
            this.Controls.Add(this.btn_gestionCours);
            this.Controls.Add(this.btn_gestionMatieres);
            this.Controls.Add(this.btn_gestionSalles);
            this.Controls.Add(this.btn_gestionClasses);
            this.Controls.Add(this.btn_gestionEnseignants);
            this.Controls.Add(this.btn_gestionInscription);
            this.Controls.Add(this.lbl_accueil);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_accueil;
        private System.Windows.Forms.Button btn_gestionInscription;
        private System.Windows.Forms.Button btn_gestionEnseignants;
        private System.Windows.Forms.Button btn_gestionClasses;
        private System.Windows.Forms.Button btn_gestionCours;
        private System.Windows.Forms.Button btn_gestionMatieres;
        private System.Windows.Forms.Button btn_gestionSalles;
    }
}