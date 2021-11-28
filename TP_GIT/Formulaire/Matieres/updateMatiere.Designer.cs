
namespace TP_GIT.Formulaire.Matieres
{
    partial class updateMatiere
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
            this.txt_updateNomMatiere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_updateMatiere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modification du nom de la matière";
            // 
            // txt_updateNomMatiere
            // 
            this.txt_updateNomMatiere.Location = new System.Drawing.Point(101, 134);
            this.txt_updateNomMatiere.Margin = new System.Windows.Forms.Padding(4);
            this.txt_updateNomMatiere.Name = "txt_updateNomMatiere";
            this.txt_updateNomMatiere.Size = new System.Drawing.Size(132, 26);
            this.txt_updateNomMatiere.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nouveau nom";
            // 
            // btn_updateMatiere
            // 
            this.btn_updateMatiere.Location = new System.Drawing.Point(100, 188);
            this.btn_updateMatiere.Margin = new System.Windows.Forms.Padding(4);
            this.btn_updateMatiere.Name = "btn_updateMatiere";
            this.btn_updateMatiere.Size = new System.Drawing.Size(133, 50);
            this.btn_updateMatiere.TabIndex = 3;
            this.btn_updateMatiere.Text = "Modifier la matière";
            this.btn_updateMatiere.UseVisualStyleBackColor = true;
            this.btn_updateMatiere.Click += new System.EventHandler(this.btn_updateMatiere_Click);
            // 
            // updateMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 309);
            this.Controls.Add(this.btn_updateMatiere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_updateNomMatiere);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "updateMatiere";
            this.Text = "updateMatiere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_updateNomMatiere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_updateMatiere;
    }
}