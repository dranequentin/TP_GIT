
namespace TP_GIT.Formulaire.Inscrits
{
    partial class ajouterInscrit
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_addEleve = new System.Windows.Forms.Button();
            this.date_validation = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateValidation = new System.Windows.Forms.Label();
            this.txt_rue = new System.Windows.Forms.TextBox();
            this.lbl_rue = new System.Windows.Forms.Label();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.lbl_cp = new System.Windows.Forms.Label();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_ajout = new System.Windows.Forms.Label();
            this.txt_prenomEleve = new System.Windows.Forms.TextBox();
            this.lbl_prenomEleve = new System.Windows.Forms.Label();
            this.lbl_nomEleve = new System.Windows.Forms.Label();
            this.txt_nomEleve = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(304, 243);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(158, 20);
            this.txt_email.TabIndex = 64;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(301, 217);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 63;
            this.lbl_email.Text = "Email :";
            // 
            // btn_addEleve
            // 
            this.btn_addEleve.Location = new System.Drawing.Point(176, 381);
            this.btn_addEleve.Name = "btn_addEleve";
            this.btn_addEleve.Size = new System.Drawing.Size(139, 23);
            this.btn_addEleve.TabIndex = 62;
            this.btn_addEleve.Text = "Ajouter l\'élève";
            this.btn_addEleve.UseVisualStyleBackColor = true;
            this.btn_addEleve.Click += new System.EventHandler(this.btn_addEleve_Click);
            // 
            // date_validation
            // 
            this.date_validation.Location = new System.Drawing.Point(304, 313);
            this.date_validation.Name = "date_validation";
            this.date_validation.Size = new System.Drawing.Size(180, 20);
            this.date_validation.TabIndex = 61;
            // 
            // lbl_dateValidation
            // 
            this.lbl_dateValidation.AutoSize = true;
            this.lbl_dateValidation.Location = new System.Drawing.Point(301, 286);
            this.lbl_dateValidation.Name = "lbl_dateValidation";
            this.lbl_dateValidation.Size = new System.Drawing.Size(93, 13);
            this.lbl_dateValidation.TabIndex = 60;
            this.lbl_dateValidation.Text = "Date de validation";
            // 
            // txt_rue
            // 
            this.txt_rue.Location = new System.Drawing.Point(304, 102);
            this.txt_rue.Name = "txt_rue";
            this.txt_rue.Size = new System.Drawing.Size(158, 20);
            this.txt_rue.TabIndex = 59;
            // 
            // lbl_rue
            // 
            this.lbl_rue.AutoSize = true;
            this.lbl_rue.Location = new System.Drawing.Point(301, 74);
            this.lbl_rue.Name = "lbl_rue";
            this.lbl_rue.Size = new System.Drawing.Size(33, 13);
            this.lbl_rue.TabIndex = 58;
            this.lbl_rue.Text = "Rue :";
            // 
            // txt_cp
            // 
            this.txt_cp.Location = new System.Drawing.Point(37, 313);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(158, 20);
            this.txt_cp.TabIndex = 57;
            // 
            // lbl_cp
            // 
            this.lbl_cp.AutoSize = true;
            this.lbl_cp.Location = new System.Drawing.Point(34, 286);
            this.lbl_cp.Name = "lbl_cp";
            this.lbl_cp.Size = new System.Drawing.Size(69, 13);
            this.lbl_cp.TabIndex = 56;
            this.lbl_cp.Text = "Code postal :";
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(37, 243);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(161, 20);
            this.txt_ville.TabIndex = 55;
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Location = new System.Drawing.Point(34, 217);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(32, 13);
            this.lbl_ville.TabIndex = 54;
            this.lbl_ville.Text = "Ville :";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(301, 173);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(161, 20);
            this.txt_tel.TabIndex = 53;
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(301, 143);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(115, 13);
            this.lbl_tel.TabIndex = 52;
            this.lbl_tel.Text = "Numéro de téléphone :";
            // 
            // lbl_ajout
            // 
            this.lbl_ajout.AutoSize = true;
            this.lbl_ajout.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajout.Location = new System.Drawing.Point(33, 30);
            this.lbl_ajout.Name = "lbl_ajout";
            this.lbl_ajout.Size = new System.Drawing.Size(162, 23);
            this.lbl_ajout.TabIndex = 51;
            this.lbl_ajout.Text = "Ajout d\'un(e) élève";
            // 
            // txt_prenomEleve
            // 
            this.txt_prenomEleve.Location = new System.Drawing.Point(37, 173);
            this.txt_prenomEleve.Name = "txt_prenomEleve";
            this.txt_prenomEleve.Size = new System.Drawing.Size(161, 20);
            this.txt_prenomEleve.TabIndex = 50;
            // 
            // lbl_prenomEleve
            // 
            this.lbl_prenomEleve.AutoSize = true;
            this.lbl_prenomEleve.Location = new System.Drawing.Point(37, 143);
            this.lbl_prenomEleve.Name = "lbl_prenomEleve";
            this.lbl_prenomEleve.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenomEleve.TabIndex = 49;
            this.lbl_prenomEleve.Text = "Prénom :";
            // 
            // lbl_nomEleve
            // 
            this.lbl_nomEleve.AutoSize = true;
            this.lbl_nomEleve.Location = new System.Drawing.Point(34, 74);
            this.lbl_nomEleve.Name = "lbl_nomEleve";
            this.lbl_nomEleve.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomEleve.TabIndex = 48;
            this.lbl_nomEleve.Text = "Nom :";
            // 
            // txt_nomEleve
            // 
            this.txt_nomEleve.Location = new System.Drawing.Point(37, 102);
            this.txt_nomEleve.Name = "txt_nomEleve";
            this.txt_nomEleve.Size = new System.Drawing.Size(161, 20);
            this.txt_nomEleve.TabIndex = 47;
            // 
            // ajouterInscrit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_addEleve);
            this.Controls.Add(this.date_validation);
            this.Controls.Add(this.lbl_dateValidation);
            this.Controls.Add(this.txt_rue);
            this.Controls.Add(this.lbl_rue);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(this.lbl_cp);
            this.Controls.Add(this.txt_ville);
            this.Controls.Add(this.lbl_ville);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_ajout);
            this.Controls.Add(this.txt_prenomEleve);
            this.Controls.Add(this.lbl_prenomEleve);
            this.Controls.Add(this.lbl_nomEleve);
            this.Controls.Add(this.txt_nomEleve);
            this.Name = "ajouterInscrit";
            this.Text = "ajouterInscrit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_addEleve;
        private System.Windows.Forms.DateTimePicker date_validation;
        private System.Windows.Forms.Label lbl_dateValidation;
        private System.Windows.Forms.TextBox txt_rue;
        private System.Windows.Forms.Label lbl_rue;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.Label lbl_cp;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_ajout;
        private System.Windows.Forms.TextBox txt_prenomEleve;
        private System.Windows.Forms.Label lbl_prenomEleve;
        private System.Windows.Forms.Label lbl_nomEleve;
        private System.Windows.Forms.TextBox txt_nomEleve;
    }
}