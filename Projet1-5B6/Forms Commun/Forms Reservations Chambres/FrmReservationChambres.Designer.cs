namespace Projet1_5B6.Forms_Admin.ReservationChambres
{
    partial class FrmReservationChambres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listeClients = new System.Windows.Forms.ListBox();
            this.noEtNomClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.noEtNomClientsTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomClientsTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.chambreEtPrixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreEtPrixTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.ChambreEtPrixTableAdapter();
            this.chambreEtPrixDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numericNbPersonne = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.reservationChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationChambreTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.ReservationChambreTableAdapter();
            this.lblFeed = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreEtPrixBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreEtPrixDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbPersonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationChambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listeClients
            // 
            this.listeClients.DataSource = this.noEtNomClientsBindingSource;
            this.listeClients.DisplayMember = "client";
            this.listeClients.FormattingEnabled = true;
            this.listeClients.ItemHeight = 20;
            this.listeClients.Location = new System.Drawing.Point(162, 91);
            this.listeClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listeClients.Name = "listeClients";
            this.listeClients.Size = new System.Drawing.Size(210, 44);
            this.listeClients.TabIndex = 0;
            this.listeClients.ValueMember = "NoClient";
            // 
            // noEtNomClientsBindingSource
            // 
            this.noEtNomClientsBindingSource.DataMember = "NoEtNomClients";
            this.noEtNomClientsBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // bD5B6TP1_ConstantinBrassardLaheyDataSet
            // 
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.DataSetName = "BD5B6TP1_ConstantinBrassardLaheyDataSet";
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noEtNomClientsTableAdapter
            // 
            this.noEtNomClientsTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(39, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client : ";
            // 
            // chambreEtPrixBindingSource
            // 
            this.chambreEtPrixBindingSource.DataMember = "ChambreEtPrix";
            this.chambreEtPrixBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // chambreEtPrixTableAdapter
            // 
            this.chambreEtPrixTableAdapter.ClearBeforeFill = true;
            // 
            // chambreEtPrixDataGridView
            // 
            this.chambreEtPrixDataGridView.AllowUserToAddRows = false;
            this.chambreEtPrixDataGridView.AllowUserToDeleteRows = false;
            this.chambreEtPrixDataGridView.AllowUserToOrderColumns = true;
            this.chambreEtPrixDataGridView.AutoGenerateColumns = false;
            this.chambreEtPrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chambreEtPrixDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.chambreEtPrixDataGridView.DataSource = this.chambreEtPrixBindingSource;
            this.chambreEtPrixDataGridView.Location = new System.Drawing.Point(164, 169);
            this.chambreEtPrixDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chambreEtPrixDataGridView.MultiSelect = false;
            this.chambreEtPrixDataGridView.Name = "chambreEtPrixDataGridView";
            this.chambreEtPrixDataGridView.ReadOnly = true;
            this.chambreEtPrixDataGridView.RowHeadersVisible = false;
            this.chambreEtPrixDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chambreEtPrixDataGridView.Size = new System.Drawing.Size(964, 268);
            this.chambreEtPrixDataGridView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(39, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chambre : ";
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(164, 465);
            this.dateDebut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDebut.MinDate = new System.DateTime(2018, 10, 10, 0, 0, 0, 0);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(298, 26);
            this.dateDebut.TabIndex = 4;
            this.dateDebut.Leave += new System.EventHandler(this.UpdateDatePicker);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(39, 465);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date : ";
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(506, 465);
            this.dateFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFin.MinDate = new System.DateTime(2018, 10, 10, 0, 0, 0, 0);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(298, 26);
            this.dateFin.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(472, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "à";
            // 
            // numericNbPersonne
            // 
            this.numericNbPersonne.Location = new System.Drawing.Point(284, 520);
            this.numericNbPersonne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericNbPersonne.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericNbPersonne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNbPersonne.Name = "numericNbPersonne";
            this.numericNbPersonne.Size = new System.Drawing.Size(180, 26);
            this.numericNbPersonne.TabIndex = 8;
            this.numericNbPersonne.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(39, 520);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre de personnes :";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(44, 585);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(231, 49);
            this.btnConfirmer.TabIndex = 10;
            this.btnConfirmer.Text = "Ajouter la réservation";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Réservation de chambres";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(854, 585);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(274, 49);
            this.btnSupprimer.TabIndex = 13;
            this.btnSupprimer.Text = "Supprimer une réservation antérieur";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // reservationChambreBindingSource
            // 
            this.reservationChambreBindingSource.DataMember = "ReservationChambre";
            this.reservationChambreBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // reservationChambreTableAdapter
            // 
            this.reservationChambreTableAdapter.ClearBeforeFill = true;
            // 
            // lblFeed
            // 
            this.lblFeed.AutoSize = true;
            this.lblFeed.Location = new System.Drawing.Point(285, 585);
            this.lblFeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeed.Name = "lblFeed";
            this.lblFeed.Size = new System.Drawing.Size(0, 20);
            this.lblFeed.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoChambre";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoChambre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Emplacement";
            this.dataGridViewTextBoxColumn2.HeaderText = "Emplacement";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Decoration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Decoration";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrixHaut";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "PrixHaut";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PrixBas";
            dataGridViewCellStyle2.Format = "C2";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "PrixBas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PrixMoyen";
            dataGridViewCellStyle3.Format = "C2";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn6.HeaderText = "PrixMoyen";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // FrmReservationChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 683);
            this.Controls.Add(this.lblFeed);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericNbPersonne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chambreEtPrixDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeClients);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReservationChambres";
            this.Text = "Reservation des Chambres";
            this.Load += new System.EventHandler(this.FrmReservationChambres_Load);
            this.Controls.SetChildIndex(this.listeClients, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.chambreEtPrixDataGridView, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateDebut, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dateFin, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.numericNbPersonne, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnConfirmer, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnSupprimer, 0);
            this.Controls.SetChildIndex(this.lblFeed, 0);
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreEtPrixBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreEtPrixDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbPersonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationChambreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listeClients;
        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource noEtNomClientsBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.NoEtNomClientsTableAdapter noEtNomClientsTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource chambreEtPrixBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.ChambreEtPrixTableAdapter chambreEtPrixTableAdapter;
        private System.Windows.Forms.DataGridView chambreEtPrixDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericNbPersonne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.BindingSource reservationChambreBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.ReservationChambreTableAdapter reservationChambreTableAdapter;
        private System.Windows.Forms.Label lblFeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}