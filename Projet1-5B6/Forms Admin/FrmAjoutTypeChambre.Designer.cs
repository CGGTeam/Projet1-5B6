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
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TypeChambreTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.tbNoType = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPrixHaut = new System.Windows.Forms.TextBox();
            this.tbPrixBas = new System.Windows.Forms.TextBox();
            this.tbPrixMoyen = new System.Windows.Forms.TextBox();
            this.lblEntete = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            noTypeChambreLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            prixHautLabel = new System.Windows.Forms.Label();
            prixBasLabel = new System.Windows.Forms.Label();
            prixMoyenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD5B6TP1_ConstantinBrassardLaheyDataSet
            // 
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.DataSetName = "BD5B6TP1_ConstantinBrassardLaheyDataSet";
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeChambreBindingSource
            // 
            this.typeChambreBindingSource.DataMember = "TypeChambre";
            this.typeChambreBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = this.typeChambreTableAdapter;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // noTypeChambreLabel
            // 
            noTypeChambreLabel.AutoSize = true;
            noTypeChambreLabel.Location = new System.Drawing.Point(12, 94);
            noTypeChambreLabel.Name = "noTypeChambreLabel";
            noTypeChambreLabel.Size = new System.Drawing.Size(33, 20);
            noTypeChambreLabel.TabIndex = 1;
            noTypeChambreLabel.Text = "No:";
            // 
            // tbNoType
            // 
            this.tbNoType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "NoTypeChambre", true));
            this.tbNoType.Location = new System.Drawing.Point(158, 91);
            this.tbNoType.Name = "tbNoType";
            this.tbNoType.ReadOnly = true;
            this.tbNoType.Size = new System.Drawing.Size(207, 26);
            this.tbNoType.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 126);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "Description", true));
            this.tbDescription.Location = new System.Drawing.Point(158, 123);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(207, 26);
            this.tbDescription.TabIndex = 4;
            // 
            // prixHautLabel
            // 
            prixHautLabel.AutoSize = true;
            prixHautLabel.Location = new System.Drawing.Point(12, 158);
            prixHautLabel.Name = "prixHautLabel";
            prixHautLabel.Size = new System.Drawing.Size(77, 20);
            prixHautLabel.TabIndex = 5;
            prixHautLabel.Text = "Prix Haut:";
            // 
            // tbPrixHaut
            // 
            this.tbPrixHaut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "PrixHaut", true));
            this.tbPrixHaut.Location = new System.Drawing.Point(158, 155);
            this.tbPrixHaut.Name = "tbPrixHaut";
            this.tbPrixHaut.Size = new System.Drawing.Size(207, 26);
            this.tbPrixHaut.TabIndex = 6;
            // 
            // prixBasLabel
            // 
            prixBasLabel.AutoSize = true;
            prixBasLabel.Location = new System.Drawing.Point(12, 190);
            prixBasLabel.Name = "prixBasLabel";
            prixBasLabel.Size = new System.Drawing.Size(70, 20);
            prixBasLabel.TabIndex = 7;
            prixBasLabel.Text = "Prix Bas:";
            // 
            // tbPrixBas
            // 
            this.tbPrixBas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "PrixBas", true));
            this.tbPrixBas.Location = new System.Drawing.Point(158, 187);
            this.tbPrixBas.Name = "tbPrixBas";
            this.tbPrixBas.Size = new System.Drawing.Size(207, 26);
            this.tbPrixBas.TabIndex = 8;
            // 
            // prixMoyenLabel
            // 
            prixMoyenLabel.AutoSize = true;
            prixMoyenLabel.Location = new System.Drawing.Point(12, 222);
            prixMoyenLabel.Name = "prixMoyenLabel";
            prixMoyenLabel.Size = new System.Drawing.Size(89, 20);
            prixMoyenLabel.TabIndex = 9;
            prixMoyenLabel.Text = "Prix Moyen:";
            // 
            // tbPrixMoyen
            // 
            this.tbPrixMoyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "PrixMoyen", true));
            this.tbPrixMoyen.Location = new System.Drawing.Point(158, 219);
            this.tbPrixMoyen.Name = "tbPrixMoyen";
            this.tbPrixMoyen.Size = new System.Drawing.Size(207, 26);
            this.tbPrixMoyen.TabIndex = 10;
            // 
            // lblEntete
            // 
            this.lblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntete.Location = new System.Drawing.Point(16, 9);
            this.lblEntete.Name = "lblEntete";
            this.lblEntete.Size = new System.Drawing.Size(349, 79);
            this.lblEntete.TabIndex = 11;
            this.lblEntete.Text = "Ajout d\'un type de chambre";
            this.lblEntete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(106, 268);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(167, 41);
            this.btnConfirmer.TabIndex = 12;
            this.btnConfirmer.Text = "Confirmer l\'ajout";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // FrmAjoutTypeChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 342);
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
            this.Text = "FrmAjoutTypeChambre";
            this.Load += new System.EventHandler(this.FrmAjoutTypeChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TypeChambreTableAdapter typeChambreTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbNoType;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPrixHaut;
        private System.Windows.Forms.TextBox tbPrixBas;
        private System.Windows.Forms.TextBox tbPrixMoyen;
        private System.Windows.Forms.Label lblEntete;
        private System.Windows.Forms.Button btnConfirmer;
    }
}