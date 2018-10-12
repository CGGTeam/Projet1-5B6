namespace Projet1_5B6.Forms_Commun.Forms_Gestion_Assistants
{
    partial class FrmGestionAssistant
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.assistantSoinTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinTableAdapter();
            this.assistantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimerAssistant = new System.Windows.Forms.Button();
            this.btnAjouterAssistant = new System.Windows.Forms.Button();
            this.assistantSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinDescriptionTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinDescriptionTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listSoin = new System.Windows.Forms.ComboBox();
            this.noEtDescriptionSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouterSoin = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnSupprimerSoin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.noEtDescriptionSoinTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtDescriptionSoinTableAdapter();
            this.assistantSoinDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.noEtDescriptionSoinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.noEtNomsAssistantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noEtNomsAssistantsTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsAssistantsTableAdapter();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfrimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsAssistantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des Assistants";
            // 
            // bD5B6TP1_ConstantinBrassardLaheyDataSet
            // 
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.DataSetName = "BD5B6TP1_ConstantinBrassardLaheyDataSet";
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "Assistant";
            this.assistantBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = this.assistantSoinTableAdapter;
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
            // assistantSoinTableAdapter
            // 
            this.assistantSoinTableAdapter.ClearBeforeFill = true;
            // 
            // assistantDataGridView
            // 
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
            this.dataGridViewTextBoxColumn5});
            this.assistantDataGridView.DataSource = this.assistantBindingSource;
            this.assistantDataGridView.Location = new System.Drawing.Point(21, 62);
            this.assistantDataGridView.MultiSelect = false;
            this.assistantDataGridView.Name = "assistantDataGridView";
            this.assistantDataGridView.ReadOnly = true;
            this.assistantDataGridView.RowHeadersVisible = false;
            this.assistantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assistantDataGridView.Size = new System.Drawing.Size(550, 305);
            this.assistantDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoAssistant";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoAssistant";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Remarques";
            this.dataGridViewTextBoxColumn5.HeaderText = "Remarques";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(231, 373);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(135, 30);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "Modifier un assistant";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimerAssistant
            // 
            this.btnSupprimerAssistant.Location = new System.Drawing.Point(436, 373);
            this.btnSupprimerAssistant.Name = "btnSupprimerAssistant";
            this.btnSupprimerAssistant.Size = new System.Drawing.Size(135, 30);
            this.btnSupprimerAssistant.TabIndex = 16;
            this.btnSupprimerAssistant.Text = "Supprimer un assistant";
            this.btnSupprimerAssistant.UseVisualStyleBackColor = true;
            this.btnSupprimerAssistant.Click += new System.EventHandler(this.btnSupprimerAssistant_Click);
            // 
            // btnAjouterAssistant
            // 
            this.btnAjouterAssistant.Location = new System.Drawing.Point(21, 373);
            this.btnAjouterAssistant.Name = "btnAjouterAssistant";
            this.btnAjouterAssistant.Size = new System.Drawing.Size(135, 30);
            this.btnAjouterAssistant.TabIndex = 15;
            this.btnAjouterAssistant.Text = "Ajouter un assistant";
            this.btnAjouterAssistant.UseVisualStyleBackColor = true;
            this.btnAjouterAssistant.Click += new System.EventHandler(this.btnAjouterAssistant_Click);
            // 
            // assistantSoinBindingSource
            // 
            this.assistantSoinBindingSource.DataMember = "AssistantSoin_Assistant_NoAssistant_fk";
            this.assistantSoinBindingSource.DataSource = this.assistantBindingSource;
            // 
            // assistantSoinDescriptionBindingSource
            // 
            this.assistantSoinDescriptionBindingSource.DataMember = "AssistantSoin_Assistant_NoAssistant_fk2";
            this.assistantSoinDescriptionBindingSource.DataSource = this.assistantBindingSource;
            // 
            // assistantSoinDescriptionTableAdapter
            // 
            this.assistantSoinDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listSoin);
            this.groupBox1.Controls.Add(this.btnAjouterSoin);
            this.groupBox1.Location = new System.Drawing.Point(724, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 105);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout de soin à cet assistant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "soin :";
            // 
            // listSoin
            // 
            this.listSoin.DataSource = this.noEtDescriptionSoinBindingSource;
            this.listSoin.DisplayMember = "NoEtDescription";
            this.listSoin.FormattingEnabled = true;
            this.listSoin.Location = new System.Drawing.Point(18, 33);
            this.listSoin.Name = "listSoin";
            this.listSoin.Size = new System.Drawing.Size(130, 21);
            this.listSoin.TabIndex = 15;
            this.listSoin.ValueMember = "NoSoin";
            this.listSoin.SelectedIndexChanged += new System.EventHandler(this.enableButton);
            // 
            // noEtDescriptionSoinBindingSource
            // 
            this.noEtDescriptionSoinBindingSource.DataMember = "NoEtDescriptionSoin";
            this.noEtDescriptionSoinBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // btnAjouterSoin
            // 
            this.btnAjouterSoin.Location = new System.Drawing.Point(18, 60);
            this.btnAjouterSoin.Name = "btnAjouterSoin";
            this.btnAjouterSoin.Size = new System.Drawing.Size(130, 30);
            this.btnAjouterSoin.TabIndex = 14;
            this.btnAjouterSoin.Text = "Ajouter";
            this.btnAjouterSoin.UseVisualStyleBackColor = true;
            this.btnAjouterSoin.Click += new System.EventHandler(this.btnAjouterSoin_Click);
            // 
            // btnSupprimerSoin
            // 
            this.btnSupprimerSoin.Location = new System.Drawing.Point(742, 269);
            this.btnSupprimerSoin.Name = "btnSupprimerSoin";
            this.btnSupprimerSoin.Size = new System.Drawing.Size(130, 30);
            this.btnSupprimerSoin.TabIndex = 19;
            this.btnSupprimerSoin.Text = "Supprimer un soin";
            this.btnSupprimerSoin.UseVisualStyleBackColor = true;
            this.btnSupprimerSoin.Click += new System.EventHandler(this.btnSupprimerSoin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Soin(s) offert(s) :";
            // 
            // noEtDescriptionSoinTableAdapter
            // 
            this.noEtDescriptionSoinTableAdapter.ClearBeforeFill = true;
            // 
            // assistantSoinDataGridView
            // 
            this.assistantSoinDataGridView.AllowUserToAddRows = false;
            this.assistantSoinDataGridView.AllowUserToDeleteRows = false;
            this.assistantSoinDataGridView.AllowUserToOrderColumns = true;
            this.assistantSoinDataGridView.AllowUserToResizeRows = false;
            this.assistantSoinDataGridView.AutoGenerateColumns = false;
            this.assistantSoinDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.assistantSoinDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.assistantSoinDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.assistantSoinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assistantSoinDataGridView.ColumnHeadersVisible = false;
            this.assistantSoinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.assistantSoinDataGridView.DataSource = this.assistantSoinBindingSource;
            this.assistantSoinDataGridView.EnableHeadersVisualStyles = false;
            this.assistantSoinDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.assistantSoinDataGridView.Location = new System.Drawing.Point(583, 94);
            this.assistantSoinDataGridView.MultiSelect = false;
            this.assistantSoinDataGridView.Name = "assistantSoinDataGridView";
            this.assistantSoinDataGridView.ReadOnly = true;
            this.assistantSoinDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assistantSoinDataGridView.Size = new System.Drawing.Size(135, 273);
            this.assistantSoinDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NoAssistant";
            this.dataGridViewTextBoxColumn6.HeaderText = "NoAssistant";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NoSoin";
            this.dataGridViewTextBoxColumn7.DataSource = this.noEtDescriptionSoinBindingSource1;
            this.dataGridViewTextBoxColumn7.DisplayMember = "NoEtDescription";
            this.dataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn7.HeaderText = "";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "NoSoin";
            // 
            // noEtDescriptionSoinBindingSource1
            // 
            this.noEtDescriptionSoinBindingSource1.DataMember = "NoEtDescriptionSoin";
            this.noEtDescriptionSoinBindingSource1.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // noEtNomsAssistantsBindingSource
            // 
            this.noEtNomsAssistantsBindingSource.DataMember = "NoEtNomsAssistants";
            this.noEtNomsAssistantsBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // noEtNomsAssistantsTableAdapter
            // 
            this.noEtNomsAssistantsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(436, 430);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(165, 30);
            this.btnAnnuler.TabIndex = 22;
            this.btnAnnuler.Text = "Annuler modifications";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfrimer
            // 
            this.btnConfrimer.Location = new System.Drawing.Point(231, 430);
            this.btnConfrimer.Name = "btnConfrimer";
            this.btnConfrimer.Size = new System.Drawing.Size(165, 30);
            this.btnConfrimer.TabIndex = 21;
            this.btnConfrimer.Text = "Sauvegarder modifications";
            this.btnConfrimer.UseVisualStyleBackColor = true;
            this.btnConfrimer.Click += new System.EventHandler(this.btnConfrimer_Click);
            // 
            // FrmGestionAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 472);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfrimer);
            this.Controls.Add(this.assistantSoinDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSupprimerSoin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimerAssistant);
            this.Controls.Add(this.btnAjouterAssistant);
            this.Controls.Add(this.assistantDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionAssistant";
            this.Text = "Gestion des assistants";
            this.Load += new System.EventHandler(this.FrmGestionAssistant_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.assistantDataGridView, 0);
            this.Controls.SetChildIndex(this.btnAjouterAssistant, 0);
            this.Controls.SetChildIndex(this.btnSupprimerAssistant, 0);
            this.Controls.SetChildIndex(this.btnModifier, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnSupprimerSoin, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.assistantSoinDataGridView, 0);
            this.Controls.SetChildIndex(this.btnConfrimer, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDescriptionSoinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsAssistantsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantTableAdapter assistantTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView assistantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimerAssistant;
        private System.Windows.Forms.Button btnAjouterAssistant;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinTableAdapter assistantSoinTableAdapter;
        private System.Windows.Forms.BindingSource assistantSoinBindingSource;
        private System.Windows.Forms.BindingSource assistantSoinDescriptionBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinDescriptionTableAdapter assistantSoinDescriptionTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox listSoin;
        private System.Windows.Forms.Button btnAjouterSoin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSupprimerSoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource noEtDescriptionSoinBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtDescriptionSoinTableAdapter noEtDescriptionSoinTableAdapter;
        private System.Windows.Forms.DataGridView assistantSoinDataGridView;
        private System.Windows.Forms.BindingSource noEtNomsAssistantsBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsAssistantsTableAdapter noEtNomsAssistantsTableAdapter;
        private System.Windows.Forms.BindingSource noEtDescriptionSoinBindingSource1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfrimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
    }
}