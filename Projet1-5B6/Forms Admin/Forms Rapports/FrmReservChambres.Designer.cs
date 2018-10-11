namespace Projet1_5B6.Forms_Admin.Fomrs_Rapports
{
    partial class FrmReservChambres
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
            this.noEtEmplacementChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.noEtEmplacementChambreTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtEmplacementChambreTableAdapter();
            this.rapportChambreTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.RapportChambreTableAdapter();
            this.noEtEmplacementChambreComboBox = new System.Windows.Forms.ComboBox();
            this.rapportChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapportChambreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.noEtEmplacementChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportChambreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rapport des réservations de chambres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "chambre :";
            // 
            // noEtEmplacementChambreBindingSource
            // 
            this.noEtEmplacementChambreBindingSource.DataMember = "NoEtEmplacementChambre";
            this.noEtEmplacementChambreBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
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
            // noEtEmplacementChambreTableAdapter
            // 
            this.noEtEmplacementChambreTableAdapter.ClearBeforeFill = true;
            // 
            // rapportChambreTableAdapter
            // 
            this.rapportChambreTableAdapter.ClearBeforeFill = true;
            // 
            // noEtEmplacementChambreComboBox
            // 
            this.noEtEmplacementChambreComboBox.DataSource = this.noEtEmplacementChambreBindingSource;
            this.noEtEmplacementChambreComboBox.DisplayMember = "NoEtEmplacement";
            this.noEtEmplacementChambreComboBox.FormattingEnabled = true;
            this.noEtEmplacementChambreComboBox.Location = new System.Drawing.Point(74, 69);
            this.noEtEmplacementChambreComboBox.Name = "noEtEmplacementChambreComboBox";
            this.noEtEmplacementChambreComboBox.Size = new System.Drawing.Size(300, 21);
            this.noEtEmplacementChambreComboBox.TabIndex = 4;
            this.noEtEmplacementChambreComboBox.ValueMember = "NoChambre";
            // 
            // rapportChambreBindingSource
            // 
            this.rapportChambreBindingSource.DataMember = "ReservationChambre_Chambre_NoChambre_fk4";
            this.rapportChambreBindingSource.DataSource = this.noEtEmplacementChambreBindingSource;
            // 
            // rapportChambreDataGridView
            // 
            this.rapportChambreDataGridView.AllowUserToAddRows = false;
            this.rapportChambreDataGridView.AllowUserToDeleteRows = false;
            this.rapportChambreDataGridView.AllowUserToOrderColumns = true;
            this.rapportChambreDataGridView.AutoGenerateColumns = false;
            this.rapportChambreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapportChambreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rapportChambreDataGridView.DataSource = this.rapportChambreBindingSource;
            this.rapportChambreDataGridView.Location = new System.Drawing.Point(12, 96);
            this.rapportChambreDataGridView.Name = "rapportChambreDataGridView";
            this.rapportChambreDataGridView.ReadOnly = true;
            this.rapportChambreDataGridView.Size = new System.Drawing.Size(608, 350);
            this.rapportChambreDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomClient";
            this.dataGridViewTextBoxColumn1.HeaderText = "NomClient";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateArrivee";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateArrivee";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateDepart";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateDepart";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NbPersonnes";
            this.dataGridViewTextBoxColumn4.HeaderText = "NbPersonnes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NoChambre";
            this.dataGridViewTextBoxColumn5.HeaderText = "NoChambre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // FrmReservChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 458);
            this.Controls.Add(this.rapportChambreDataGridView);
            this.Controls.Add(this.noEtEmplacementChambreComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmReservChambres";
            this.Text = "Rapport des réservations de chambres";
            this.Load += new System.EventHandler(this.FrmReservChambres_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.noEtEmplacementChambreComboBox, 0);
            this.Controls.SetChildIndex(this.rapportChambreDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.noEtEmplacementChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportChambreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource noEtEmplacementChambreBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtEmplacementChambreTableAdapter noEtEmplacementChambreTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.RapportChambreTableAdapter rapportChambreTableAdapter;
        private System.Windows.Forms.ComboBox noEtEmplacementChambreComboBox;
        private System.Windows.Forms.BindingSource rapportChambreBindingSource;
        private System.Windows.Forms.DataGridView rapportChambreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}