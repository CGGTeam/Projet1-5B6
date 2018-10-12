namespace Projet1_5B6.Forms_Admin.Forms_Gestion_Assistants
{
    partial class FrmAddAssistant
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
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbRemarques = new System.Windows.Forms.TextBox();
            this.tbSpecialite = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErrorProvider = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNoAssistant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(97, 72);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(124, 20);
            this.tbPrenom.TabIndex = 1;
            this.tbPrenom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValiderFormulaire);
            // 
            // tbRemarques
            // 
            this.tbRemarques.Location = new System.Drawing.Point(97, 150);
            this.tbRemarques.Name = "tbRemarques";
            this.tbRemarques.Size = new System.Drawing.Size(124, 20);
            this.tbRemarques.TabIndex = 4;
            // 
            // tbSpecialite
            // 
            this.tbSpecialite.Location = new System.Drawing.Point(97, 124);
            this.tbSpecialite.Name = "tbSpecialite";
            this.tbSpecialite.Size = new System.Drawing.Size(124, 20);
            this.tbSpecialite.TabIndex = 3;
            this.tbSpecialite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValiderFormulaire);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(97, 98);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(124, 20);
            this.tbNom.TabIndex = 2;
            this.tbNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValiderFormulaire);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prénom * :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom * :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Spécialité * :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Remarques :";
            // 
            // lblErrorProvider
            // 
            this.lblErrorProvider.AutoSize = true;
            this.lblErrorProvider.ForeColor = System.Drawing.Color.Black;
            this.lblErrorProvider.Location = new System.Drawing.Point(17, 184);
            this.lblErrorProvider.Name = "lblErrorProvider";
            this.lblErrorProvider.Size = new System.Drawing.Size(192, 13);
            this.lblErrorProvider.TabIndex = 1;
            this.lblErrorProvider.Text = "Les champs avec un * sont obligatoires";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Enabled = false;
            this.btnConfirmer.Location = new System.Drawing.Point(5, 199);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(229, 25);
            this.btnConfirmer.TabIndex = 5;
            this.btnConfirmer.Text = "Confirmer l\'ajout";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(15, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(219, 25);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "Ajout d\'un assistant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "No d\'assistant:";
            // 
            // tbNoAssistant
            // 
            this.tbNoAssistant.Location = new System.Drawing.Point(97, 46);
            this.tbNoAssistant.Name = "tbNoAssistant";
            this.tbNoAssistant.ReadOnly = true;
            this.tbNoAssistant.Size = new System.Drawing.Size(124, 20);
            this.tbNoAssistant.TabIndex = 16;
            // 
            // FrmAddAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 235);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNoAssistant);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblErrorProvider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbSpecialite);
            this.Controls.Add(this.tbRemarques);
            this.Controls.Add(this.tbPrenom);
            this.Name = "FrmAddAssistant";
            this.Text = "FrmAddAssistant";
            this.Load += new System.EventHandler(this.FrmAddAssistant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbRemarques;
        private System.Windows.Forms.TextBox tbSpecialite;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorProvider;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNoAssistant;
    }
}