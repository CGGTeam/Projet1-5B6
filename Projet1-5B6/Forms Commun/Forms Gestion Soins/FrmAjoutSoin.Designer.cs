namespace Projet1_5B6.Forms_Commun
{
    partial class FrmAjoutSoin
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
            System.Windows.Forms.Label noSoinLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dureeLabel;
            System.Windows.Forms.Label noTypeSoinLabel;
            System.Windows.Forms.Label prixLabel;
            this.tbNoSoin = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.typeSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeSoinTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TypeSoinTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.cmbTypeSoin = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            noSoinLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dureeLabel = new System.Windows.Forms.Label();
            noTypeSoinLabel = new System.Windows.Forms.Label();
            prixLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Location = new System.Drawing.Point(36, 64);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(69, 20);
            noSoinLabel.TabIndex = 1;
            noSoinLabel.Text = "No Soin:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(36, 96);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // dureeLabel
            // 
            dureeLabel.AutoSize = true;
            dureeLabel.Location = new System.Drawing.Point(36, 129);
            dureeLabel.Name = "dureeLabel";
            dureeLabel.Size = new System.Drawing.Size(57, 20);
            dureeLabel.TabIndex = 5;
            dureeLabel.Text = "Duree:";
            // 
            // noTypeSoinLabel
            // 
            noTypeSoinLabel.AutoSize = true;
            noTypeSoinLabel.Location = new System.Drawing.Point(36, 159);
            noTypeSoinLabel.Name = "noTypeSoinLabel";
            noTypeSoinLabel.Size = new System.Drawing.Size(107, 20);
            noTypeSoinLabel.TabIndex = 7;
            noTypeSoinLabel.Text = "No Type Soin:";
            // 
            // prixLabel
            // 
            prixLabel.AutoSize = true;
            prixLabel.Location = new System.Drawing.Point(36, 192);
            prixLabel.Name = "prixLabel";
            prixLabel.Size = new System.Drawing.Size(38, 20);
            prixLabel.TabIndex = 9;
            prixLabel.Text = "Prix:";
            // 
            // tbNoSoin
            // 
            this.tbNoSoin.Location = new System.Drawing.Point(150, 61);
            this.tbNoSoin.Name = "tbNoSoin";
            this.tbNoSoin.ReadOnly = true;
            this.tbNoSoin.Size = new System.Drawing.Size(182, 26);
            this.tbNoSoin.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(150, 93);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(182, 26);
            this.tbDescription.TabIndex = 4;
            this.tbDescription.TextChanged += new System.EventHandler(this.ValiderFormulaire);
            // 
            // tbDuree
            // 
            this.tbDuree.Location = new System.Drawing.Point(150, 126);
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.ReadOnly = true;
            this.tbDuree.Size = new System.Drawing.Size(182, 26);
            this.tbDuree.TabIndex = 6;
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(150, 189);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(182, 26);
            this.tbPrix.TabIndex = 10;
            this.tbPrix.TextChanged += new System.EventHandler(this.ValiderFormulaire);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ajout d\'un soin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Enabled = false;
            this.btnConfirmer.Location = new System.Drawing.Point(41, 239);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(291, 38);
            this.btnConfirmer.TabIndex = 12;
            this.btnConfirmer.Text = "Confirmer l\'ajout";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // bD5B6TP1_ConstantinBrassardLaheyDataSet
            // 
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.DataSetName = "BD5B6TP1_ConstantinBrassardLaheyDataSet";
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeSoinBindingSource
            // 
            this.typeSoinBindingSource.DataMember = "TypeSoin";
            this.typeSoinBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // typeSoinTableAdapter
            // 
            this.typeSoinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.NoEtDescriptionSoinTableAdapter = null;
            this.tableAdapterManager.NoEtNomsAssistantsTableAdapter = null;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = null;
            this.tableAdapterManager.TypeSoinTableAdapter = this.typeSoinTableAdapter;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // cmbTypeSoin
            // 
            this.cmbTypeSoin.DataSource = this.typeSoinBindingSource;
            this.cmbTypeSoin.DisplayMember = "Description";
            this.cmbTypeSoin.FormattingEnabled = true;
            this.cmbTypeSoin.Location = new System.Drawing.Point(150, 156);
            this.cmbTypeSoin.Name = "cmbTypeSoin";
            this.cmbTypeSoin.Size = new System.Drawing.Size(182, 28);
            this.cmbTypeSoin.TabIndex = 13;
            this.cmbTypeSoin.ValueMember = "NoTypeSoin";
            this.cmbTypeSoin.TextChanged += new System.EventHandler(this.ValiderFormulaire);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmAjoutSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 298);
            this.Controls.Add(this.cmbTypeSoin);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.label1);
            this.Controls.Add(noSoinLabel);
            this.Controls.Add(this.tbNoSoin);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(dureeLabel);
            this.Controls.Add(this.tbDuree);
            this.Controls.Add(noTypeSoinLabel);
            this.Controls.Add(prixLabel);
            this.Controls.Add(this.tbPrix);
            this.Name = "FrmAjoutSoin";
            this.Text = "Ajouter un soin";
            this.Load += new System.EventHandler(this.FrmAjoutSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNoSoin;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmer;
        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource typeSoinBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TypeSoinTableAdapter typeSoinTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTypeSoin;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}