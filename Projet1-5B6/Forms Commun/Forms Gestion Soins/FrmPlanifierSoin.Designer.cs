namespace Projet1_5B6.Forms_Commun.Forms_Gestion_Soins
{
    partial class FrmPlanifierSoin
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
            System.Windows.Forms.Label noPersonneLabel;
            System.Windows.Forms.Label noAssistantLabel;
            System.Windows.Forms.Label dateHeureLabel;
            System.Windows.Forms.Label noSoinLabel;
            this.dtpDateHeure = new System.Windows.Forms.DateTimePicker();
            this.cboPatient = new System.Windows.Forms.ComboBox();
            this.noEtNomsClientsInvitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.cboAssistant = new System.Windows.Forms.ComboBox();
            this.noEtNomsAssistantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboSoin = new System.Windows.Forms.ComboBox();
            this.noEtDescriptionSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noEtNomsClientsInvitesTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsClientsInvitesTableAdapter();
            this.noEtNomsAssistantsTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsAssistantsTableAdapter();
            this.noEtDescriptionSoinTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtDescriptionSoinTableAdapter();
            this.lblEntete = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.assistantSoinDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinDescriptionTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinDescriptionTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.assistantSoinDescriptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            noPersonneLabel = new System.Windows.Forms.Label();
            noAssistantLabel = new System.Windows.Forms.Label();
            dateHeureLabel = new System.Windows.Forms.Label();
            noSoinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsClientsInvitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsAssistantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // noPersonneLabel
            // 
            noPersonneLabel.AutoSize = true;
            noPersonneLabel.Location = new System.Drawing.Point(30, 47);
            noPersonneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noPersonneLabel.Name = "noPersonneLabel";
            noPersonneLabel.Size = new System.Drawing.Size(46, 13);
            noPersonneLabel.TabIndex = 1;
            noPersonneLabel.Text = "Patient: ";
            // 
            // noAssistantLabel
            // 
            noAssistantLabel.AutoSize = true;
            noAssistantLabel.Location = new System.Drawing.Point(30, 68);
            noAssistantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noAssistantLabel.Name = "noAssistantLabel";
            noAssistantLabel.Size = new System.Drawing.Size(52, 13);
            noAssistantLabel.TabIndex = 3;
            noAssistantLabel.Text = "Assistant:";
            // 
            // dateHeureLabel
            // 
            dateHeureLabel.AutoSize = true;
            dateHeureLabel.Location = new System.Drawing.Point(30, 90);
            dateHeureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateHeureLabel.Name = "dateHeureLabel";
            dateHeureLabel.Size = new System.Drawing.Size(65, 13);
            dateHeureLabel.TabIndex = 5;
            dateHeureLabel.Text = "Date Heure:";
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Location = new System.Drawing.Point(30, 110);
            noSoinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(31, 13);
            noSoinLabel.TabIndex = 7;
            noSoinLabel.Text = "Soin:";
            // 
            // dtpDateHeure
            // 
            this.dtpDateHeure.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpDateHeure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateHeure.Location = new System.Drawing.Point(104, 87);
            this.dtpDateHeure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateHeure.MinDate = new System.DateTime(2018, 10, 6, 0, 0, 0, 0);
            this.dtpDateHeure.Name = "dtpDateHeure";
            this.dtpDateHeure.Size = new System.Drawing.Size(155, 20);
            this.dtpDateHeure.TabIndex = 6;
            this.dtpDateHeure.Value = new System.DateTime(2018, 10, 6, 11, 2, 25, 0);
            // 
            // cboPatient
            // 
            this.cboPatient.DataSource = this.noEtNomsClientsInvitesBindingSource;
            this.cboPatient.DisplayMember = "NoEtNom";
            this.cboPatient.FormattingEnabled = true;
            this.cboPatient.Location = new System.Drawing.Point(104, 45);
            this.cboPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPatient.Name = "cboPatient";
            this.cboPatient.Size = new System.Drawing.Size(155, 21);
            this.cboPatient.TabIndex = 8;
            this.cboPatient.ValueMember = "NoClient";
            // 
            // noEtNomsClientsInvitesBindingSource
            // 
            this.noEtNomsClientsInvitesBindingSource.DataMember = "NoEtNomsClientsInvites";
            this.noEtNomsClientsInvitesBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // bD5B6TP1_ConstantinBrassardLaheyDataSet
            // 
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.DataSetName = "BD5B6TP1_ConstantinBrassardLaheyDataSet";
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboAssistant
            // 
            this.cboAssistant.DataSource = this.noEtNomsAssistantsBindingSource;
            this.cboAssistant.DisplayMember = "NoEtNom";
            this.cboAssistant.FormattingEnabled = true;
            this.cboAssistant.Location = new System.Drawing.Point(104, 66);
            this.cboAssistant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboAssistant.Name = "cboAssistant";
            this.cboAssistant.Size = new System.Drawing.Size(155, 21);
            this.cboAssistant.TabIndex = 9;
            this.cboAssistant.ValueMember = "NoAssistant";
            // 
            // noEtNomsAssistantsBindingSource
            // 
            this.noEtNomsAssistantsBindingSource.DataMember = "NoEtNomsAssistants";
            this.noEtNomsAssistantsBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // cboSoin
            // 
            this.cboSoin.DataSource = this.assistantSoinDescriptionBindingSource1;
            this.cboSoin.DisplayMember = "Description";
            this.cboSoin.FormattingEnabled = true;
            this.cboSoin.Location = new System.Drawing.Point(104, 108);
            this.cboSoin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSoin.Name = "cboSoin";
            this.cboSoin.Size = new System.Drawing.Size(155, 21);
            this.cboSoin.TabIndex = 10;
            this.cboSoin.ValueMember = "NoSoin";
            // 
            // noEtDescriptionSoinBindingSource
            // 
            this.noEtDescriptionSoinBindingSource.DataMember = "NoEtDescriptionSoin";
            this.noEtDescriptionSoinBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // noEtNomsClientsInvitesTableAdapter
            // 
            this.noEtNomsClientsInvitesTableAdapter.ClearBeforeFill = true;
            // 
            // noEtNomsAssistantsTableAdapter
            // 
            this.noEtNomsAssistantsTableAdapter.ClearBeforeFill = true;
            // 
            // noEtDescriptionSoinTableAdapter
            // 
            this.noEtDescriptionSoinTableAdapter.ClearBeforeFill = true;
            // 
            // lblEntete
            // 
            this.lblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntete.Location = new System.Drawing.Point(33, 6);
            this.lblEntete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntete.Name = "lblEntete";
            this.lblEntete.Size = new System.Drawing.Size(225, 38);
            this.lblEntete.TabIndex = 11;
            this.lblEntete.Text = "Planifier un soin";
            this.lblEntete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(79, 145);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(110, 31);
            this.btnConfirmer.TabIndex = 12;
            this.btnConfirmer.Text = "Confirmer l\'ajout";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // assistantSoinDescriptionBindingSource
            // 
            this.assistantSoinDescriptionBindingSource.DataMember = "AssistantSoinDescription";
            this.assistantSoinDescriptionBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // assistantSoinDescriptionTableAdapter
            // 
            this.assistantSoinDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.NoEtDescriptionSoinTableAdapter = this.noEtDescriptionSoinTableAdapter;
            this.tableAdapterManager.NoEtNomsAssistantsTableAdapter = this.noEtNomsAssistantsTableAdapter;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = null;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // assistantSoinDescriptionBindingSource1
            // 
            this.assistantSoinDescriptionBindingSource1.DataMember = "AssistantSoin_Assistant_NoAssistant_fk3";
            this.assistantSoinDescriptionBindingSource1.DataSource = this.noEtNomsAssistantsBindingSource;
            // 
            // FrmPlanifierSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 199);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblEntete);
            this.Controls.Add(this.cboSoin);
            this.Controls.Add(this.cboAssistant);
            this.Controls.Add(this.cboPatient);
            this.Controls.Add(noPersonneLabel);
            this.Controls.Add(noAssistantLabel);
            this.Controls.Add(dateHeureLabel);
            this.Controls.Add(this.dtpDateHeure);
            this.Controls.Add(noSoinLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPlanifierSoin";
            this.Text = "Planification soin";
            this.Load += new System.EventHandler(this.FrmPlanifierSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsClientsInvitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsAssistantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDateHeure;
        private System.Windows.Forms.ComboBox cboPatient;
        private System.Windows.Forms.ComboBox cboAssistant;
        private System.Windows.Forms.ComboBox cboSoin;
        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource noEtNomsClientsInvitesBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsClientsInvitesTableAdapter noEtNomsClientsInvitesTableAdapter;
        private System.Windows.Forms.BindingSource noEtNomsAssistantsBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsAssistantsTableAdapter noEtNomsAssistantsTableAdapter;
        private System.Windows.Forms.BindingSource noEtDescriptionSoinBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtDescriptionSoinTableAdapter noEtDescriptionSoinTableAdapter;
        private System.Windows.Forms.Label lblEntete;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource assistantSoinDescriptionBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinDescriptionTableAdapter assistantSoinDescriptionTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource assistantSoinDescriptionBindingSource1;
    }
}