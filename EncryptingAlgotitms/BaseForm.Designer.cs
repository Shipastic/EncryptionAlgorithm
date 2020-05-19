namespace EncryptingAlgotitms
{
    partial class BaseForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAlgorithmEncryptingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permutationCipherVigenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polyalphabeticCipherVigenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamCipherVigenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyExchangeDiffiHallmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.propertyWindowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.propertyWindowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAlgorithmEncryptingToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openAlgorithmEncryptingToolStripMenuItem
            // 
            this.openAlgorithmEncryptingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permutationCipherVigenerToolStripMenuItem,
            this.polyalphabeticCipherVigenerToolStripMenuItem,
            this.streamCipherVigenerToolStripMenuItem,
            this.keyExchangeDiffiHallmanToolStripMenuItem});
            this.openAlgorithmEncryptingToolStripMenuItem.Name = "openAlgorithmEncryptingToolStripMenuItem";
            this.openAlgorithmEncryptingToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openAlgorithmEncryptingToolStripMenuItem.Text = "Open Algorithm Encrypting";
            // 
            // permutationCipherVigenerToolStripMenuItem
            // 
            this.permutationCipherVigenerToolStripMenuItem.Name = "permutationCipherVigenerToolStripMenuItem";
            this.permutationCipherVigenerToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.permutationCipherVigenerToolStripMenuItem.Text = "Permutation Cipher Vigener";
            this.permutationCipherVigenerToolStripMenuItem.Click += new System.EventHandler(this.PermutationCipherVigenerToolStripMenuItem_Click);
            // 
            // propertyWindowToolStripMenuItem
            // 
            this.propertyWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layotToolStripMenuItem});
            this.propertyWindowToolStripMenuItem.Name = "propertyWindowToolStripMenuItem";
            this.propertyWindowToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.propertyWindowToolStripMenuItem.Text = "Property Window";
            // 
            // layotToolStripMenuItem
            // 
            this.layotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.layotToolStripMenuItem.Name = "layotToolStripMenuItem";
            this.layotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.layotToolStripMenuItem.Text = "Layot";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.VerticalToolStripMenuItem_Click);
            // 
            // polyalphabeticCipherVigenerToolStripMenuItem
            // 
            this.polyalphabeticCipherVigenerToolStripMenuItem.Name = "polyalphabeticCipherVigenerToolStripMenuItem";
            this.polyalphabeticCipherVigenerToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.polyalphabeticCipherVigenerToolStripMenuItem.Text = "Polyalphabetic Cipher Vigener";
            this.polyalphabeticCipherVigenerToolStripMenuItem.Click += new System.EventHandler(this.polyalphabeticCipherVigenerToolStripMenuItem_Click);
            // 
            // streamCipherVigenerToolStripMenuItem
            // 
            this.streamCipherVigenerToolStripMenuItem.Name = "streamCipherVigenerToolStripMenuItem";
            this.streamCipherVigenerToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.streamCipherVigenerToolStripMenuItem.Text = "Stream Cipher Vigener";
            this.streamCipherVigenerToolStripMenuItem.Click += new System.EventHandler(this.streamCipherVigenerToolStripMenuItem_Click);
            // 
            // keyExchangeDiffiHallmanToolStripMenuItem
            // 
            this.keyExchangeDiffiHallmanToolStripMenuItem.Name = "keyExchangeDiffiHallmanToolStripMenuItem";
            this.keyExchangeDiffiHallmanToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.keyExchangeDiffiHallmanToolStripMenuItem.Text = "Key Exchange Diffi- Hallman";
            this.keyExchangeDiffiHallmanToolStripMenuItem.Click += new System.EventHandler(this.keyExchangeDiffiHallmanToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAlgorithmEncryptingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permutationCipherVigenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polyalphabeticCipherVigenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamCipherVigenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyExchangeDiffiHallmanToolStripMenuItem;
    }
}

