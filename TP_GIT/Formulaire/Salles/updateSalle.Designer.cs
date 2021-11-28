
namespace TP_GIT.Formulaire.Salles
{
    partial class updateSalle
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
            this.btn_updateSalle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_updateNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_updateSalle
            // 
            this.btn_updateSalle.Location = new System.Drawing.Point(104, 198);
            this.btn_updateSalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_updateSalle.Name = "btn_updateSalle";
            this.btn_updateSalle.Size = new System.Drawing.Size(133, 42);
            this.btn_updateSalle.TabIndex = 7;
            this.btn_updateSalle.Text = "Modifier la salle";
            this.btn_updateSalle.UseVisualStyleBackColor = true;
            this.btn_updateSalle.Click += new System.EventHandler(this.btn_updateSalle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nouveau nom";
            // 
            // txt_updateNom
            // 
            this.txt_updateNom.Location = new System.Drawing.Point(104, 121);
            this.txt_updateNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_updateNom.Name = "txt_updateNom";
            this.txt_updateNom.Size = new System.Drawing.Size(132, 26);
            this.txt_updateNom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modification du nom de la salle";
            // 
            // updateSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 285);
            this.Controls.Add(this.btn_updateSalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_updateNom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "updateSalle";
            this.Text = "updateSalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_updateSalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_updateNom;
        private System.Windows.Forms.Label label1;
    }
}