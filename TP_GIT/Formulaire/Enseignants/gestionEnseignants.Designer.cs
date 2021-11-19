
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
            this.dgv_enseignants = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_enseignants)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajouterEnseignant
            // 
            this.btn_ajouterEnseignant.Location = new System.Drawing.Point(349, 55);
            this.btn_ajouterEnseignant.Name = "btn_ajouterEnseignant";
            this.btn_ajouterEnseignant.Size = new System.Drawing.Size(153, 38);
            this.btn_ajouterEnseignant.TabIndex = 0;
            this.btn_ajouterEnseignant.Text = "Ajouter un enseignant";
            this.btn_ajouterEnseignant.UseVisualStyleBackColor = true;
            this.btn_ajouterEnseignant.Click += new System.EventHandler(this.btn_ajouterEnseignant_Click);
            // 
            // dgv_enseignants
            // 
            this.dgv_enseignants.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_enseignants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_enseignants.Location = new System.Drawing.Point(12, 55);
            this.dgv_enseignants.Name = "dgv_enseignants";
            this.dgv_enseignants.Size = new System.Drawing.Size(256, 237);
            this.dgv_enseignants.TabIndex = 1;
            this.dgv_enseignants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_enseignants_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Accueil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gestionEnseignants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_enseignants);
            this.Controls.Add(this.btn_ajouterEnseignant);
            this.Name = "gestionEnseignants";
            this.Text = "gestionEnseignants";
            this.Load += new System.EventHandler(this.gestionEnseignants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_enseignants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouterEnseignant;
        private System.Windows.Forms.DataGridView dgv_enseignants;
        private System.Windows.Forms.Button button1;
    }
}