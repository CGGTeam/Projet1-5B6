namespace Projet1_5B6.Forms_Admin
{
    partial class FrmGestionChambresEtTypes
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
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TypeChambreTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.typeChambreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.ChambreTableAdapter();
            this.chambreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimerType = new System.Windows.Forms.Button();
            this.btnAjouterType = new System.Windows.Forms.Button();
            this.btnSupprimerChambre = new System.Windows.Forms.Button();
            this.btnAjouterChambre = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.lblEnteteTypeChambre = new System.Windows.Forms.Label();
            this.lblEnteteTypeDeChambre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreDataGridView)).BeginInit();
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
            // typeChambreDataGridView
            // 
            this.typeChambreDataGridView.AllowUserToAddRows = false;
            this.typeChambreDataGridView.AllowUserToDeleteRows = false;
            this.typeChambreDataGridView.AutoGenerateColumns = false;
            this.typeChambreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.typeChambreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeChambreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.typeChambreDataGridView.DataSource = this.typeChambreBindingSource;
            this.typeChambreDataGridView.Location = new System.Drawing.Point(0, 111);
            this.typeChambreDataGridView.Name = "typeChambreDataGridView";
            this.typeChambreDataGridView.RowTemplate.Height = 28;
            this.typeChambreDataGridView.Size = new System.Drawing.Size(684, 236);
            this.typeChambreDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoTypeChambre";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrixHaut";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix Haute Saison";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrixBas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prix Basse Saison";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PrixMoyen";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prix Moyen";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "Chambre_TypeChambre_NoTypeChambre_fk";
            this.chambreBindingSource.DataSource = this.typeChambreBindingSource;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // chambreDataGridView
            // 
            this.chambreDataGridView.AutoGenerateColumns = false;
            this.chambreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chambreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chambreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.chambreDataGridView.DataSource = this.chambreBindingSource;
            this.chambreDataGridView.Location = new System.Drawing.Point(705, 111);
            this.chambreDataGridView.Name = "chambreDataGridView";
            this.chambreDataGridView.RowTemplate.Height = 28;
            this.chambreDataGridView.Size = new System.Drawing.Size(533, 236);
            this.chambreDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NoChambre";
            this.dataGridViewTextBoxColumn6.HeaderText = "No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Emplacement";
            this.dataGridViewTextBoxColumn7.HeaderText = "Emplacement";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Decoration";
            this.dataGridViewTextBoxColumn8.HeaderText = "Decoration";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnSupprimerType
            // 
            this.btnSupprimerType.Location = new System.Drawing.Point(337, 380);
            this.btnSupprimerType.Name = "btnSupprimerType";
            this.btnSupprimerType.Size = new System.Drawing.Size(213, 32);
            this.btnSupprimerType.TabIndex = 6;
            this.btnSupprimerType.Text = "Supprimer type de chambre";
            this.btnSupprimerType.UseVisualStyleBackColor = true;
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.Location = new System.Drawing.Point(94, 380);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(213, 32);
            this.btnAjouterType.TabIndex = 5;
            this.btnAjouterType.Text = "Ajouter type de chambre";
            this.btnAjouterType.UseVisualStyleBackColor = true;
            this.btnAjouterType.Click += new System.EventHandler(this.btnAjouterType_Click);
            // 
            // btnSupprimerChambre
            // 
            this.btnSupprimerChambre.Location = new System.Drawing.Point(991, 380);
            this.btnSupprimerChambre.Name = "btnSupprimerChambre";
            this.btnSupprimerChambre.Size = new System.Drawing.Size(213, 32);
            this.btnSupprimerChambre.TabIndex = 8;
            this.btnSupprimerChambre.Text = "Supprimer chambre";
            this.btnSupprimerChambre.UseVisualStyleBackColor = true;
            // 
            // btnAjouterChambre
            // 
            this.btnAjouterChambre.Location = new System.Drawing.Point(748, 380);
            this.btnAjouterChambre.Name = "btnAjouterChambre";
            this.btnAjouterChambre.Size = new System.Drawing.Size(213, 32);
            this.btnAjouterChambre.TabIndex = 7;
            this.btnAjouterChambre.Text = "Ajouter chambre";
            this.btnAjouterChambre.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(648, 446);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(213, 32);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler modifications";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(405, 446);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(213, 32);
            this.btnSauvegarder.TabIndex = 9;
            this.btnSauvegarder.Text = "Sauvegarder modifications";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            // 
            // lblEnteteTypeChambre
            // 
            this.lblEnteteTypeChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnteteTypeChambre.Location = new System.Drawing.Point(0, 33);
            this.lblEnteteTypeChambre.Name = "lblEnteteTypeChambre";
            this.lblEnteteTypeChambre.Size = new System.Drawing.Size(684, 75);
            this.lblEnteteTypeChambre.TabIndex = 11;
            this.lblEnteteTypeChambre.Text = "Types de chambres";
            this.lblEnteteTypeChambre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnteteTypeDeChambre
            // 
            this.lblEnteteTypeDeChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnteteTypeDeChambre.Location = new System.Drawing.Point(705, 33);
            this.lblEnteteTypeDeChambre.Name = "lblEnteteTypeDeChambre";
            this.lblEnteteTypeDeChambre.Size = new System.Drawing.Size(533, 75);
            this.lblEnteteTypeDeChambre.TabIndex = 12;
            this.lblEnteteTypeDeChambre.Text = "Chambres du type sélectionné";
            this.lblEnteteTypeDeChambre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmGestionChambresEtTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 549);
            this.Controls.Add(this.lblEnteteTypeDeChambre);
            this.Controls.Add(this.lblEnteteTypeChambre);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.btnSupprimerChambre);
            this.Controls.Add(this.btnAjouterChambre);
            this.Controls.Add(this.btnSupprimerType);
            this.Controls.Add(this.btnAjouterType);
            this.Controls.Add(this.chambreDataGridView);
            this.Controls.Add(this.typeChambreDataGridView);
            this.Name = "FrmGestionChambresEtTypes";
            this.Text = "GestionChambresEtTypes";
            this.Load += new System.EventHandler(this.GestionChambresEtTypes_Load);
            this.Controls.SetChildIndex(this.typeChambreDataGridView, 0);
            this.Controls.SetChildIndex(this.chambreDataGridView, 0);
            this.Controls.SetChildIndex(this.btnAjouterType, 0);
            this.Controls.SetChildIndex(this.btnSupprimerType, 0);
            this.Controls.SetChildIndex(this.btnAjouterChambre, 0);
            this.Controls.SetChildIndex(this.btnSupprimerChambre, 0);
            this.Controls.SetChildIndex(this.btnSauvegarder, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.Controls.SetChildIndex(this.lblEnteteTypeChambre, 0);
            this.Controls.SetChildIndex(this.lblEnteteTypeDeChambre, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TypeChambreTableAdapter typeChambreTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView typeChambreDataGridView;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.ChambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.DataGridView chambreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnSupprimerType;
        private System.Windows.Forms.Button btnAjouterType;
        private System.Windows.Forms.Button btnSupprimerChambre;
        private System.Windows.Forms.Button btnAjouterChambre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Label lblEnteteTypeChambre;
        private System.Windows.Forms.Label lblEnteteTypeDeChambre;
    }
}