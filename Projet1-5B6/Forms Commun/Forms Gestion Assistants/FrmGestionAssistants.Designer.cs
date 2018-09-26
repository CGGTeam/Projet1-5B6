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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifierAssistant = new System.Windows.Forms.Button();
            this.btnSupprimerAssistant = new System.Windows.Forms.Button();
            this.btnAjouterSoin = new System.Windows.Forms.Button();
            this.btnSupprimerSoin = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.assistantTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.assistantSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinTableAdapter();
            this.assistanSoinDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistanSoinDescriptionTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistanSoinDescriptionTableAdapter();
            this.assistanSoinDescriptionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistanSoinDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistanSoinDescriptionDataGridView)).BeginInit();
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
            this.btnAjouterAssistant.Location = new System.Drawing.Point(22, 395);
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
            this.assistantDataGridView.AutoGenerateColumns = false;
            this.assistantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assistantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8});
            this.assistantDataGridView.DataSource = this.assistantBindingSource;
            this.assistantDataGridView.Location = new System.Drawing.Point(22, 47);
            this.assistantDataGridView.Name = "assistantDataGridView";
            this.assistantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assistantDataGridView.Size = new System.Drawing.Size(538, 330);
            this.assistantDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "LISTE DES ASSISTANTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "liste des soins offerts par cet assistant";
            // 
            // btnModifierAssistant
            // 
            this.btnModifierAssistant.Location = new System.Drawing.Point(232, 395);
            this.btnModifierAssistant.Name = "btnModifierAssistant";
            this.btnModifierAssistant.Size = new System.Drawing.Size(135, 30);
            this.btnModifierAssistant.TabIndex = 6;
            this.btnModifierAssistant.Text = "Modifier un assistant";
            this.btnModifierAssistant.UseVisualStyleBackColor = true;
            this.btnModifierAssistant.Click += new System.EventHandler(this.btnModifierAssistant_Click);
            // 
            // btnSupprimerAssistant
            // 
            this.btnSupprimerAssistant.Location = new System.Drawing.Point(425, 395);
            this.btnSupprimerAssistant.Name = "btnSupprimerAssistant";
            this.btnSupprimerAssistant.Size = new System.Drawing.Size(135, 30);
            this.btnSupprimerAssistant.TabIndex = 7;
            this.btnSupprimerAssistant.Text = "Supprimer un assistant";
            this.btnSupprimerAssistant.UseVisualStyleBackColor = true;
            this.btnSupprimerAssistant.Click += new System.EventHandler(this.btnSupprimerAssistant_Click);
            // 
            // btnAjouterSoin
            // 
            this.btnAjouterSoin.Location = new System.Drawing.Point(679, 395);
            this.btnAjouterSoin.Name = "btnAjouterSoin";
            this.btnAjouterSoin.Size = new System.Drawing.Size(107, 30);
            this.btnAjouterSoin.TabIndex = 8;
            this.btnAjouterSoin.Text = "Ajouter un soin";
            this.btnAjouterSoin.UseVisualStyleBackColor = true;
            this.btnAjouterSoin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSupprimerSoin
            // 
            this.btnSupprimerSoin.Location = new System.Drawing.Point(814, 395);
            this.btnSupprimerSoin.Name = "btnSupprimerSoin";
            this.btnSupprimerSoin.Size = new System.Drawing.Size(107, 30);
            this.btnSupprimerSoin.TabIndex = 9;
            this.btnSupprimerSoin.Text = "Supprimer un soin";
            this.btnSupprimerSoin.UseVisualStyleBackColor = true;
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
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Specialites";
            this.dataGridViewTextBoxColumn4.HeaderText = "Specialites";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Remarques";
            this.dataGridViewTextBoxColumn8.HeaderText = "Remarques";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            // assistanSoinDescriptionTableAdapter
            // 
            this.assistanSoinDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // assistanSoinDescriptionDataGridView
            // 
            this.assistanSoinDescriptionDataGridView.AutoGenerateColumns = false;
            this.assistanSoinDescriptionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assistanSoinDescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assistanSoinDescriptionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.assistanSoinDescriptionDataGridView.DataSource = this.assistanSoinDescriptionBindingSource;
            this.assistanSoinDescriptionDataGridView.Location = new System.Drawing.Point(642, 47);
            this.assistanSoinDescriptionDataGridView.Name = "assistanSoinDescriptionDataGridView";
            this.assistanSoinDescriptionDataGridView.Size = new System.Drawing.Size(299, 330);
            this.assistanSoinDescriptionDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NoSoin";
            this.dataGridViewTextBoxColumn9.HeaderText = "NoSoin";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn10.HeaderText = "Description";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FrmGestionAssistants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 448);
            this.Controls.Add(this.assistanSoinDescriptionDataGridView);
            this.Controls.Add(this.btnSupprimerSoin);
            this.Controls.Add(this.btnAjouterSoin);
            this.Controls.Add(this.btnSupprimerAssistant);
            this.Controls.Add(this.btnModifierAssistant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assistantDataGridView);
            this.Controls.Add(this.btnAjouterAssistant);
            this.Name = "FrmGestionAssistants";
            this.Text = "FrmGestionAssistants";
            this.Load += new System.EventHandler(this.FrmGestionAssistants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistanSoinDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistanSoinDescriptionDataGridView)).EndInit();
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
        private System.Windows.Forms.Button btnModifierAssistant;
        private System.Windows.Forms.Button btnSupprimerAssistant;
        private System.Windows.Forms.Button btnAjouterSoin;
        private System.Windows.Forms.Button btnSupprimerSoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource assistantSoinBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantSoinTableAdapter assistantSoinTableAdapter;
        private System.Windows.Forms.BindingSource assistanSoinDescriptionBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistanSoinDescriptionTableAdapter assistanSoinDescriptionTableAdapter;
        private System.Windows.Forms.DataGridView assistanSoinDescriptionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}