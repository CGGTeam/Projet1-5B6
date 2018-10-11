﻿namespace Projet1_5B6.Forms_Admin
{
    partial class FrmAjoutChambre
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
            System.Windows.Forms.Label noChambreLabel;
            System.Windows.Forms.Label emplacementLabel;
            System.Windows.Forms.Label decorationLabel;
            System.Windows.Forms.Label noTypeChambreLabel;
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.typeChambreTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TypeChambreTableAdapter();
            this.tbNoChambre = new System.Windows.Forms.TextBox();
            this.tbEmplacement = new System.Windows.Forms.TextBox();
            this.tbDecoration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.cboTypeChambre = new System.Windows.Forms.ComboBox();
            this.typeChambreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD5B6TP1ConstantinBrassardLaheyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            noChambreLabel = new System.Windows.Forms.Label();
            emplacementLabel = new System.Windows.Forms.Label();
            decorationLabel = new System.Windows.Forms.Label();
            noTypeChambreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1ConstantinBrassardLaheyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // noChambreLabel
            // 
            noChambreLabel.AutoSize = true;
            noChambreLabel.Location = new System.Drawing.Point(25, 57);
            noChambreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noChambreLabel.Name = "noChambreLabel";
            noChambreLabel.Size = new System.Drawing.Size(69, 13);
            noChambreLabel.TabIndex = 1;
            noChambreLabel.Text = "No Chambre:";
            // 
            // emplacementLabel
            // 
            emplacementLabel.AutoSize = true;
            emplacementLabel.Location = new System.Drawing.Point(25, 78);
            emplacementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emplacementLabel.Name = "emplacementLabel";
            emplacementLabel.Size = new System.Drawing.Size(74, 13);
            emplacementLabel.TabIndex = 3;
            emplacementLabel.Text = "Emplacement:";
            // 
            // decorationLabel
            // 
            decorationLabel.AutoSize = true;
            decorationLabel.Location = new System.Drawing.Point(25, 99);
            decorationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            decorationLabel.Name = "decorationLabel";
            decorationLabel.Size = new System.Drawing.Size(62, 13);
            decorationLabel.TabIndex = 5;
            decorationLabel.Text = "Decoration:";
            // 
            // noTypeChambreLabel
            // 
            noTypeChambreLabel.AutoSize = true;
            noTypeChambreLabel.Location = new System.Drawing.Point(25, 120);
            noTypeChambreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noTypeChambreLabel.Name = "noTypeChambreLabel";
            noTypeChambreLabel.Size = new System.Drawing.Size(96, 13);
            noTypeChambreLabel.TabIndex = 7;
            noTypeChambreLabel.Text = "No Type Chambre:";
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
            this.tableAdapterManager.InviteTableAdapter = null;
            this.tableAdapterManager.NoEtDescriptionSoinTableAdapter = null;
            this.tableAdapterManager.NoEtNomsAssistantsTableAdapter = null;
            this.tableAdapterManager.PlanifSoinTableAdapter = null;
            this.tableAdapterManager.ReservationChambreTableAdapter = null;
            this.tableAdapterManager.SoinTableAdapter = null;
            this.tableAdapterManager.TypeChambreTableAdapter = this.typeChambreTableAdapter;
            this.tableAdapterManager.TypeSoinTableAdapter = null;
            this.tableAdapterManager.TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateurTableAdapter = null;
            // 
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
            // 
            // tbNoChambre
            // 
            this.tbNoChambre.Location = new System.Drawing.Point(123, 55);
            this.tbNoChambre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNoChambre.Name = "tbNoChambre";
            this.tbNoChambre.ReadOnly = true;
            this.tbNoChambre.Size = new System.Drawing.Size(134, 20);
            this.tbNoChambre.TabIndex = 2;
            // 
            // tbEmplacement
            // 
            this.tbEmplacement.Location = new System.Drawing.Point(123, 76);
            this.tbEmplacement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmplacement.Name = "tbEmplacement";
            this.tbEmplacement.Size = new System.Drawing.Size(134, 20);
            this.tbEmplacement.TabIndex = 4;
            // 
            // tbDecoration
            // 
            this.tbDecoration.Location = new System.Drawing.Point(123, 97);
            this.tbDecoration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDecoration.Name = "tbDecoration";
            this.tbDecoration.Size = new System.Drawing.Size(134, 20);
            this.tbDecoration.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ajout d`une chambre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(69, 150);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(132, 25);
            this.btnConfirmer.TabIndex = 10;
            this.btnConfirmer.Text = "Confirmer l\'ajout";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // cboTypeChambre
            // 
            this.cboTypeChambre.DataSource = this.typeChambreBindingSource1;
            this.cboTypeChambre.DisplayMember = "Description";
            this.cboTypeChambre.FormattingEnabled = true;
            this.cboTypeChambre.Location = new System.Drawing.Point(123, 118);
            this.cboTypeChambre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTypeChambre.Name = "cboTypeChambre";
            this.cboTypeChambre.Size = new System.Drawing.Size(134, 21);
            this.cboTypeChambre.TabIndex = 11;
            this.cboTypeChambre.ValueMember = "NoTypeChambre";
            // 
            // typeChambreBindingSource1
            // 
            this.typeChambreBindingSource1.DataMember = "TypeChambre";
            this.typeChambreBindingSource1.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // bD5B6TP1ConstantinBrassardLaheyDataSetBindingSource
            // 
            this.bD5B6TP1ConstantinBrassardLaheyDataSetBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            this.bD5B6TP1ConstantinBrassardLaheyDataSetBindingSource.Position = 0;
            // 
            // typeChambreBindingSource
            // 
            this.typeChambreBindingSource.DataMember = "TypeChambre";
            this.typeChambreBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmAjoutChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 183);
            this.Controls.Add(this.cboTypeChambre);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.label1);
            this.Controls.Add(noChambreLabel);
            this.Controls.Add(this.tbNoChambre);
            this.Controls.Add(emplacementLabel);
            this.Controls.Add(this.tbEmplacement);
            this.Controls.Add(decorationLabel);
            this.Controls.Add(this.tbDecoration);
            this.Controls.Add(noTypeChambreLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAjoutChambre";
            this.Text = "Ajout d\'une chambre";
            this.Load += new System.EventHandler(this.FrmAjoutChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1ConstantinBrassardLaheyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbNoChambre;
        private System.Windows.Forms.TextBox tbEmplacement;
        private System.Windows.Forms.TextBox tbDecoration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmer;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TypeChambreTableAdapter typeChambreTableAdapter;
        private System.Windows.Forms.ComboBox cboTypeChambre;
        private System.Windows.Forms.BindingSource bD5B6TP1ConstantinBrassardLaheyDataSetBindingSource;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private System.Windows.Forms.BindingSource typeChambreBindingSource1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}