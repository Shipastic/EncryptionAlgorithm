namespace EncryptingAlgotitms.key_exchage_DH
{
    partial class KeyExchangeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.butGenX = new System.Windows.Forms.Button();
            this.butKeyA = new System.Windows.Forms.Button();
            this.butGenerateA = new System.Windows.Forms.Button();
            this.textKeyA = new System.Windows.Forms.TextBox();
            this.textX = new System.Windows.Forms.TextBox();
            this.textA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.butGenY = new System.Windows.Forms.Button();
            this.butKeyB = new System.Windows.Forms.Button();
            this.butGenerateB = new System.Windows.Forms.Button();
            this.textKeyB = new System.Windows.Forms.TextBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butG = new System.Windows.Forms.Button();
            this.butP = new System.Windows.Forms.Button();
            this.textG = new System.Windows.Forms.TextBox();
            this.textP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.butGenX);
            this.panel1.Controls.Add(this.butKeyA);
            this.panel1.Controls.Add(this.butGenerateA);
            this.panel1.Controls.Add(this.textKeyA);
            this.panel1.Controls.Add(this.textX);
            this.panel1.Controls.Add(this.textA);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 343);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "АБОНЕНТ 1";
            // 
            // butGenX
            // 
            this.butGenX.BackColor = System.Drawing.SystemColors.MenuText;
            this.butGenX.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGenX.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butGenX.Location = new System.Drawing.Point(183, 173);
            this.butGenX.Name = "butGenX";
            this.butGenX.Size = new System.Drawing.Size(184, 39);
            this.butGenX.TabIndex = 7;
            this.butGenX.Text = "Рассчитать";
            this.butGenX.UseVisualStyleBackColor = false;
            this.butGenX.Click += new System.EventHandler(this.ButGenX_Click);
            // 
            // butKeyA
            // 
            this.butKeyA.BackColor = System.Drawing.SystemColors.MenuText;
            this.butKeyA.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butKeyA.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butKeyA.Location = new System.Drawing.Point(77, 278);
            this.butKeyA.Name = "butKeyA";
            this.butKeyA.Size = new System.Drawing.Size(290, 39);
            this.butKeyA.TabIndex = 8;
            this.butKeyA.Text = "Общий секретный ключ";
            this.butKeyA.UseVisualStyleBackColor = false;
            this.butKeyA.Click += new System.EventHandler(this.ButKeyA_Click);
            // 
            // butGenerateA
            // 
            this.butGenerateA.BackColor = System.Drawing.SystemColors.MenuText;
            this.butGenerateA.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGenerateA.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butGenerateA.Location = new System.Drawing.Point(183, 85);
            this.butGenerateA.Name = "butGenerateA";
            this.butGenerateA.Size = new System.Drawing.Size(184, 41);
            this.butGenerateA.TabIndex = 6;
            this.butGenerateA.Text = "Сгенерировать";
            this.butGenerateA.UseVisualStyleBackColor = false;
            this.butGenerateA.Click += new System.EventHandler(this.ButGenerateA_Click);
            // 
            // textKeyA
            // 
            this.textKeyA.Location = new System.Drawing.Point(183, 238);
            this.textKeyA.Name = "textKeyA";
            this.textKeyA.Size = new System.Drawing.Size(184, 20);
            this.textKeyA.TabIndex = 5;
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(183, 147);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(184, 20);
            this.textX.TabIndex = 4;
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(183, 59);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(184, 20);
            this.textA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Общий ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число для отправки =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Секретное число А =";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.butGenY);
            this.panel2.Controls.Add(this.butKeyB);
            this.panel2.Controls.Add(this.butGenerateB);
            this.panel2.Controls.Add(this.textKeyB);
            this.panel2.Controls.Add(this.textY);
            this.panel2.Controls.Add(this.textB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(420, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 343);
            this.panel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "АБОНЕНТ 2";
            // 
            // butGenY
            // 
            this.butGenY.BackColor = System.Drawing.SystemColors.MenuText;
            this.butGenY.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGenY.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butGenY.Location = new System.Drawing.Point(183, 173);
            this.butGenY.Name = "butGenY";
            this.butGenY.Size = new System.Drawing.Size(184, 39);
            this.butGenY.TabIndex = 7;
            this.butGenY.Text = "Рассчитать";
            this.butGenY.UseVisualStyleBackColor = false;
            this.butGenY.Click += new System.EventHandler(this.ButGenY_Click);
            // 
            // butKeyB
            // 
            this.butKeyB.BackColor = System.Drawing.SystemColors.MenuText;
            this.butKeyB.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butKeyB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butKeyB.Location = new System.Drawing.Point(77, 278);
            this.butKeyB.Name = "butKeyB";
            this.butKeyB.Size = new System.Drawing.Size(290, 39);
            this.butKeyB.TabIndex = 8;
            this.butKeyB.Text = "Общий секретный ключ";
            this.butKeyB.UseVisualStyleBackColor = false;
            this.butKeyB.Click += new System.EventHandler(this.ButKeyB_Click);
            // 
            // butGenerateB
            // 
            this.butGenerateB.BackColor = System.Drawing.SystemColors.MenuText;
            this.butGenerateB.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGenerateB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butGenerateB.Location = new System.Drawing.Point(183, 85);
            this.butGenerateB.Name = "butGenerateB";
            this.butGenerateB.Size = new System.Drawing.Size(184, 41);
            this.butGenerateB.TabIndex = 6;
            this.butGenerateB.Text = "Сгенерировать";
            this.butGenerateB.UseVisualStyleBackColor = false;
            this.butGenerateB.Click += new System.EventHandler(this.ButGenetateB_Click);
            // 
            // textKeyB
            // 
            this.textKeyB.Location = new System.Drawing.Point(183, 238);
            this.textKeyB.Name = "textKeyB";
            this.textKeyB.Size = new System.Drawing.Size(184, 20);
            this.textKeyB.TabIndex = 5;
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(183, 147);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(184, 20);
            this.textY.TabIndex = 4;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(183, 59);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(184, 20);
            this.textB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Общий ключ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Число для отправки =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Секретное число Б =";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.butG);
            this.panel3.Controls.Add(this.butP);
            this.panel3.Controls.Add(this.textG);
            this.panel3.Controls.Add(this.textP);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 100);
            this.panel3.TabIndex = 11;
            // 
            // butG
            // 
            this.butG.BackColor = System.Drawing.SystemColors.MenuText;
            this.butG.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butG.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butG.Location = new System.Drawing.Point(510, 51);
            this.butG.Name = "butG";
            this.butG.Size = new System.Drawing.Size(146, 38);
            this.butG.TabIndex = 5;
            this.butG.Text = "Случайное число";
            this.butG.UseVisualStyleBackColor = false;
            this.butG.Click += new System.EventHandler(this.ButG_Click);
            // 
            // butP
            // 
            this.butP.BackColor = System.Drawing.SystemColors.MenuText;
            this.butP.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butP.Location = new System.Drawing.Point(510, 7);
            this.butP.Name = "butP";
            this.butP.Size = new System.Drawing.Size(146, 38);
            this.butP.TabIndex = 4;
            this.butP.Text = "Случайное число";
            this.butP.UseVisualStyleBackColor = false;
            this.butP.Click += new System.EventHandler(this.ButP_Click);
            // 
            // textG
            // 
            this.textG.Location = new System.Drawing.Point(331, 61);
            this.textG.Name = "textG";
            this.textG.Size = new System.Drawing.Size(140, 20);
            this.textG.TabIndex = 3;
            // 
            // textP
            // 
            this.textP.Location = new System.Drawing.Point(331, 17);
            this.textP.Name = "textP";
            this.textP.Size = new System.Drawing.Size(140, 20);
            this.textP.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(131, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Общее основание G =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(155, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Простое число P =";
            // 
            // KeyExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "KeyExchangeForm";
            this.ShowIcon = false;
            this.Text = "Ключевой обмен Диффи-Хеллмана";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butKeyA;
        private System.Windows.Forms.Button butGenX;
        private System.Windows.Forms.Button butGenerateA;
        private System.Windows.Forms.TextBox textKeyA;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butGenY;
        private System.Windows.Forms.Button butKeyB;
        private System.Windows.Forms.Button butGenerateB;
        private System.Windows.Forms.TextBox textKeyB;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butG;
        private System.Windows.Forms.Button butP;
        private System.Windows.Forms.TextBox textG;
        private System.Windows.Forms.TextBox textP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}