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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAlgorithmEncryptingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permutationCipherVigenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polyalphabeticCipherVigenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamCipherVigenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyExchangeDiffiHallmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationAboutAlgorithmVigenera1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.propertyWindowToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // openAlgorithmEncryptingToolStripMenuItem
            // 
            this.openAlgorithmEncryptingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permutationCipherVigenerToolStripMenuItem,
            this.polyalphabeticCipherVigenerToolStripMenuItem,
            this.streamCipherVigenerToolStripMenuItem,
            this.keyExchangeDiffiHallmanToolStripMenuItem,
            this.rSAToolStripMenuItem});
            this.openAlgorithmEncryptingToolStripMenuItem.Name = "openAlgorithmEncryptingToolStripMenuItem";
            this.openAlgorithmEncryptingToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.openAlgorithmEncryptingToolStripMenuItem.Text = "Выбор алгоритма шифрования";
            // 
            // permutationCipherVigenerToolStripMenuItem
            // 
            this.permutationCipherVigenerToolStripMenuItem.Name = "permutationCipherVigenerToolStripMenuItem";
            this.permutationCipherVigenerToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.permutationCipherVigenerToolStripMenuItem.Text = "Перестановочный шифр";
            this.permutationCipherVigenerToolStripMenuItem.Click += new System.EventHandler(this.PermutationCipherVigenerToolStripMenuItem_Click);
            // 
            // polyalphabeticCipherVigenerToolStripMenuItem
            // 
            this.polyalphabeticCipherVigenerToolStripMenuItem.Name = "polyalphabeticCipherVigenerToolStripMenuItem";
            this.polyalphabeticCipherVigenerToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.polyalphabeticCipherVigenerToolStripMenuItem.Text = "Полиалфавитный шифр Виженера";
            this.polyalphabeticCipherVigenerToolStripMenuItem.Click += new System.EventHandler(this.PolyalphabeticCipherVigenerToolStripMenuItem_Click);
            // 
            // streamCipherVigenerToolStripMenuItem
            // 
            this.streamCipherVigenerToolStripMenuItem.Name = "streamCipherVigenerToolStripMenuItem";
            this.streamCipherVigenerToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.streamCipherVigenerToolStripMenuItem.Text = "Потоковый шифр Виженера";
            this.streamCipherVigenerToolStripMenuItem.Click += new System.EventHandler(this.StreamCipherVigenerToolStripMenuItem_Click);
            // 
            // keyExchangeDiffiHallmanToolStripMenuItem
            // 
            this.keyExchangeDiffiHallmanToolStripMenuItem.Name = "keyExchangeDiffiHallmanToolStripMenuItem";
            this.keyExchangeDiffiHallmanToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.keyExchangeDiffiHallmanToolStripMenuItem.Text = "Ключевой обмен Диффи-Хеллмана";
            this.keyExchangeDiffiHallmanToolStripMenuItem.Click += new System.EventHandler(this.KeyExchangeDiffiHallmanToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.rSAToolStripMenuItem.Text = "РСА";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.RSAToolStripMenuItem_Click);
            // 
            // propertyWindowToolStripMenuItem
            // 
            this.propertyWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layotToolStripMenuItem});
            this.propertyWindowToolStripMenuItem.Name = "propertyWindowToolStripMenuItem";
            this.propertyWindowToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.propertyWindowToolStripMenuItem.Text = "Вид";
            // 
            // layotToolStripMenuItem
            // 
            this.layotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.layotToolStripMenuItem.Name = "layotToolStripMenuItem";
            this.layotToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.layotToolStripMenuItem.Text = "Режим отображения окон";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cascadeToolStripMenuItem.Text = "Каскадом";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.verticalToolStripMenuItem.Text = "Вертикально";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.VerticalToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationAboutAlgorithmVigenera1ToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // informationAboutAlgorithmVigenera1ToolStripMenuItem
            // 
            this.informationAboutAlgorithmVigenera1ToolStripMenuItem.Name = "informationAboutAlgorithmVigenera1ToolStripMenuItem";
            this.informationAboutAlgorithmVigenera1ToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.informationAboutAlgorithmVigenera1ToolStripMenuItem.Text = "Справка по алгоритмам шифрования";
            this.informationAboutAlgorithmVigenera1ToolStripMenuItem.Click += new System.EventHandler(this.InformationAboutAlgorithmVigenera1ToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.aboutProgramToolStripMenuItem.Text = "О Программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритмы Шифрования";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText;
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
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationAboutAlgorithmVigenera1ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
    }
}

