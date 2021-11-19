
namespace TP_GIT.Formulaire.Enseignants
{
    partial class ajouterEnseignant
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
            this.btn_addEnseignant = new System.Windows.Forms.Button();
            this.date_embauche = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateEmbauche = new System.Windows.Forms.Label();
            this.txt_rue = new System.Windows.Forms.TextBox();
            this.lbl_rue = new System.Windows.Forms.Label();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.lbl_cp = new System.Windows.Forms.Label();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_prenomEnseignant = new System.Windows.Forms.TextBox();
            this.lbl_prenomEmploye = new System.Windows.Forms.Label();
            this.lbl_nomEmploye = new System.Windows.Forms.Label();
            this.txt_nomEnseignant = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addEnseignant
            // 
            this.btn_addEnseignant.Location = new System.Drawing.Point(166, 371);
            this.btn_addEnseignant.Name = "btn_addEnseignant";
            this.btn_addEnseignant.Size = new System.Drawing.Size(139, 23);
            this.btn_addEnseignant.TabIndex = 44;
            this.btn_addEnseignant.Text = "Ajouter l\'employé";
            this.btn_addEnseignant.UseVisualStyleBackColor = true;
            this.btn_addEnseignant.Click += new System.EventHandler(this.btn_addEnseignant_Click);
            // 
            // date_embauche
            // 
            this.date_embauche.Location = new System.Drawing.Point(294, 303);
            this.date_embauche.Name = "date_embauche";
            this.date_embauche.Size = new System.Drawing.Size(180, 20);
            this.date_embauche.TabIndex = 39;
            // 
            // lbl_dateEmbauche
            // 
            this.lbl_dateEmbauche.AutoSize = true;
            this.lbl_dateEmbauche.Location = new System.Drawing.Point(291, 276);
            this.lbl_dateEmbauche.Name = "lbl_dateEmbauche";
            this.lbl_dateEmbauche.Size = new System.Drawing.Size(97, 13);
            this.lbl_dateEmbauche.TabIndex = 38;
            this.lbl_dateEmbauche.Text = "Date d\'embauche :";
            // 
            // txt_rue
            // 
            this.txt_rue.Location = new System.Drawing.Point(294, 92);
            this.txt_rue.Name = "txt_rue";
            this.txt_rue.Size = new System.Drawing.Size(158, 20);
            this.txt_rue.TabIndex = 35;
            // 
            // lbl_rue
            // 
            this.lbl_rue.AutoSize = true;
            this.lbl_rue.Location = new System.Drawing.Point(291, 64);
            this.lbl_rue.Name = "lbl_rue";
            this.lbl_rue.Size = new System.Drawing.Size(33, 13);
            this.lbl_rue.TabIndex = 34;
            this.lbl_rue.Text = "Rue :";
            // 
            // txt_cp
            // 
            this.txt_cp.Location = new System.Drawing.Point(27, 303);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(158, 20);
            this.txt_cp.TabIndex = 33;
            // 
            // lbl_cp
            // 
            this.lbl_cp.AutoSize = true;
            this.lbl_cp.Location = new System.Drawing.Point(24, 276);
            this.lbl_cp.Name = "lbl_cp";
            this.lbl_cp.Size = new System.Drawing.Size(69, 13);
            this.lbl_cp.TabIndex = 32;
            this.lbl_cp.Text = "Code postal :";
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(27, 233);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(161, 20);
            this.txt_ville.TabIndex = 31;
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Location = new System.Drawing.Point(24, 207);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(32, 13);
            this.lbl_ville.TabIndex = 30;
            this.lbl_ville.Text = "Ville :";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(291, 163);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(161, 20);
            this.txt_tel.TabIndex = 29;
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(291, 133);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(115, 13);
            this.lbl_tel.TabIndex = 28;
            this.lbl_tel.Text = "Numéro de téléphone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ajout d\'un enseignant";
            // 
            // txt_prenomEnseignant
            // 
            this.txt_prenomEnseignant.Location = new System.Drawing.Point(27, 163);
            this.txt_prenomEnseignant.Name = "txt_prenomEnseignant";
            this.txt_prenomEnseignant.Size = new System.Drawing.Size(161, 20);
            this.txt_prenomEnseignant.TabIndex = 26;
            // 
            // lbl_prenomEmploye
            // 
            this.lbl_prenomEmploye.AutoSize = true;
            this.lbl_prenomEmploye.Location = new System.Drawing.Point(27, 133);
            this.lbl_prenomEmploye.Name = "lbl_prenomEmploye";
            this.lbl_prenomEmploye.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenomEmploye.TabIndex = 25;
            this.lbl_prenomEmploye.Text = "Prénom :";
            // 
            // lbl_nomEmploye
            // 
            this.lbl_nomEmploye.AutoSize = true;
            this.lbl_nomEmploye.Location = new System.Drawing.Point(24, 64);
            this.lbl_nomEmploye.Name = "lbl_nomEmploye";
            this.lbl_nomEmploye.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomEmploye.TabIndex = 24;
            this.lbl_nomEmploye.Text = "Nom :";
            // 
            // txt_nomEnseignant
            // 
            this.txt_nomEnseignant.Location = new System.Drawing.Point(27, 92);
            this.txt_nomEnseignant.Name = "txt_nomEnseignant";
            this.txt_nomEnseignant.Size = new System.Drawing.Size(161, 20);
            this.txt_nomEnseignant.TabIndex = 23;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(294, 233);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(158, 20);
            this.txt_email.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Email :";
            // 
            // ajouterEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 426);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addEnseignant);
            this.Controls.Add(this.date_embauche);
            this.Controls.Add(this.lbl_dateEmbauche);
            this.Controls.Add(this.txt_rue);
            this.Controls.Add(this.lbl_rue);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(this.lbl_cp);
            this.Controls.Add(this.txt_ville);
            this.Controls.Add(this.lbl_ville);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_prenomEnseignant);
            this.Controls.Add(this.lbl_prenomEmploye);
            this.Controls.Add(this.lbl_nomEmploye);
            this.Controls.Add(this.txt_nomEnseignant);
            this.Name = "ajouterEnseignant";
            this.Text = "AjouterEnseignant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addEnseignant;
        private System.Windows.Forms.DateTimePicker date_embauche;
        private System.Windows.Forms.Label lbl_dateEmbauche;
        private System.Windows.Forms.TextBox txt_rue;
        private System.Windows.Forms.Label lbl_rue;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.Label lbl_cp;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_prenomEnseignant;
        private System.Windows.Forms.Label lbl_prenomEmploye;
        private System.Windows.Forms.Label lbl_nomEmploye;
        private System.Windows.Forms.TextBox txt_nomEnseignant;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
    }
}