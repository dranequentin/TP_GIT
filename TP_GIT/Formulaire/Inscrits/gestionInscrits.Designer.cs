
namespace TP_GIT.Formulaire.Inscrits
{
    partial class gestionInscrits
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
            this.dgv_inscrits = new System.Windows.Forms.DataGridView();
            this.btn_ajouterInscrit = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inscrits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_inscrits
            // 
            this.dgv_inscrits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_inscrits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inscrits.Location = new System.Drawing.Point(12, 12);
            this.dgv_inscrits.Name = "dgv_inscrits";
            this.dgv_inscrits.Size = new System.Drawing.Size(314, 351);
            this.dgv_inscrits.TabIndex = 0;
            // 
            // btn_ajouterInscrit
            // 
            this.btn_ajouterInscrit.Location = new System.Drawing.Point(363, 31);
            this.btn_ajouterInscrit.Name = "btn_ajouterInscrit";
            this.btn_ajouterInscrit.Size = new System.Drawing.Size(75, 40);
            this.btn_ajouterInscrit.TabIndex = 1;
            this.btn_ajouterInscrit.Text = "Ajouter un(e) élève";
            this.btn_ajouterInscrit.UseVisualStyleBackColor = true;
            this.btn_ajouterInscrit.Click += new System.EventHandler(this.btn_ajouterInscrit_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(363, 307);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(75, 23);
            this.btn_retour.TabIndex = 2;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click_1);
            // 
            // gestionInscrits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 381);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_ajouterInscrit);
            this.Controls.Add(this.dgv_inscrits);
            this.Name = "gestionInscrits";
            this.Text = "gestionInscrits";
            this.Load += new System.EventHandler(this.gestionInscrits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inscrits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_inscrits;
        private System.Windows.Forms.Button btn_ajouterInscrit;
        private System.Windows.Forms.Button btn_retour;
    }
}