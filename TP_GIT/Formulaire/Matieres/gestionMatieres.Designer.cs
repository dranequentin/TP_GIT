
namespace TP_GIT.Formulaire.Matieres
{
    partial class gestionMatieres
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
            this.btn_ajouterMatiere = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.dgv_matiere = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_attribuerMatiere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matiere)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajouterMatiere
            // 
            this.btn_ajouterMatiere.Location = new System.Drawing.Point(309, 79);
            this.btn_ajouterMatiere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ajouterMatiere.Name = "btn_ajouterMatiere";
            this.btn_ajouterMatiere.Size = new System.Drawing.Size(119, 55);
            this.btn_ajouterMatiere.TabIndex = 5;
            this.btn_ajouterMatiere.Text = "Ajouter une matière";
            this.btn_ajouterMatiere.UseVisualStyleBackColor = true;
            this.btn_ajouterMatiere.Click += new System.EventHandler(this.btn_ajouterMatiere_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(309, 269);
            this.btn_retour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(119, 40);
            this.btn_retour.TabIndex = 4;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // dgv_matiere
            // 
            this.dgv_matiere.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_matiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_matiere.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_matiere.Location = new System.Drawing.Point(21, 79);
            this.dgv_matiere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_matiere.Name = "dgv_matiere";
            this.dgv_matiere.Size = new System.Drawing.Size(256, 230);
            this.dgv_matiere.TabIndex = 3;
            this.dgv_matiere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_matiere_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gestion des matiéres";
            // 
            // btn_attribuerMatiere
            // 
            this.btn_attribuerMatiere.Location = new System.Drawing.Point(309, 163);
            this.btn_attribuerMatiere.Name = "btn_attribuerMatiere";
            this.btn_attribuerMatiere.Size = new System.Drawing.Size(119, 78);
            this.btn_attribuerMatiere.TabIndex = 7;
            this.btn_attribuerMatiere.Text = "Attitrer un enseignant à une matière";
            this.btn_attribuerMatiere.UseVisualStyleBackColor = true;
            this.btn_attribuerMatiere.Click += new System.EventHandler(this.btn_attribuerMatiere_Click);
            // 
            // gestionMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 354);
            this.Controls.Add(this.btn_attribuerMatiere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ajouterMatiere);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.dgv_matiere);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "gestionMatieres";
            this.Text = "gestionMatieres";
            this.Load += new System.EventHandler(this.gestionMatieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouterMatiere;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.DataGridView dgv_matiere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_attribuerMatiere;
    }
}