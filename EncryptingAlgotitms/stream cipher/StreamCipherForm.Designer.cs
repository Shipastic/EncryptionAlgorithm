namespace EncryptingAlgotitms.stream_cipher
{
    partial class StreamCipherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StreamCipherForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridV1 = new System.Windows.Forms.DataGridView();
            this.buttonShifrT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textKeyViginT = new System.Windows.Forms.TextBox();
            this.textMessageT = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridV2 = new System.Windows.Forms.DataGridView();
            this.buttonDeshifrT = new System.Windows.Forms.Button();
            this.textGetKeyT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textGetShifrT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridKey = new System.Windows.Forms.DataGridView();
            this.textDeShifrT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gridV1);
            this.panel1.Controls.Add(this.buttonShifrT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textKeyViginT);
            this.panel1.Controls.Add(this.textMessageT);
            this.panel1.Location = new System.Drawing.Point(26, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 165);
            this.panel1.TabIndex = 0;
            // 
            // gridV1
            // 
            this.gridV1.AllowUserToAddRows = false;
            this.gridV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV1.Location = new System.Drawing.Point(3, 51);
            this.gridV1.Name = "gridV1";
            this.gridV1.ReadOnly = true;
            this.gridV1.Size = new System.Drawing.Size(1154, 102);
            this.gridV1.TabIndex = 5;
            // 
            // buttonShifrT
            // 
            this.buttonShifrT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShifrT.BackColor = System.Drawing.Color.Teal;
            this.buttonShifrT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShifrT.ForeColor = System.Drawing.Color.Snow;
            this.buttonShifrT.Location = new System.Drawing.Point(1048, 13);
            this.buttonShifrT.Name = "buttonShifrT";
            this.buttonShifrT.Size = new System.Drawing.Size(109, 34);
            this.buttonShifrT.TabIndex = 4;
            this.buttonShifrT.Text = "Шифровать";
            this.buttonShifrT.UseVisualStyleBackColor = false;
            this.buttonShifrT.Click += new System.EventHandler(this.ButtonShifrT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(703, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ключ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходное сообщение";
            // 
            // textKeyViginT
            // 
            this.textKeyViginT.Location = new System.Drawing.Point(759, 21);
            this.textKeyViginT.Name = "textKeyViginT";
            this.textKeyViginT.Size = new System.Drawing.Size(283, 20);
            this.textKeyViginT.TabIndex = 1;
            // 
            // textMessageT
            // 
            this.textMessageT.Location = new System.Drawing.Point(179, 20);
            this.textMessageT.Name = "textMessageT";
            this.textMessageT.Size = new System.Drawing.Size(518, 20);
            this.textMessageT.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.gridV2);
            this.panel2.Controls.Add(this.buttonDeshifrT);
            this.panel2.Controls.Add(this.textGetKeyT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textGetShifrT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(26, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1177, 164);
            this.panel2.TabIndex = 1;
            // 
            // gridV2
            // 
            this.gridV2.AllowUserToAddRows = false;
            this.gridV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV2.Location = new System.Drawing.Point(3, 53);
            this.gridV2.Name = "gridV2";
            this.gridV2.ReadOnly = true;
            this.gridV2.Size = new System.Drawing.Size(1154, 101);
            this.gridV2.TabIndex = 11;
            // 
            // buttonDeshifrT
            // 
            this.buttonDeshifrT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeshifrT.BackColor = System.Drawing.Color.Teal;
            this.buttonDeshifrT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeshifrT.ForeColor = System.Drawing.Color.Snow;
            this.buttonDeshifrT.Location = new System.Drawing.Point(1048, 14);
            this.buttonDeshifrT.Name = "buttonDeshifrT";
            this.buttonDeshifrT.Size = new System.Drawing.Size(109, 32);
            this.buttonDeshifrT.TabIndex = 10;
            this.buttonDeshifrT.Text = "Дешифровать";
            this.buttonDeshifrT.UseVisualStyleBackColor = false;
            this.buttonDeshifrT.Click += new System.EventHandler(this.ButtonDeShifrT_Click);
            // 
            // textGetKeyT
            // 
            this.textGetKeyT.Location = new System.Drawing.Point(759, 21);
            this.textGetKeyT.Name = "textGetKeyT";
            this.textGetKeyT.Size = new System.Drawing.Size(283, 20);
            this.textGetKeyT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Зашифрованное сообщение";
            // 
            // textGetShifrT
            // 
            this.textGetShifrT.Location = new System.Drawing.Point(235, 21);
            this.textGetShifrT.Name = "textGetShifrT";
            this.textGetShifrT.Size = new System.Drawing.Size(462, 20);
            this.textGetShifrT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(703, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ключ";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.gridKey);
            this.panel3.Controls.Add(this.textDeShifrT);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(26, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1177, 433);
            this.panel3.TabIndex = 1;
            // 
            // gridKey
            // 
            this.gridKey.AllowUserToAddRows = false;
            this.gridKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKey.Location = new System.Drawing.Point(3, 67);
            this.gridKey.Name = "gridKey";
            this.gridKey.ReadOnly = true;
            this.gridKey.Size = new System.Drawing.Size(1154, 352);
            this.gridKey.TabIndex = 17;
            // 
            // textDeShifrT
            // 
            this.textDeShifrT.Location = new System.Drawing.Point(321, 6);
            this.textDeShifrT.Name = "textDeShifrT";
            this.textDeShifrT.Size = new System.Drawing.Size(738, 20);
            this.textDeShifrT.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Расшифрованное сообщение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(494, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Таблица алфавита для шифрования/дешифрования по ключу";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // StreamCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1215, 737);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1231, 776);
            this.Name = "StreamCipherForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подстановочный шифр Виженера";
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
        private System.Windows.Forms.Button buttonShifrT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKeyViginT;
        private System.Windows.Forms.TextBox textMessageT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridV2;
        private System.Windows.Forms.Button buttonDeshifrT;
        private System.Windows.Forms.TextBox textGetKeyT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textGetShifrT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridKey;
        private System.Windows.Forms.TextBox textDeShifrT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}