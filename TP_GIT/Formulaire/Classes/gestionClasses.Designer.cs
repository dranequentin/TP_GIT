
namespace TP_GIT.Formulaire.Classes
{
    partial class gestionClasses
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
            this.dgv_classes = new System.Windows.Forms.DataGridView();
            this.btn_retour = new System.Windows.Forms.Button();
            this.btn_ajouterClasse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_classes
            // 
            this.dgv_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_classes.Location = new System.Drawing.Point(12, 23);
            this.dgv_classes.Name = "dgv_classes";
            this.dgv_classes.Size = new System.Drawing.Size(192, 319);
            this.dgv_classes.TabIndex = 0;
            this.dgv_classes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_classes_CellContentClick);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(228, 298);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(75, 23);
            this.btn_retour.TabIndex = 1;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // btn_ajouterClasse
            // 
            this.btn_ajouterClasse.Location = new System.Drawing.Point(228, 40);
            this.btn_ajouterClasse.Name = "btn_ajouterClasse";
            this.btn_ajouterClasse.Size = new System.Drawing.Size(75, 34);
            this.btn_ajouterClasse.TabIndex = 2;
            this.btn_ajouterClasse.Text = "Ajouter une classe";
            this.btn_ajouterClasse.UseVisualStyleBackColor = true;
            this.btn_ajouterClasse.Click += new System.EventHandler(this.btn_ajouterClasse_Click);
            // 
            // gestionClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 363);
            this.Controls.Add(this.btn_ajouterClasse);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.dgv_classes);
            this.Name = "gestionClasses";
            this.Text = "gestionClasses";
            this.Load += new System.EventHandler(this.gestionClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_classes;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Button btn_ajouterClasse;
    }
}