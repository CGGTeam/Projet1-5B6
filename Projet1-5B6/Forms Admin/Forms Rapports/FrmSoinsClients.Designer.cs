namespace Projet1_5B6.Forms_Admin.Fomrs_Rapports
{
    partial class FrmSoinsClients
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
            System.Windows.Forms.Label expr1Label;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noEtNomsClientsInvitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.noEtNomsClientsInvitesTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsClientsInvitesTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.noEtNomsClientsInvitesComboBox = new System.Windows.Forms.ComboBox();
            this.rapportSoinsPersonnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapportSoinsPersonnesTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.RapportSoinsPersonnesTableAdapter();
            this.rapportSoinsPersonnesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumPrixSoinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumPrixSoinsTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.SumPrixSoinsTableAdapter();
            this.expr1TextBox = new System.Windows.Forms.TextBox();
            expr1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsClientsInvitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsPersonnesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsPersonnesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumPrixSoinsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // expr1Label
            // 
            expr1Label.AutoSize = true;
            expr1Label.Location = new System.Drawing.Point(17, 474);
            expr1Label.Name = "expr1Label";
            expr1Label.Size = new System.Drawing.Size(97, 13);
            expr1Label.TabIndex = 5;
            expr1Label.Text = "Prix total des soins:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rapport des soins offerts aux clients et aux invités";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clients / Invités :";
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
            // noEtNomsClientsInvitesTableAdapter
            // 
            this.noEtNomsClientsInvitesTableAdapter.ClearBeforeFill = true;
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
            // noEtNomsClientsInvitesComboBox
            // 
            this.noEtNomsClientsInvitesComboBox.DataSource = this.noEtNomsClientsInvitesBindingSource;
            this.noEtNomsClientsInvitesComboBox.DisplayMember = "NoEtNom";
            this.noEtNomsClientsInvitesComboBox.FormattingEnabled = true;
            this.noEtNomsClientsInvitesComboBox.Location = new System.Drawing.Point(109, 72);
            this.noEtNomsClientsInvitesComboBox.Name = "noEtNomsClientsInvitesComboBox";
            this.noEtNomsClientsInvitesComboBox.Size = new System.Drawing.Size(300, 21);
            this.noEtNomsClientsInvitesComboBox.TabIndex = 4;
            this.noEtNomsClientsInvitesComboBox.ValueMember = "NoClient";
            // 
            // rapportSoinsPersonnesBindingSource
            // 
            this.rapportSoinsPersonnesBindingSource.DataMember = "RapportSoinsPersonnes_NoEtNomsClientsInvites";
            this.rapportSoinsPersonnesBindingSource.DataSource = this.noEtNomsClientsInvitesBindingSource;
            // 
            // rapportSoinsPersonnesTableAdapter
            // 
            this.rapportSoinsPersonnesTableAdapter.ClearBeforeFill = true;
            // 
            // rapportSoinsPersonnesDataGridView
            // 
            this.rapportSoinsPersonnesDataGridView.AllowUserToAddRows = false;
            this.rapportSoinsPersonnesDataGridView.AllowUserToDeleteRows = false;
            this.rapportSoinsPersonnesDataGridView.AllowUserToOrderColumns = true;
            this.rapportSoinsPersonnesDataGridView.AutoGenerateColumns = false;
            this.rapportSoinsPersonnesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapportSoinsPersonnesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rapportSoinsPersonnesDataGridView.DataSource = this.rapportSoinsPersonnesBindingSource;
            this.rapportSoinsPersonnesDataGridView.Location = new System.Drawing.Point(17, 99);
            this.rapportSoinsPersonnesDataGridView.Name = "rapportSoinsPersonnesDataGridView";
            this.rapportSoinsPersonnesDataGridView.ReadOnly = true;
            this.rapportSoinsPersonnesDataGridView.Size = new System.Drawing.Size(687, 358);
            this.rapportSoinsPersonnesDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoPersonne";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoPersonne";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateHeure";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateHeure";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nom Assistant";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nom Assistant";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // sumPrixSoinsBindingSource
            // 
            this.sumPrixSoinsBindingSource.DataMember = "SumPrixSoins_NoEtNomsClientsInvites";
            this.sumPrixSoinsBindingSource.DataSource = this.noEtNomsClientsInvitesBindingSource;
            // 
            // sumPrixSoinsTableAdapter
            // 
            this.sumPrixSoinsTableAdapter.ClearBeforeFill = true;
            // 
            // expr1TextBox
            // 
            this.expr1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sumPrixSoinsBindingSource, "Expr1", true));
            this.expr1TextBox.Location = new System.Drawing.Point(120, 471);
            this.expr1TextBox.Name = "expr1TextBox";
            this.expr1TextBox.ReadOnly = true;
            this.expr1TextBox.Size = new System.Drawing.Size(119, 20);
            this.expr1TextBox.TabIndex = 6;
            // 
            // FrmSoinsClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 523);
            this.Controls.Add(expr1Label);
            this.Controls.Add(this.expr1TextBox);
            this.Controls.Add(this.rapportSoinsPersonnesDataGridView);
            this.Controls.Add(this.noEtNomsClientsInvitesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSoinsClients";
            this.Text = "Rapport des soins offerts aux clients et aux invités";
            this.Load += new System.EventHandler(this.FrmSoinsClients_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.noEtNomsClientsInvitesComboBox, 0);
            this.Controls.SetChildIndex(this.rapportSoinsPersonnesDataGridView, 0);
            this.Controls.SetChildIndex(this.expr1TextBox, 0);
            this.Controls.SetChildIndex(expr1Label, 0);
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomsClientsInvitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsPersonnesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsPersonnesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumPrixSoinsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource noEtNomsClientsInvitesBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomsClientsInvitesTableAdapter noEtNomsClientsInvitesTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox noEtNomsClientsInvitesComboBox;
        private System.Windows.Forms.BindingSource rapportSoinsPersonnesBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.RapportSoinsPersonnesTableAdapter rapportSoinsPersonnesTableAdapter;
        private System.Windows.Forms.DataGridView rapportSoinsPersonnesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource sumPrixSoinsBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.SumPrixSoinsTableAdapter sumPrixSoinsTableAdapter;
        private System.Windows.Forms.TextBox expr1TextBox;
    }
}