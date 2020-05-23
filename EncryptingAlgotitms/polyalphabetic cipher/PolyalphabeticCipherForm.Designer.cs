namespace EncryptingAlgotitms.polyalphabetic_cipher
{
    partial class PolyalphabeticCipherForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridV1 = new System.Windows.Forms.DataGridView();
            this.buttonShifr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textKeyVigin = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridV2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeshifr = new System.Windows.Forms.Button();
            this.textGetShifr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textGetKey = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.gridKey = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textDeShifr = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridV1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridV2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKey)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.gridV1);
            this.panel1.Controls.Add(this.buttonShifr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textKeyVigin);
            this.panel1.Controls.Add(this.textMessage);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 214);
            this.panel1.TabIndex = 0;
            // 
            // gridV1
            // 
            this.gridV1.AllowUserToAddRows = false;
            this.gridV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV1.Location = new System.Drawing.Point(3, 61);
            this.gridV1.Name = "gridV1";
            this.gridV1.ReadOnly = true;
            this.gridV1.Size = new System.Drawing.Size(867, 150);
            this.gridV1.TabIndex = 5;
            // 
            // buttonShifr
            // 
            this.buttonShifr.BackColor = System.Drawing.SystemColors.MenuText;
            this.buttonShifr.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShifr.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonShifr.Location = new System.Drawing.Point(760, 14);
            this.buttonShifr.Name = "buttonShifr";
            this.buttonShifr.Size = new System.Drawing.Size(107, 37);
            this.buttonShifr.TabIndex = 4;
            this.buttonShifr.Text = "Шифровать";
            this.buttonShifr.UseVisualStyleBackColor = false;
            this.buttonShifr.Click += new System.EventHandler(this.ButtonShifr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ключ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходное сообщение";
            // 
            // textKeyVigin
            // 
            this.textKeyVigin.Location = new System.Drawing.Point(517, 23);
            this.textKeyVigin.Name = "textKeyVigin";
            this.textKeyVigin.Size = new System.Drawing.Size(200, 20);
            this.textKeyVigin.TabIndex = 1;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(189, 22);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(256, 20);
            this.textMessage.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.gridV2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonDeshifr);
            this.panel2.Controls.Add(this.textGetShifr);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textGetKey);
            this.panel2.Location = new System.Drawing.Point(12, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 214);
            this.panel2.TabIndex = 1;
            // 
            // gridV2
            // 
            this.gridV2.AllowUserToAddRows = false;
            this.gridV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV2.Location = new System.Drawing.Point(3, 61);
            this.gridV2.Name = "gridV2";
            this.gridV2.ReadOnly = true;
            this.gridV2.Size = new System.Drawing.Size(864, 150);
            this.gridV2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Шифр";
            // 
            // buttonDeshifr
            // 
            this.buttonDeshifr.BackColor = System.Drawing.SystemColors.MenuText;
            this.buttonDeshifr.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeshifr.ForeColor = System.Drawing.Color.LimeGreen;
            this.buttonDeshifr.Location = new System.Drawing.Point(744, 15);
            this.buttonDeshifr.Name = "buttonDeshifr";
            this.buttonDeshifr.Size = new System.Drawing.Size(123, 37);
            this.buttonDeshifr.TabIndex = 10;
            this.buttonDeshifr.Text = "Расшифровать";
            this.buttonDeshifr.UseVisualStyleBackColor = false;
            this.buttonDeshifr.Click += new System.EventHandler(this.ButtonDeShifr_Click);
            // 
            // textGetShifr
            // 
            this.textGetShifr.Location = new System.Drawing.Point(189, 24);
            this.textGetShifr.Name = "textGetShifr";
            this.textGetShifr.Size = new System.Drawing.Size(256, 20);
            this.textGetShifr.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ключ";
            // 
            // textGetKey
            // 
            this.textGetKey.Location = new System.Drawing.Point(517, 24);
            this.textGetKey.Name = "textGetKey";
            this.textGetKey.Size = new System.Drawing.Size(200, 20);
            this.textGetKey.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.gridKey);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textDeShifr);
            this.panel3.Location = new System.Drawing.Point(12, 478);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 326);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(422, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Таблица алфавита для шифрования/дешифрования";
            // 
            // gridKey
            // 
            this.gridKey.AllowUserToAddRows = false;
            this.gridKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKey.Location = new System.Drawing.Point(4, 104);
            this.gridKey.Name = "gridKey";
            this.gridKey.ReadOnly = true;
            this.gridKey.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridKey.Size = new System.Drawing.Size(879, 219);
            this.gridKey.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Расшифрованное сообщение";
            // 
            // textDeShifr
            // 
            this.textDeShifr.Location = new System.Drawing.Point(334, 23);
            this.textDeShifr.Name = "textDeShifr";
            this.textDeShifr.Size = new System.Drawing.Size(316, 20);
            this.textDeShifr.TabIndex = 13;
            // 
            // PolyalphabeticCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(938, 737);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PolyalphabeticCipherForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Полиалфавитный шифр";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridV1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridV2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridV1;
        private System.Windows.Forms.Button buttonShifr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKeyVigin;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridV2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeshifr;
        private System.Windows.Forms.TextBox textGetShifr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textGetKey;
        private System.Windows.Forms.DataGridView gridKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDeShifr;
        private System.Windows.Forms.Label label6;
    }
}