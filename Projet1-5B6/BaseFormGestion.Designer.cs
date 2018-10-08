namespace Projet1_5B6
{
    partial class BaseFormGestion
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
            this.placeholderMenu = new System.Windows.Forms.MenuStrip();
            this.pLACEHOLDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // placeholderMenu
            // 
            this.placeholderMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.placeholderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLACEHOLDERToolStripMenuItem});
            this.placeholderMenu.Location = new System.Drawing.Point(0, 0);
            this.placeholderMenu.Name = "placeholderMenu";
            this.placeholderMenu.Size = new System.Drawing.Size(800, 33);
            this.placeholderMenu.TabIndex = 0;
            this.placeholderMenu.Text = "menuStrip1";
            // 
            // pLACEHOLDERToolStripMenuItem
            // 
            this.pLACEHOLDERToolStripMenuItem.Name = "pLACEHOLDERToolStripMenuItem";
            this.pLACEHOLDERToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.pLACEHOLDERToolStripMenuItem.Text = "PLACEHOLDER";
            // 
            // BaseFormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.placeholderMenu);
            this.MainMenuStrip = this.placeholderMenu;
            this.Name = "BaseFormGestion";
            this.Text = "BaseFormGestion";
            this.placeholderMenu.ResumeLayout(false);
            this.placeholderMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip placeholderMenu;
        private System.Windows.Forms.ToolStripMenuItem pLACEHOLDERToolStripMenuItem;
    }
}