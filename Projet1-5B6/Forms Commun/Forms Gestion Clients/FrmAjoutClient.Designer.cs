namespace Projet1_5B6.Forms_Commun
{
    partial class FrmAjoutClient
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
            this.lblNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblPays = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbPays = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.lblEntete = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Projet1_5B6.BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager();
            this.tbNoClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(13, 115);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(46, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom:";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(159, 112);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(197, 26);
            this.tbNom.TabIndex = 1;
            this.tbNom.TextChanged += new System.EventHandler(this.ValiderFormulaireRempli);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(13, 147);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(64, 20);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(13, 179);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 20);
            this.lblVille.TabIndex = 3;
            this.lblVille.Text = "Ville";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(13, 246);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(72, 20);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse:";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(13, 278);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(99, 20);
            this.lblCodePostal.TabIndex = 5;
            this.lblCodePostal.Text = "Code Postal:";
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(13, 211);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(51, 20);
            this.lblPays.TabIndex = 6;
            this.lblPays.Text = "Pays: ";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(159, 144);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(197, 26);
            this.tbPrenom.TabIndex = 7;
            this.tbPrenom.TextChanged += new System.EventHandler(this.ValiderFormulaireRempli);
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(159, 176);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(197, 26);
            this.tbVille.TabIndex = 8;
            this.tbVille.TextChanged += new System.EventHandler(this.ValiderFormulaireRempli);
            // 
            // tbPays
            // 
            this.tbPays.Location = new System.Drawing.Point(159, 208);
            this.tbPays.Name = "tbPays";
            this.tbPays.Size = new System.Drawing.Size(197, 26);
            this.tbPays.TabIndex = 9;
            this.tbPays.TextChanged += new System.EventHandler(this.ValiderFormulaireRempli);
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(159, 240);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(197, 26);
            this.tbAdresse.TabIndex = 10;
            this.tbAdresse.TextChanged += new System.EventHandler(this.ValiderFormulaireRempli);
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Location = new System.Drawing.Point(159, 272);
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(197, 26);
            this.tbCodePostal.TabIndex = 11;
            this.tbCodePostal.TextChanged += new System.EventHandler(this.ValiderFormulaireRempli);
            // 
            // lblEntete
            // 
            this.lblEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntete.Location = new System.Drawing.Point(12, 9);
            this.lblEntete.Name = "lblEntete";
            this.lblEntete.Size = new System.Drawing.Size(339, 71);
            this.lblEntete.TabIndex = 12;
            this.lblEntete.Text = "Ajouter Client";
            this.lblEntete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAjout
            // 
            this.btnAjout.Enabled = false;
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAjout.Location = new System.Drawing.Point(95, 331);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(175, 33);
            this.btnAjout.TabIndex = 13;
            this.btnAjout.Text = "Confirmer l\'ajout";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // bD5B6TP1_ConstantinBrassardLaheyDataSet
            // 
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.DataSetName = "BD5B6TP1_ConstantinBrassardLaheyDataSet";
            this.bD5B6TP1_ConstantinBrassardLaheyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bD5B6TP1_ConstantinBrassardLaheyDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistantSoinTableAdapter = null;
            this.tableAdapterManager.AssistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
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
            // tbNoClient
            // 
            this.tbNoClient.Location = new System.Drawing.Point(159, 83);
            this.tbNoClient.Name = "tbNoClient";
            this.tbNoClient.ReadOnly = true;
            this.tbNoClient.Size = new System.Drawing.Size(197, 26);
            this.tbNoClient.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "No Client:";
            // 
            // FrmAjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 410);
            this.Controls.Add(this.tbNoClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.lblEntete);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.tbPays);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.lblPays);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblNom);
            this.Name = "FrmAjoutClient";
            this.Text = "Ajouter un client";
            this.Load += new System.EventHandler(this.FrmAjoutClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD5B6TP1_ConstantinBrassardLaheyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbPays;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.Label lblEntete;
        private System.Windows.Forms.Button btnAjout;
        private BD5B6TP1_ConstantinBrassardLaheyDataSet bD5B6TP1_ConstantinBrassardLaheyDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private BD5B6TP1_ConstantinBrassardLaheyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbNoClient;
        private System.Windows.Forms.Label label1;
    }
}