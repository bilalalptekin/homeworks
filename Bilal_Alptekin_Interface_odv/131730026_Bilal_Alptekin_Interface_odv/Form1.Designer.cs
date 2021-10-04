namespace _131730026_Bilal_Alptekin_Interface_odv
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
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxBolüm = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstboxEklenen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMaas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxAdres
            // 
            this.tbxAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxAdres.Location = new System.Drawing.Point(153, 250);
            this.tbxAdres.Multiline = true;
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(228, 190);
            this.tbxAdres.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(28, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(21, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bölüm:";
            // 
            // cbxBolüm
            // 
            this.cbxBolüm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBolüm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbxBolüm.FormattingEnabled = true;
            this.cbxBolüm.Items.AddRange(new object[] {
            "İşçi",
            "Yönetici"});
            this.cbxBolüm.Location = new System.Drawing.Point(152, 195);
            this.cbxBolüm.Name = "cbxBolüm";
            this.cbxBolüm.Size = new System.Drawing.Size(229, 37);
            this.cbxBolüm.TabIndex = 7;
            this.cbxBolüm.SelectedIndexChanged += new System.EventHandler(this.cbxBolüm_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(152, 473);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(229, 82);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstboxEklenen
            // 
            this.lstboxEklenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstboxEklenen.FormattingEnabled = true;
            this.lstboxEklenen.ItemHeight = 25;
            this.lstboxEklenen.Location = new System.Drawing.Point(554, 72);
            this.lstboxEklenen.Name = "lstboxEklenen";
            this.lstboxEklenen.Size = new System.Drawing.Size(487, 479);
            this.lstboxEklenen.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(63, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // tbxAd
            // 
            this.tbxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxAd.Location = new System.Drawing.Point(153, 72);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(228, 36);
            this.tbxAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(32, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maaş:";
            // 
            // tbxMaas
            // 
            this.tbxMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxMaas.Location = new System.Drawing.Point(153, 134);
            this.tbxMaas.Name = "tbxMaas";
            this.tbxMaas.Size = new System.Drawing.Size(228, 36);
            this.tbxMaas.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1079, 596);
            this.Controls.Add(this.lstboxEklenen);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbxBolüm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMaas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxBolüm;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstboxEklenen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMaas;
    }
}

