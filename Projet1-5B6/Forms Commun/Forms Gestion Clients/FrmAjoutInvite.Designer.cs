namespace Projet1_5B6.Forms_Commun.Forms_Gestion_Clients
{
    partial class FrmAjoutInvite
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
            System.Windows.Forms.Label noInviteLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label noClientLabel;
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inviteTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.InviteTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.tbNoInvite = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbNoClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            noInviteLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            noClientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noInviteLabel
            // 
            noInviteLabel.AutoSize = true;
            noInviteLabel.Location = new System.Drawing.Point(18, 70);
            noInviteLabel.Name = "noInviteLabel";
            noInviteLabel.Size = new System.Drawing.Size(75, 20);
            noInviteLabel.TabIndex = 1;
            noInviteLabel.Text = "No Invite:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(18, 102);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(46, 20);
            nomLabel.TabIndex = 3;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(18, 134);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(68, 20);
            prenomLabel.TabIndex = 5;
            prenomLabel.Text = "Prenom:";
            // 
            // noClientLabel
            // 
            noClientLabel.AutoSize = true;
            noClientLabel.Location = new System.Drawing.Point(18, 166);
            noClientLabel.Name = "noClientLabel";
            noClientLabel.Size = new System.Drawing.Size(77, 20);
            noClientLabel.TabIndex = 7;
            noClientLabel.Text = "No Client:";
            // 
            // bD5B6TP1_ConstantinBrassardLaheyDataSet
            // 
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.DataSetName = "BD5B6TP1_ConstantinBrassardLaheyDataSet";
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inviteBindingSource
            // 
            this.inviteBindingSource.DataMember = "Invite";
            this.inviteBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // inviteTableAdapter
            // 
            this.inviteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.InviteTableAdapter = this.inviteTableAdapter;
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
            // tbNoInvite
            // 
            this.tbNoInvite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inviteBindingSource, "NoInvite", true));
            this.tbNoInvite.Location = new System.Drawing.Point(101, 67);
            this.tbNoInvite.Name = "tbNoInvite";
            this.tbNoInvite.ReadOnly = true;
            this.tbNoInvite.Size = new System.Drawing.Size(142, 26);
            this.tbNoInvite.TabIndex = 2;
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inviteBindingSource, "Nom", true));
            this.tbNom.Location = new System.Drawing.Point(101, 99);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(142, 26);
            this.tbNom.TabIndex = 4;
            // 
            // tbNoClient
            // 
            this.tbNoClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inviteBindingSource, "NoClient", true));
            this.tbNoClient.Location = new System.Drawing.Point(101, 163);
            this.tbNoClient.Name = "tbNoClient";
            this.tbNoClient.ReadOnly = true;
            this.tbNoClient.Size = new System.Drawing.Size(142, 26);
            this.tbNoClient.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ajout Invite";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inviteBindingSource, "Prenom", true));
            this.tbPrenom.Location = new System.Drawing.Point(101, 131);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(142, 26);
            this.tbPrenom.TabIndex = 6;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(62, 204);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(153, 43);
            this.btnConfirmer.TabIndex = 10;
            this.btnConfirmer.Text = "Confirmer l\'ajout";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // FrmAjoutInvite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 259);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.label1);
            this.Controls.Add(noInviteLabel);
            this.Controls.Add(this.tbNoInvite);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(noClientLabel);
            this.Controls.Add(this.tbNoClient);
            this.Name = "FrmAjoutInvite";
            this.Text = "FrmAjoutInvite";
            this.Load += new System.EventHandler(this.FrmAjoutInvite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.InviteTableAdapter inviteTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbNoInvite;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbNoClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Button btnConfirmer;
    }
}