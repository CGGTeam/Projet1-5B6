namespace Projet1_5B6
{
    partial class FrmConnexion
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
            this.tbNomUtilisateur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMotDePasse = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblEnteteConnexion = new System.Windows.Forms.Label();
            this.lblErrorProvider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNomUtilisateur
            // 
            this.tbNomUtilisateur.Location = new System.Drawing.Point(208, 38);
            this.tbNomUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomUtilisateur.Name = "tbNomUtilisateur";
            this.tbNomUtilisateur.Size = new System.Drawing.Size(150, 20);
            this.tbNomUtilisateur.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom d\'utilisateur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe:";
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(208, 57);
            this.tbMotDePasse.Margin = new System.Windows.Forms.Padding(2);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.Size = new System.Drawing.Size(150, 20);
            this.tbMotDePasse.TabIndex = 2;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(208, 90);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(149, 37);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblEnteteConnexion
            // 
            this.lblEnteteConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnteteConnexion.Location = new System.Drawing.Point(-1, 6);
            this.lblEnteteConnexion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnteteConnexion.Name = "lblEnteteConnexion";
            this.lblEnteteConnexion.Size = new System.Drawing.Size(335, 24);
            this.lblEnteteConnexion.TabIndex = 5;
            this.lblEnteteConnexion.Text = "Connexion";
            this.lblEnteteConnexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorProvider
            // 
            this.lblErrorProvider.AutoSize = true;
            this.lblErrorProvider.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProvider.Location = new System.Drawing.Point(136, 131);
            this.lblErrorProvider.Name = "lblErrorProvider";
            this.lblErrorProvider.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProvider.TabIndex = 6;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 169);
            this.Controls.Add(this.lblErrorProvider);
            this.Controls.Add(this.lblEnteteConnexion);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNomUtilisateur);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConnexion";
            this.Text = "Bienvenue chez Hôtel Plage Santé™";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMotDePasse;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblEnteteConnexion;
        private System.Windows.Forms.Label lblErrorProvider;
    }
}

