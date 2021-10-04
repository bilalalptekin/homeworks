namespace _131730026_Bilal_Alptekin
{
    partial class Form1
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
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbxSayı1 = new System.Windows.Forms.TextBox();
            this.tbxSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(31, 109);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(92, 44);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikart
            // 
            this.btnCikart.Location = new System.Drawing.Point(31, 159);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(92, 44);
            this.btnCikart.TabIndex = 1;
            this.btnCikart.Text = "Çıkar";
            this.btnCikart.UseVisualStyleBackColor = true;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(31, 209);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(92, 44);
            this.btnCarp.TabIndex = 2;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(31, 259);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(92, 44);
            this.btnBol.TabIndex = 3;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(326, 350);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(52, 17);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Topla",
            "Çıkar",
            "Çarp",
            "Böl"});
            this.comboBox1.Location = new System.Drawing.Point(561, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // tbxSayı1
            // 
            this.tbxSayı1.Location = new System.Drawing.Point(276, 138);
            this.tbxSayı1.Name = "tbxSayı1";
            this.tbxSayı1.Size = new System.Drawing.Size(157, 22);
            this.tbxSayı1.TabIndex = 6;
            // 
            // tbxSayi2
            // 
            this.tbxSayi2.Location = new System.Drawing.Point(276, 188);
            this.tbxSayi2.Name = "tbxSayi2";
            this.tbxSayi2.Size = new System.Drawing.Size(157, 22);
            this.tbxSayi2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sayı 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sayı 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSayi2);
            this.Controls.Add(this.tbxSayı1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnCikart);
            this.Controls.Add(this.btnTopla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbxSayı1;
        private System.Windows.Forms.TextBox tbxSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

