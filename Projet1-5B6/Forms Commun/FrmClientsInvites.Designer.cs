namespace Projet1_5B6.Forms_Commun
{
    partial class FrmClientsInvites
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
            System.Windows.Forms.Label noClientLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label paysLabel;
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label dateInscriptionLabel1;
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.inviteTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.InviteTableAdapter();
            this.tbNoCli = new System.Windows.Forms.TextBox();
            this.bNomCli = new System.Windows.Forms.TextBox();
            this.tbPrenomCli = new System.Windows.Forms.TextBox();
            this.tbVilleCli = new System.Windows.Forms.TextBox();
            this.tbPaysCli = new System.Windows.Forms.TextBox();
            this.tbAdresseCli = new System.Windows.Forms.TextBox();
            this.tbCodePostalCli = new System.Windows.Forms.TextBox();
            this.lblTitreClient = new System.Windows.Forms.Label();
            this.btnClientSuivant = new System.Windows.Forms.Button();
            this.btnClientPrecedent = new System.Windows.Forms.Button();
            this.btnSupprimerCli = new System.Windows.Forms.Button();
            this.btnAjoutCli = new System.Windows.Forms.Button();
            this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inviteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDateInscriptionCli = new System.Windows.Forms.TextBox();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            noClientLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            paysLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            dateInscriptionLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // noClientLabel
            // 
            noClientLabel.AutoSize = true;
            noClientLabel.Location = new System.Drawing.Point(75, 91);
            noClientLabel.Name = "noClientLabel";
            noClientLabel.Size = new System.Drawing.Size(37, 20);
            noClientLabel.TabIndex = 1;
            noClientLabel.Text = "No :";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(75, 123);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(46, 20);
            nomLabel.TabIndex = 3;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(75, 155);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(68, 20);
            prenomLabel.TabIndex = 5;
            prenomLabel.Text = "Prenom:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(75, 187);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(42, 20);
            villeLabel.TabIndex = 7;
            villeLabel.Text = "Ville:";
            // 
            // paysLabel
            // 
            paysLabel.AutoSize = true;
            paysLabel.Location = new System.Drawing.Point(75, 219);
            paysLabel.Name = "paysLabel";
            paysLabel.Size = new System.Drawing.Size(47, 20);
            paysLabel.TabIndex = 9;
            paysLabel.Text = "Pays:";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(75, 251);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(72, 20);
            adresseLabel.TabIndex = 11;
            adresseLabel.Text = "Adresse:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(75, 283);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(99, 20);
            codePostalLabel.TabIndex = 13;
            codePostalLabel.Text = "Code Postal:";
            // 
            // dateInscriptionLabel1
            // 
            dateInscriptionLabel1.AutoSize = true;
            dateInscriptionLabel1.Location = new System.Drawing.Point(75, 316);
            dateInscriptionLabel1.Name = "dateInscriptionLabel1";
            dateInscriptionLabel1.Size = new System.Drawing.Size(125, 20);
            dateInscriptionLabel1.TabIndex = 23;
            dateInscriptionLabel1.Text = "Date Inscription:";
            // 
            // bD5B6TP1_ConstantinBrassardLaheyDataSet
            // 
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.DataSetName = "BD5B6TP1_ConstantinBrassardLaheyDataSet";
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.InviteTableAdapter = this.inviteTableAdapter;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = null;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // inviteTableAdapter
            // 
            this.inviteTableAdapter.ClearBeforeFill = true;
            // 
            // tbNoCli
            // 
            this.tbNoCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NoClient", true));
            this.tbNoCli.Location = new System.Drawing.Point(206, 88);
            this.tbNoCli.Name = "tbNoCli";
            this.tbNoCli.ReadOnly = true;
            this.tbNoCli.Size = new System.Drawing.Size(200, 26);
            this.tbNoCli.TabIndex = 2;
            // 
            // bNomCli
            // 
            this.bNomCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nom", true));
            this.bNomCli.Location = new System.Drawing.Point(206, 120);
            this.bNomCli.Name = "bNomCli";
            this.bNomCli.Size = new System.Drawing.Size(200, 26);
            this.bNomCli.TabIndex = 4;
            // 
            // tbPrenomCli
            // 
            this.tbPrenomCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Prenom", true));
            this.tbPrenomCli.Location = new System.Drawing.Point(206, 152);
            this.tbPrenomCli.Name = "tbPrenomCli";
            this.tbPrenomCli.Size = new System.Drawing.Size(200, 26);
            this.tbPrenomCli.TabIndex = 6;
            // 
            // tbVilleCli
            // 
            this.tbVilleCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Ville", true));
            this.tbVilleCli.Location = new System.Drawing.Point(206, 184);
            this.tbVilleCli.Name = "tbVilleCli";
            this.tbVilleCli.Size = new System.Drawing.Size(200, 26);
            this.tbVilleCli.TabIndex = 8;
            // 
            // tbPaysCli
            // 
            this.tbPaysCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Pays", true));
            this.tbPaysCli.Location = new System.Drawing.Point(206, 216);
            this.tbPaysCli.Name = "tbPaysCli";
            this.tbPaysCli.Size = new System.Drawing.Size(200, 26);
            this.tbPaysCli.TabIndex = 10;
            // 
            // tbAdresseCli
            // 
            this.tbAdresseCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Adresse", true));
            this.tbAdresseCli.Location = new System.Drawing.Point(206, 248);
            this.tbAdresseCli.Name = "tbAdresseCli";
            this.tbAdresseCli.Size = new System.Drawing.Size(200, 26);
            this.tbAdresseCli.TabIndex = 12;
            // 
            // tbCodePostalCli
            // 
            this.tbCodePostalCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CodePostal", true));
            this.tbCodePostalCli.Location = new System.Drawing.Point(206, 280);
            this.tbCodePostalCli.Name = "tbCodePostalCli";
            this.tbCodePostalCli.Size = new System.Drawing.Size(200, 26);
            this.tbCodePostalCli.TabIndex = 14;
            // 
            // lblTitreClient
            // 
            this.lblTitreClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreClient.Location = new System.Drawing.Point(25, 9);
            this.lblTitreClient.Name = "lblTitreClient";
            this.lblTitreClient.Size = new System.Drawing.Size(431, 76);
            this.lblTitreClient.TabIndex = 17;
            this.lblTitreClient.Text = "Client";
            this.lblTitreClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClientSuivant
            // 
            this.btnClientSuivant.Location = new System.Drawing.Point(412, 86);
            this.btnClientSuivant.Name = "btnClientSuivant";
            this.btnClientSuivant.Size = new System.Drawing.Size(44, 252);
            this.btnClientSuivant.TabIndex = 18;
            this.btnClientSuivant.Text = ">";
            this.btnClientSuivant.UseVisualStyleBackColor = true;
            this.btnClientSuivant.Click += new System.EventHandler(this.btnClientSuivant_Click);
            // 
            // btnClientPrecedent
            // 
            this.btnClientPrecedent.Location = new System.Drawing.Point(25, 86);
            this.btnClientPrecedent.Name = "btnClientPrecedent";
            this.btnClientPrecedent.Size = new System.Drawing.Size(44, 252);
            this.btnClientPrecedent.TabIndex = 19;
            this.btnClientPrecedent.Text = "<";
            this.btnClientPrecedent.UseVisualStyleBackColor = true;
            this.btnClientPrecedent.Click += new System.EventHandler(this.btnClientPrecedent_Click);
            // 
            // btnSupprimerCli
            // 
            this.btnSupprimerCli.Location = new System.Drawing.Point(310, 359);
            this.btnSupprimerCli.Name = "btnSupprimerCli";
            this.btnSupprimerCli.Size = new System.Drawing.Size(146, 40);
            this.btnSupprimerCli.TabIndex = 21;
            this.btnSupprimerCli.Text = "Supprimer Client";
            this.btnSupprimerCli.UseVisualStyleBackColor = true;
            this.btnSupprimerCli.Click += new System.EventHandler(this.btnSupprimerCli_Click);
            // 
            // btnAjoutCli
            // 
            this.btnAjoutCli.Location = new System.Drawing.Point(25, 359);
            this.btnAjoutCli.Name = "btnAjoutCli";
            this.btnAjoutCli.Size = new System.Drawing.Size(146, 40);
            this.btnAjoutCli.TabIndex = 22;
            this.btnAjoutCli.Text = "Nouveau Client";
            this.btnAjoutCli.UseVisualStyleBackColor = true;
            this.btnAjoutCli.Click += new System.EventHandler(this.btnAjoutCli_Click);
            // 
            // inviteBindingSource
            // 
            this.inviteBindingSource.DataMember = "Invite_Client_NoCliet_fk";
            this.inviteBindingSource.DataSource = this.clientBindingSource;
            // 
            // inviteDataGridView
            // 
            this.inviteDataGridView.AutoGenerateColumns = false;
            this.inviteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inviteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inviteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.inviteDataGridView.DataSource = this.inviteBindingSource;
            this.inviteDataGridView.Location = new System.Drawing.Point(518, 86);
            this.inviteDataGridView.Name = "inviteDataGridView";
            this.inviteDataGridView.RowTemplate.Height = 28;
            this.inviteDataGridView.Size = new System.Drawing.Size(653, 313);
            this.inviteDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoInvite";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoClient";
            this.dataGridViewTextBoxColumn4.HeaderText = "No client";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 76);
            this.label1.TabIndex = 23;
            this.label1.Text = "Invités du client";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDateInscriptionCli
            // 
            this.tbDateInscriptionCli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "DateInscription", true));
            this.tbDateInscriptionCli.Location = new System.Drawing.Point(206, 312);
            this.tbDateInscriptionCli.Name = "tbDateInscriptionCli";
            this.tbDateInscriptionCli.ReadOnly = true;
            this.tbDateInscriptionCli.Size = new System.Drawing.Size(200, 26);
            this.tbDateInscriptionCli.TabIndex = 24;
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(310, 443);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(180, 54);
            this.btnSauvegarder.TabIndex = 25;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(579, 443);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(180, 54);
            this.btnAnnuler.TabIndex = 26;
            this.btnAnnuler.Text = "Annuler Modifications";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FrmClientsInvites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 524);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(dateInscriptionLabel1);
            this.Controls.Add(this.tbDateInscriptionCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inviteDataGridView);
            this.Controls.Add(this.btnAjoutCli);
            this.Controls.Add(this.btnSupprimerCli);
            this.Controls.Add(this.btnClientPrecedent);
            this.Controls.Add(this.btnClientSuivant);
            this.Controls.Add(this.lblTitreClient);
            this.Controls.Add(noClientLabel);
            this.Controls.Add(this.tbNoCli);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.bNomCli);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.tbPrenomCli);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.tbVilleCli);
            this.Controls.Add(paysLabel);
            this.Controls.Add(this.tbPaysCli);
            this.Controls.Add(adresseLabel);
            this.Controls.Add(this.tbAdresseCli);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(this.tbCodePostalCli);
            this.Name = "FrmClientsInvites";
            this.Text = "FormClientsInvites";
            this.Load += new System.EventHandler(this.FormClientsInvites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbNoCli;
        private System.Windows.Forms.TextBox bNomCli;
        private System.Windows.Forms.TextBox tbPrenomCli;
        private System.Windows.Forms.TextBox tbVilleCli;
        private System.Windows.Forms.TextBox tbPaysCli;
        private System.Windows.Forms.TextBox tbAdresseCli;
        private System.Windows.Forms.TextBox tbCodePostalCli;
        private System.Windows.Forms.Label lblTitreClient;
        private System.Windows.Forms.Button btnClientSuivant;
        private System.Windows.Forms.Button btnClientPrecedent;
        private System.Windows.Forms.Button btnSupprimerCli;
        private System.Windows.Forms.Button btnAjoutCli;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.InviteTableAdapter inviteTableAdapter;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private System.Windows.Forms.DataGridView inviteDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox tbDateInscriptionCli;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnAnnuler;
    }
}