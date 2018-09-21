namespace Projet1_5B6.Forms_Admin.Forms_Gestion_Assistants
{
    partial class FrmAddAssistant
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
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbRemarques = new System.Windows.Forms.TextBox();
            this.tbSpecialite = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErrorProvider = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(102, 12);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(124, 20);
            this.tbPrenom.TabIndex = 0;
            // 
            // tbRemarques
            // 
            this.tbRemarques.Location = new System.Drawing.Point(102, 90);
            this.tbRemarques.Name = "tbRemarques";
            this.tbRemarques.Size = new System.Drawing.Size(124, 20);
            this.tbRemarques.TabIndex = 2;
            // 
            // tbSpecialite
            // 
            this.tbSpecialite.Location = new System.Drawing.Point(102, 64);
            this.tbSpecialite.Name = "tbSpecialite";
            this.tbSpecialite.Size = new System.Drawing.Size(124, 20);
            this.tbSpecialite.TabIndex = 3;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(102, 38);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(124, 20);
            this.tbNom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prénom * :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom * :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Spécialité * :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Remarques :";
            // 
            // lblErrorProvider
            // 
            this.lblErrorProvider.AutoSize = true;
            this.lblErrorProvider.ForeColor = System.Drawing.Color.Black;
            this.lblErrorProvider.Location = new System.Drawing.Point(22, 124);
            this.lblErrorProvider.Name = "lblErrorProvider";
            this.lblErrorProvider.Size = new System.Drawing.Size(192, 13);
            this.lblErrorProvider.TabIndex = 9;
            this.lblErrorProvider.Text = "Les champs avec un * sont obligatoires";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Red;
            this.btnAnnuler.Location = new System.Drawing.Point(13, 141);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(102, 41);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmer.Location = new System.Drawing.Point(124, 141);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(102, 41);
            this.btnConfirmer.TabIndex = 11;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // FrmAddAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 196);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.lblErrorProvider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbSpecialite);
            this.Controls.Add(this.tbRemarques);
            this.Controls.Add(this.tbPrenom);
            this.Name = "FrmAddAssistant";
            this.Text = "FrmAddAssistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbRemarques;
        private System.Windows.Forms.TextBox tbSpecialite;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorProvider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
    }
}