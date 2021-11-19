
namespace TP_GIT.Formulaire.Classes
{
    partial class ajouterClasse
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
            this.btn_ajouterClasse = new System.Windows.Forms.Button();
            this.txt_Classe = new System.Windows.Forms.TextBox();
            this.lbl_ajouterClasse = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ajouterClasse
            // 
            this.btn_ajouterClasse.Location = new System.Drawing.Point(12, 107);
            this.btn_ajouterClasse.Name = "btn_ajouterClasse";
            this.btn_ajouterClasse.Size = new System.Drawing.Size(100, 23);
            this.btn_ajouterClasse.TabIndex = 0;
            this.btn_ajouterClasse.Text = "Ajouter la classe";
            this.btn_ajouterClasse.UseVisualStyleBackColor = true;
            this.btn_ajouterClasse.Click += new System.EventHandler(this.btn_ajouterClasse_Click);
            // 
            // txt_Classe
            // 
            this.txt_Classe.Location = new System.Drawing.Point(54, 56);
            this.txt_Classe.Name = "txt_Classe";
            this.txt_Classe.Size = new System.Drawing.Size(129, 20);
            this.txt_Classe.TabIndex = 1;
            // 
            // lbl_ajouterClasse
            // 
            this.lbl_ajouterClasse.AutoSize = true;
            this.lbl_ajouterClasse.Location = new System.Drawing.Point(51, 26);
            this.lbl_ajouterClasse.Name = "lbl_ajouterClasse";
            this.lbl_ajouterClasse.Size = new System.Drawing.Size(132, 13);
            this.lbl_ajouterClasse.TabIndex = 2;
            this.lbl_ajouterClasse.Text = "Insérer le nom de la classe";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(118, 107);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(100, 23);
            this.btn_annuler.TabIndex = 3;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // ajouterClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 163);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.lbl_ajouterClasse);
            this.Controls.Add(this.txt_Classe);
            this.Controls.Add(this.btn_ajouterClasse);
            this.Name = "ajouterClasse";
            this.Text = "ajouterClasse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouterClasse;
        private System.Windows.Forms.TextBox txt_Classe;
        private System.Windows.Forms.Label lbl_ajouterClasse;
        private System.Windows.Forms.Button btn_annuler;
    }
}