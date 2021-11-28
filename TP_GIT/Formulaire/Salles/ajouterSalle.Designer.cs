
namespace TP_GIT.Formulaire.Salles
{
    partial class ajouterSalle
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.lbl_ajouterMatiere = new System.Windows.Forms.Label();
            this.txt_salle = new System.Windows.Forms.TextBox();
            this.btn_ajouterSalle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ajout d\'une salle";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(217, 185);
            this.btn_annuler.Margin = new System.Windows.Forms.Padding(4);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(133, 32);
            this.btn_annuler.TabIndex = 12;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // lbl_ajouterMatiere
            // 
            this.lbl_ajouterMatiere.AutoSize = true;
            this.lbl_ajouterMatiere.Location = new System.Drawing.Point(108, 81);
            this.lbl_ajouterMatiere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ajouterMatiere.Name = "lbl_ajouterMatiere";
            this.lbl_ajouterMatiere.Size = new System.Drawing.Size(166, 13);
            this.lbl_ajouterMatiere.TabIndex = 11;
            this.lbl_ajouterMatiere.Text = "Insérer le nom de la nouvelle salle";
            // 
            // txt_salle
            // 
            this.txt_salle.Location = new System.Drawing.Point(86, 120);
            this.txt_salle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_salle.Name = "txt_salle";
            this.txt_salle.Size = new System.Drawing.Size(207, 20);
            this.txt_salle.TabIndex = 10;
            // 
            // btn_ajouterSalle
            // 
            this.btn_ajouterSalle.Location = new System.Drawing.Point(30, 185);
            this.btn_ajouterSalle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouterSalle.Name = "btn_ajouterSalle";
            this.btn_ajouterSalle.Size = new System.Drawing.Size(133, 32);
            this.btn_ajouterSalle.TabIndex = 9;
            this.btn_ajouterSalle.Text = "Ajouter la salle";
            this.btn_ajouterSalle.UseVisualStyleBackColor = true;
            this.btn_ajouterSalle.Click += new System.EventHandler(this.btn_ajouterSalle_Click);
            // 
            // ajouterSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.lbl_ajouterMatiere);
            this.Controls.Add(this.txt_salle);
            this.Controls.Add(this.btn_ajouterSalle);
            this.Name = "ajouterSalle";
            this.Text = "ajouterSalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Label lbl_ajouterMatiere;
        private System.Windows.Forms.TextBox txt_salle;
        private System.Windows.Forms.Button btn_ajouterSalle;
    }
}