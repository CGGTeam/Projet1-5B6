namespace Projet1_5B6.Forms_Admin.Fomrs_Rapports
{
    partial class FrmSoinsAssistants
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.assistantTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantTableAdapter();
            this.rapportSoinsAssistantTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.RapportSoinsAssistantTableAdapter();
            this.noEtNomsAssistantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noEtNomsAssistantsTableAdapter1 = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsAssistantsTableAdapter();
            this.noEtNomsAssistantsComboBox = new System.Windows.Forms.ComboBox();
            this.rapportSoinsAssistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapportSoinsAssistantDataGridView = new System.Windows.Forms.DataGridView();
            this.noEtNomsClientsInvitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noEtNomsClientsInvitesTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsClientsInvitesTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsAssistantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsAssistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsAssistantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsClientsInvitesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rapport des soins journaliers des assistants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Assistant :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(98, 106);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2018, 1, 11, 12, 47, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.onDatepickerChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date :";
            // 
            // bD5B6TP1_ConstantinBrassardLaheyDataSet
            // 
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.DataSetName = "BD5B6TP1_ConstantinBrassardLaheyDataSet";
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // rapportSoinsAssistantTableAdapter
            // 
            this.rapportSoinsAssistantTableAdapter.ClearBeforeFill = true;
            // 
            // noEtNomsAssistantsBindingSource
            // 
            this.noEtNomsAssistantsBindingSource.DataMember = "NoEtNomsAssistants";
            this.noEtNomsAssistantsBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // noEtNomsAssistantsTableAdapter1
            // 
            this.noEtNomsAssistantsTableAdapter1.ClearBeforeFill = true;
            // 
            // noEtNomsAssistantsComboBox
            // 
            this.noEtNomsAssistantsComboBox.DataSource = this.noEtNomsAssistantsBindingSource;
            this.noEtNomsAssistantsComboBox.DisplayMember = "NoEtNom";
            this.noEtNomsAssistantsComboBox.FormattingEnabled = true;
            this.noEtNomsAssistantsComboBox.Location = new System.Drawing.Point(83, 77);
            this.noEtNomsAssistantsComboBox.Name = "noEtNomsAssistantsComboBox";
            this.noEtNomsAssistantsComboBox.Size = new System.Drawing.Size(300, 21);
            this.noEtNomsAssistantsComboBox.TabIndex = 6;
            this.noEtNomsAssistantsComboBox.ValueMember = "NoAssistant";
            // 
            // rapportSoinsAssistantBindingSource
            // 
            this.rapportSoinsAssistantBindingSource.DataMember = "PlanifSoin_Assistant_NoAssistant_fk3";
            this.rapportSoinsAssistantBindingSource.DataSource = this.noEtNomsAssistantsBindingSource;
            // 
            // rapportSoinsAssistantDataGridView
            // 
            this.rapportSoinsAssistantDataGridView.AllowUserToAddRows = false;
            this.rapportSoinsAssistantDataGridView.AllowUserToDeleteRows = false;
            this.rapportSoinsAssistantDataGridView.AllowUserToOrderColumns = true;
            this.rapportSoinsAssistantDataGridView.AutoGenerateColumns = false;
            this.rapportSoinsAssistantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapportSoinsAssistantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.rapportSoinsAssistantDataGridView.DataSource = this.rapportSoinsAssistantBindingSource;
            this.rapportSoinsAssistantDataGridView.Location = new System.Drawing.Point(18, 132);
            this.rapportSoinsAssistantDataGridView.Name = "rapportSoinsAssistantDataGridView";
            this.rapportSoinsAssistantDataGridView.ReadOnly = true;
            this.rapportSoinsAssistantDataGridView.Size = new System.Drawing.Size(594, 293);
            this.rapportSoinsAssistantDataGridView.TabIndex = 7;
            // 
            // noEtNomsClientsInvitesBindingSource
            // 
            this.noEtNomsClientsInvitesBindingSource.DataMember = "NoEtNomsClientsInvites";
            this.noEtNomsClientsInvitesBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // noEtNomsClientsInvitesTableAdapter
            // 
            this.noEtNomsClientsInvitesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateHeure";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateHeure";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NoPersonne";
            this.dataGridViewTextBoxColumn3.DataSource = this.noEtNomsClientsInvitesBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "NoEtNom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom de la personne";
            this.dataGridViewTextBoxColumn3.MaxDropDownItems = 1;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "NoClient";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoAssistant";
            this.dataGridViewTextBoxColumn4.DataSource = this.noEtNomsAssistantsBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "NoEtNom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nom de l\'assistant";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "NoAssistant";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // FrmSoinsAssistants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rapportSoinsAssistantDataGridView);
            this.Controls.Add(this.noEtNomsAssistantsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSoinsAssistants";
            this.Text = "Rapport des soins journaliers des assistants";
            this.Load += new System.EventHandler(this.FrmSoinsAssistants_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateTimePicker, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.noEtNomsAssistantsComboBox, 0);
            this.Controls.SetChildIndex(this.rapportSoinsAssistantDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsAssistantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsAssistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsAssistantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsClientsInvitesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsAssistantsTableAdapter noEtNomsAssistantsTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.AssistantTableAdapter assistantTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.RapportSoinsAssistantTableAdapter rapportSoinsAssistantTableAdapter;
        private System.Windows.Forms.BindingSource noEtNomsAssistantsBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsAssistantsTableAdapter noEtNomsAssistantsTableAdapter1;
        private System.Windows.Forms.BindingNavigator noEtNomsAssistantsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton noEtNomsAssistantsBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox noEtNomsAssistantsComboBox;
        private System.Windows.Forms.BindingSource rapportSoinsAssistantBindingSource;
        private System.Windows.Forms.DataGridView rapportSoinsAssistantDataGridView;
        private System.Windows.Forms.BindingSource noEtNomsClientsInvitesBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsClientsInvitesTableAdapter noEtNomsClientsInvitesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
    }
}