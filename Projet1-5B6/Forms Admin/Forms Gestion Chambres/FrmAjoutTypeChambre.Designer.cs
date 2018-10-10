namespace Projet1_5B6.Forms_Admin
{
    partial class FrmAjoutTypeChambre
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label noTypeChambreLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label prixHautLabel;
            System.Windows.Forms.Label prixBasLabel;
            System.Windows.Forms.Label prixMoyenLabel;
            this.tbNoType = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPrixHaut = new System.Windows.Forms.TextBox();
            this.tbPrixBas = new System.Windows.Forms.TextBox();
            this.tbPrixMoyen = new System.Windows.Forms.TextBox();
            this.lblEntete = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            noTypeChambreLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            prixHautLabel = new System.Windows.Forms.Label();
            prixBasLabel = new System.Windows.Forms.Label();
            prixMoyenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // noTypeChambreLabel
            // 
            noTypeChambreLabel.AutoSize = true;
            noTypeChambreLabel.Location = new System.Drawing.Point(27, 94);
            noTypeChambreLabel.Name = "noTypeChambreLabel";
            noTypeChambreLabel.Size = new System.Drawing.Size(33, 20);
            noTypeChambreLabel.TabIndex = 1;
            noTypeChambreLabel.Text = "No:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(27, 126);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // prixHautLabel
            // 
            prixHautLabel.AutoSize = true;
            prixHautLabel.Location = new System.Drawing.Point(27, 158);
            prixHautLabel.Name = "prixHautLabel";
            prixHautLabel.Size = new System.Drawing.Size(77, 20);
            prixHautLabel.TabIndex = 5;
            prixHautLabel.Text = "Prix Haut:";
            // 
            // prixBasLabel
            // 
            prixBasLabel.AutoSize = true;
            prixBasLabel.Location = new System.Drawing.Point(27, 190);
            prixBasLabel.Name = "prixBasLabel";
            prixBasLabel.Size = new System.Drawing.Size(70, 20);
            prixBasLabel.TabIndex = 7;
            prixBasLabel.Text = "Prix Bas:";
            // 
            // prixMoyenLabel
            // 
            prixMoyenLabel.AutoSize = true;
            prixMoyenLabel.Location = new System.Drawing.Point(27, 222);
            prixMoyenLabel.Name = "prixMoyenLabel";
            prixMoyenLabel.Size = new System.Drawing.Size(89, 20);
            prixMoyenLabel.TabIndex = 9;
            prixMoyenLabel.Text = "Prix Moyen:";
            // 
            // tbNoType
            // 
            this.tbNoType.Location = new System.Drawing.Point(173, 91);
            this.tbNoType.Name = "tbNoType";
            this.tbNoType.ReadOnly = true;
            this.tbNoType.Size = new System.Drawing.Size(207, 26);
            this.tbNoType.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(173, 123);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(207, 26);
            this.tbDescription.TabIndex = 4;
            // 
            // tbPrixHaut
            // 
            this.tbPrixHaut.Location = new System.Drawing.Point(173, 155);
            this.tbPrixHaut.Name = "tbPrixHaut";
            this.tbPrixHaut.Size = new System.Drawing.Size(207, 26);
            this.tbPrixHaut.TabIndex = 6;
            // 
            // tbPrixBas
            // 
            this.tbPrixBas.Location = new System.Drawing.Point(173, 187);
            this.tbPrixBas.Name = "tbPrixBas";
            this.tbPrixBas.Size = new System.Drawing.Size(207, 26);
            this.tbPrixBas.TabIndex = 8;
            // 
            // tbPrixMoyen
            // 
            this.tbPrixMoyen.Location = new System.Drawing.Point(173, 219);
            this.tbPrixMoyen.Name = "tbPrixMoyen";
            this.tbPrixMoyen.Size = new System.Drawing.Size(207, 26);
            this.tbPrixMoyen.TabIndex = 10;
            // 
            // lblEntete
            // 
            this.lblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntete.Location = new System.Drawing.Point(31, 9);
            this.lblEntete.Name = "lblEntete";
            this.lblEntete.Size = new System.Drawing.Size(349, 79);
            this.lblEntete.TabIndex = 11;
            this.lblEntete.Text = "Ajout d\'un type de chambre";
            this.lblEntete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(121, 268);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(167, 41);
            this.btnConfirmer.TabIndex = 12;
            this.btnConfirmer.Text = "Confirmer l\'ajout";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmAjoutTypeChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 342);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblEntete);
            this.Controls.Add(noTypeChambreLabel);
            this.Controls.Add(this.tbNoType);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(prixHautLabel);
            this.Controls.Add(this.tbPrixHaut);
            this.Controls.Add(prixBasLabel);
            this.Controls.Add(this.tbPrixBas);
            this.Controls.Add(prixMoyenLabel);
            this.Controls.Add(this.tbPrixMoyen);
            this.Name = "FrmAjoutTypeChambre";
            this.Text = "Ajout type de chambre";
            this.Load += new System.EventHandler(this.FrmAjoutTypeChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNoType;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPrixHaut;
        private System.Windows.Forms.TextBox tbPrixBas;
        private System.Windows.Forms.TextBox tbPrixMoyen;
        private System.Windows.Forms.Label lblEntete;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}