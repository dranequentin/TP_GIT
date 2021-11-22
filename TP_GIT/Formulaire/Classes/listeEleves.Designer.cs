
namespace TP_GIT.Formulaire.Classes
{
    partial class listeEleves
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
            this.dgv_listeEleves = new System.Windows.Forms.DataGridView();
            this.btn_retour = new System.Windows.Forms.Button();
            this.lbl_nomClasse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeEleves)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listeEleves
            // 
            this.dgv_listeEleves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeEleves.Location = new System.Drawing.Point(12, 12);
            this.dgv_listeEleves.Name = "dgv_listeEleves";
            this.dgv_listeEleves.Size = new System.Drawing.Size(374, 307);
            this.dgv_listeEleves.TabIndex = 0;
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(311, 340);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(75, 23);
            this.btn_retour.TabIndex = 1;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // lbl_nomClasse
            // 
            this.lbl_nomClasse.AutoSize = true;
            this.lbl_nomClasse.Location = new System.Drawing.Point(13, 340);
            this.lbl_nomClasse.Name = "lbl_nomClasse";
            this.lbl_nomClasse.Size = new System.Drawing.Size(160, 13);
            this.lbl_nomClasse.TabIndex = 2;
            this.lbl_nomClasse.Text = "Liste des élèves de la classe de ";
            // 
            // listeEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 377);
            this.Controls.Add(this.lbl_nomClasse);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.dgv_listeEleves);
            this.Name = "listeEleves";
            this.Text = "listeEleves";
            this.Load += new System.EventHandler(this.listeEleves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeEleves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listeEleves;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Label lbl_nomClasse;
    }
}