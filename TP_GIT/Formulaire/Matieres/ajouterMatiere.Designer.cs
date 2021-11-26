
namespace TP_GIT.Formulaire.Matieres
{
    partial class ajouterMatiere
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
            this.btn_annuler = new System.Windows.Forms.Button();
            this.lbl_ajouterMatiere = new System.Windows.Forms.Label();
            this.txt_matiere = new System.Windows.Forms.TextBox();
            this.btn_ajouterClasse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(221, 194);
            this.btn_annuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(133, 32);
            this.btn_annuler.TabIndex = 7;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // lbl_ajouterMatiere
            // 
            this.lbl_ajouterMatiere.AutoSize = true;
            this.lbl_ajouterMatiere.Location = new System.Drawing.Point(77, 88);
            this.lbl_ajouterMatiere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ajouterMatiere.Name = "lbl_ajouterMatiere";
            this.lbl_ajouterMatiere.Size = new System.Drawing.Size(240, 18);
            this.lbl_ajouterMatiere.TabIndex = 6;
            this.lbl_ajouterMatiere.Text = "Insérer le nom de la nouvelle matière";
            // 
            // txt_matiere
            // 
            this.txt_matiere.Location = new System.Drawing.Point(90, 129);
            this.txt_matiere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_matiere.Name = "txt_matiere";
            this.txt_matiere.Size = new System.Drawing.Size(207, 26);
            this.txt_matiere.TabIndex = 5;
            // 
            // btn_ajouterClasse
            // 
            this.btn_ajouterClasse.Location = new System.Drawing.Point(34, 194);
            this.btn_ajouterClasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ajouterClasse.Name = "btn_ajouterClasse";
            this.btn_ajouterClasse.Size = new System.Drawing.Size(133, 32);
            this.btn_ajouterClasse.TabIndex = 4;
            this.btn_ajouterClasse.Text = "Ajouter la matière";
            this.btn_ajouterClasse.UseVisualStyleBackColor = true;
            this.btn_ajouterClasse.Click += new System.EventHandler(this.btn_ajouterClasse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ajout d\'une matière";
            // 
            // ajouterMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.lbl_ajouterMatiere);
            this.Controls.Add(this.txt_matiere);
            this.Controls.Add(this.btn_ajouterClasse);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ajouterMatiere";
            this.Text = "ajouterMatiere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Label lbl_ajouterMatiere;
        private System.Windows.Forms.TextBox txt_matiere;
        private System.Windows.Forms.Button btn_ajouterClasse;
        private System.Windows.Forms.Label label1;
    }
}