
namespace TP_GIT.Formulaire.Salles
{
    partial class gestionSalles
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
            this.btn_ajouterSalle = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.dgv_salles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gestion des salles";
            // 
            // btn_ajouterSalle
            // 
            this.btn_ajouterSalle.Location = new System.Drawing.Point(305, 70);
            this.btn_ajouterSalle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouterSalle.Name = "btn_ajouterSalle";
            this.btn_ajouterSalle.Size = new System.Drawing.Size(119, 55);
            this.btn_ajouterSalle.TabIndex = 10;
            this.btn_ajouterSalle.Text = "Ajouter une salle";
            this.btn_ajouterSalle.UseVisualStyleBackColor = true;
            this.btn_ajouterSalle.Click += new System.EventHandler(this.btn_ajouterSalle_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(305, 260);
            this.btn_retour.Margin = new System.Windows.Forms.Padding(4);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(119, 40);
            this.btn_retour.TabIndex = 9;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // dgv_salles
            // 
            this.dgv_salles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_salles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salles.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_salles.Location = new System.Drawing.Point(17, 70);
            this.dgv_salles.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_salles.Name = "dgv_salles";
            this.dgv_salles.Size = new System.Drawing.Size(256, 230);
            this.dgv_salles.TabIndex = 8;
            this.dgv_salles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_salles_CellContentClick);
            this.dgv_salles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_salles_CellContentClick);
            // 
            // gestionSalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ajouterSalle);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.dgv_salles);
            this.Name = "gestionSalles";
            this.Text = "gestionSalles";
            this.Load += new System.EventHandler(this.gestionSalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ajouterSalle;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.DataGridView dgv_salles;
    }
}