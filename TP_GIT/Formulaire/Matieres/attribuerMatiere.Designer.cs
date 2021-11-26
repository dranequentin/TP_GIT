
namespace TP_GIT.Formulaire.Matieres
{
    partial class attribuerMatiere
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
            this.cbb_enseignants = new System.Windows.Forms.ComboBox();
            this.clb_matiere = new System.Windows.Forms.CheckedListBox();
            this.btn_attribuerMatiere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbb_enseignants
            // 
            this.cbb_enseignants.FormattingEnabled = true;
            this.cbb_enseignants.Location = new System.Drawing.Point(24, 115);
            this.cbb_enseignants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_enseignants.Name = "cbb_enseignants";
            this.cbb_enseignants.Size = new System.Drawing.Size(160, 26);
            this.cbb_enseignants.TabIndex = 0;
            // 
            // clb_matiere
            // 
            this.clb_matiere.FormattingEnabled = true;
            this.clb_matiere.Location = new System.Drawing.Point(288, 115);
            this.clb_matiere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clb_matiere.Name = "clb_matiere";
            this.clb_matiere.Size = new System.Drawing.Size(159, 130);
            this.clb_matiere.TabIndex = 2;
            // 
            // btn_attribuerMatiere
            // 
            this.btn_attribuerMatiere.Location = new System.Drawing.Point(65, 197);
            this.btn_attribuerMatiere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_attribuerMatiere.Name = "btn_attribuerMatiere";
            this.btn_attribuerMatiere.Size = new System.Drawing.Size(119, 48);
            this.btn_attribuerMatiere.TabIndex = 3;
            this.btn_attribuerMatiere.Text = "Attribuer les matières";
            this.btn_attribuerMatiere.UseVisualStyleBackColor = true;
            this.btn_attribuerMatiere.Click += new System.EventHandler(this.btn_attribuerMatiere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Attribution de matière";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choix de l\'enseignant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choix des matiéres";
            // 
            // attribuerMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_attribuerMatiere);
            this.Controls.Add(this.clb_matiere);
            this.Controls.Add(this.cbb_enseignants);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "attribuerMatiere";
            this.Text = "attribuerMatiere";
            this.Load += new System.EventHandler(this.attribuerMatiere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_enseignants;
        private System.Windows.Forms.CheckedListBox clb_matiere;
        private System.Windows.Forms.Button btn_attribuerMatiere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}