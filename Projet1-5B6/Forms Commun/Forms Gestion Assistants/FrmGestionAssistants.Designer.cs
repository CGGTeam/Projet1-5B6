namespace Projet1_5B6.Forms_Admin
{
    partial class FrmGestionAssistants
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
            this.assistantSoinDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouterAssistant = new System.Windows.Forms.Button();
            this.assistantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfrimer = new System.Windows.Forms.Button();
            this.btnSupprimerAssistant = new System.Windows.Forms.Button();
            this.btnAjouterSoin = new System.Windows.Forms.Button();
            this.assistantTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.assistantSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinTableAdapter();
            this.assistanSoinDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.SoinTableAdapter();
            this.listSoin = new System.Windows.Forms.ComboBox();
            this.noEtDescriptionSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noEtDescriptionSoinTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtDescriptionSoinTableAdapter();
            this.assistantSoinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinDescriptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinDescriptionTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinDescriptionTableAdapter();
            this.assistantSoinDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimerSoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistanSoinDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NoSoin";
            this.dataGridViewTextBoxColumn6.HeaderText = "NoSoin";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btnAjouterAssistant
            // 
            this.btnAjouterAssistant.Location = new System.Drawing.Point(22, 419);
            this.btnAjouterAssistant.Name = "btnAjouterAssistant";
            this.btnAjouterAssistant.Size = new System.Drawing.Size(135, 30);
            this.btnAjouterAssistant.TabIndex = 3;
            this.btnAjouterAssistant.Text = "Ajouter un assistant";
            this.btnAjouterAssistant.UseVisualStyleBackColor = true;
            this.btnAjouterAssistant.Click += new System.EventHandler(this.btnAjouterAssistant_Click);
            // 
            // assistantDataGridView
            // 
            this.assistantDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.assistantDataGridView.AllowUserToAddRows = false;
            this.assistantDataGridView.AllowUserToDeleteRows = false;
            this.assistantDataGridView.AllowUserToOrderColumns = true;
            this.assistantDataGridView.AutoGenerateColumns = false;
            this.assistantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assistantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8});
            this.assistantDataGridView.DataSource = this.assistantBindingSource;
            this.assistantDataGridView.Location = new System.Drawing.Point(22, 70);
            this.assistantDataGridView.MultiSelect = false;
            this.assistantDataGridView.Name = "assistantDataGridView";
            this.assistantDataGridView.ReadOnly = true;
            this.assistantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assistantDataGridView.Size = new System.Drawing.Size(538, 330);
            this.assistantDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoAssistant";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoAssistant";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Specialites";
            this.dataGridViewTextBoxColumn4.HeaderText = "Specialites";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Remarques";
            this.dataGridViewTextBoxColumn8.HeaderText = "Remarques";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "Assistant";
            this.assistantBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // bD5B6TP1_ConstantinBrassardLaheyDataSet
            // 
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.DataSetName = "BD5B6TP1_ConstantinBrassardLaheyDataSet";
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "LISTE DES ASSISTANTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "liste des soins offerts par cet assistant";
            // 
            // btnConfrimer
            // 
            this.btnConfrimer.Location = new System.Drawing.Point(751, 297);
            this.btnConfrimer.Name = "btnConfrimer";
            this.btnConfrimer.Size = new System.Drawing.Size(130, 30);
            this.btnConfrimer.TabIndex = 6;
            this.btnConfrimer.Text = "Sauvegarder modifications";
            this.btnConfrimer.UseVisualStyleBackColor = true;
            this.btnConfrimer.Click += new System.EventHandler(this.btnModifierAssistant_Click);
            // 
            // btnSupprimerAssistant
            // 
            this.btnSupprimerAssistant.Location = new System.Drawing.Point(425, 419);
            this.btnSupprimerAssistant.Name = "btnSupprimerAssistant";
            this.btnSupprimerAssistant.Size = new System.Drawing.Size(135, 30);
            this.btnSupprimerAssistant.TabIndex = 7;
            this.btnSupprimerAssistant.Text = "Supprimer un assistant";
            this.btnSupprimerAssistant.UseVisualStyleBackColor = true;
            this.btnSupprimerAssistant.Click += new System.EventHandler(this.btnSupprimerAssistant_Click);
            // 
            // btnAjouterSoin
            // 
            this.btnAjouterSoin.Location = new System.Drawing.Point(751, 110);
            this.btnAjouterSoin.Name = "btnAjouterSoin";
            this.btnAjouterSoin.Size = new System.Drawing.Size(130, 30);
            this.btnAjouterSoin.TabIndex = 8;
            this.btnAjouterSoin.Text = "Ajouter un soin";
            this.btnAjouterSoin.UseVisualStyleBackColor = true;
            this.btnAjouterSoin.Click += new System.EventHandler(this.btnAjouterSoin_Click);
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = this.assistantTableAdapter;
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
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // assistantSoinBindingSource
            // 
            this.assistantSoinBindingSource.DataMember = "AssistantSoin";
            this.assistantSoinBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // assistantSoinTableAdapter
            // 
            this.assistantSoinTableAdapter.ClearBeforeFill = true;
            // 
            // assistanSoinDescriptionBindingSource
            // 
            this.assistanSoinDescriptionBindingSource.DataMember = "AssistanSoinDescription";
            this.assistanSoinDescriptionBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(751, 333);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(130, 30);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler modifications";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // soinBindingSource
            // 
            this.soinBindingSource.DataMember = "Soin";
            this.soinBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // listSoin
            // 
            this.listSoin.DataSource = this.noEtDescriptionSoinBindingSource;
            this.listSoin.DisplayMember = "NoEtDescription";
            this.listSoin.FormattingEnabled = true;
            this.listSoin.Location = new System.Drawing.Point(751, 83);
            this.listSoin.Name = "listSoin";
            this.listSoin.Size = new System.Drawing.Size(130, 21);
            this.listSoin.TabIndex = 13;
            this.listSoin.ValueMember = "NoSoin";
            // 
            // noEtDescriptionSoinBindingSource
            // 
            this.noEtDescriptionSoinBindingSource.DataMember = "NoEtDescriptionSoin";
            this.noEtDescriptionSoinBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // noEtDescriptionSoinTableAdapter
            // 
            this.noEtDescriptionSoinTableAdapter.ClearBeforeFill = true;
            // 
            // assistantSoinBindingSource1
            // 
            this.assistantSoinBindingSource1.DataMember = "AssistantSoin_Assistant_NoAssistant_fk";
            this.assistantSoinBindingSource1.DataSource = this.assistantBindingSource;
            // 
            // assistantSoinBindingSource2
            // 
            this.assistantSoinBindingSource2.DataMember = "AssistantSoin_Assistant_NoAssistant_fk";
            this.assistantSoinBindingSource2.DataSource = this.assistantBindingSource;
            // 
            // assistantSoinDescriptionBindingSource1
            // 
            this.assistantSoinDescriptionBindingSource1.DataMember = "AssistantSoin_Assistant_NoAssistant_fk2";
            this.assistantSoinDescriptionBindingSource1.DataSource = this.assistantBindingSource;
            // 
            // assistantSoinDescriptionTableAdapter
            // 
            this.assistantSoinDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // assistantSoinDataGridView
            // 
            this.assistantSoinDataGridView.AllowUserToAddRows = false;
            this.assistantSoinDataGridView.AllowUserToDeleteRows = false;
            this.assistantSoinDataGridView.AutoGenerateColumns = false;
            this.assistantSoinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assistantSoinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.assistantSoinDataGridView.DataSource = this.assistantSoinBindingSource1;
            this.assistantSoinDataGridView.Location = new System.Drawing.Point(566, 70);
            this.assistantSoinDataGridView.Name = "assistantSoinDataGridView";
            this.assistantSoinDataGridView.ReadOnly = true;
            this.assistantSoinDataGridView.Size = new System.Drawing.Size(179, 330);
            this.assistantSoinDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NoAssistant";
            this.dataGridViewTextBoxColumn9.HeaderText = "NoAssistant";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NoSoin";
            this.dataGridViewTextBoxColumn10.DataSource = this.noEtDescriptionSoinBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "NoEtDescription";
            this.dataGridViewTextBoxColumn10.HeaderText = "Soin";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "NoSoin";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(229, 419);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(135, 30);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "Modifier un assistant";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimerSoin
            // 
            this.btnSupprimerSoin.Location = new System.Drawing.Point(751, 146);
            this.btnSupprimerSoin.Name = "btnSupprimerSoin";
            this.btnSupprimerSoin.Size = new System.Drawing.Size(130, 30);
            this.btnSupprimerSoin.TabIndex = 9;
            this.btnSupprimerSoin.Text = "Supprimer un soin";
            this.btnSupprimerSoin.UseVisualStyleBackColor = true;
            this.btnSupprimerSoin.Click += new System.EventHandler(this.btnSupprimerSoin_Click);
            // 
            // FrmGestionAssistants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 469);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.assistantSoinDataGridView);
            this.Controls.Add(this.listSoin);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimerSoin);
            this.Controls.Add(this.btnAjouterSoin);
            this.Controls.Add(this.btnSupprimerAssistant);
            this.Controls.Add(this.btnConfrimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assistantDataGridView);
            this.Controls.Add(this.btnAjouterAssistant);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "FrmGestionAssistants";
            this.Text = "FrmGestionAssistants";
            this.Load += new System.EventHandler(this.FrmGestionAssistants_Load);
            this.Controls.SetChildIndex(this.btnAjouterAssistant, 0);
            this.Controls.SetChildIndex(this.assistantDataGridView, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnConfrimer, 0);
            this.Controls.SetChildIndex(this.btnSupprimerAssistant, 0);
            this.Controls.SetChildIndex(this.btnAjouterSoin, 0);
            this.Controls.SetChildIndex(this.btnSupprimerSoin, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.Controls.SetChildIndex(this.listSoin, 0);
            this.Controls.SetChildIndex(this.assistantSoinDataGridView, 0);
            this.Controls.SetChildIndex(this.btnModifier, 0);
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistanSoinDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantTableAdapter assistantTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource assistantSoinDescriptionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnAjouterAssistant;
        private System.Windows.Forms.DataGridView assistantDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfrimer;
        private System.Windows.Forms.Button btnSupprimerAssistant;
        private System.Windows.Forms.Button btnAjouterSoin;
        private System.Windows.Forms.BindingSource assistantSoinBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinTableAdapter assistantSoinTableAdapter;
        private System.Windows.Forms.BindingSource assistanSoinDescriptionBindingSource;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.SoinTableAdapter soinTableAdapter;
        private System.Windows.Forms.ComboBox listSoin;
        private System.Windows.Forms.BindingSource noEtDescriptionSoinBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtDescriptionSoinTableAdapter noEtDescriptionSoinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource assistantSoinBindingSource1;
        private System.Windows.Forms.BindingSource assistantSoinBindingSource2;
        private System.Windows.Forms.BindingSource assistantSoinDescriptionBindingSource1;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinDescriptionTableAdapter assistantSoinDescriptionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView assistantSoinDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimerSoin;
    }
}