namespace Composition
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
            this.cbxMarka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMotorGucu = new System.Windows.Forms.ComboBox();
            this.lstboxEklenen = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxBeygir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTork = new System.Windows.Forms.TextBox();
            this.cbxRenk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxKapiSayisi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxMarka
            // 
            this.cbxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbxMarka.FormattingEnabled = true;
            this.cbxMarka.Items.AddRange(new object[] {
            "Volksvagen",
            "Renault",
            "Nissan",
            "Opel",
            "Skoda",
            "Ford",
            "Lamborgini",
            "Tofaş",
            "Anadol"});
            this.cbxMarka.Location = new System.Drawing.Point(184, 50);
            this.cbxMarka.Name = "cbxMarka";
            this.cbxMarka.Size = new System.Drawing.Size(167, 37);
            this.cbxMarka.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(17, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Marka:";
            // 
            // cbxMotorGucu
            // 
            this.cbxMotorGucu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMotorGucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbxMotorGucu.FormattingEnabled = true;
            this.cbxMotorGucu.Items.AddRange(new object[] {
            "1.0",
            "1.3",
            "1.6",
            "1.8",
            "2.0",
            "2.5",
            "3.0",
            "4.5"});
            this.cbxMotorGucu.Location = new System.Drawing.Point(184, 280);
            this.cbxMotorGucu.Name = "cbxMotorGucu";
            this.cbxMotorGucu.Size = new System.Drawing.Size(167, 37);
            this.cbxMotorGucu.TabIndex = 29;
            // 
            // lstboxEklenen
            // 
            this.lstboxEklenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lstboxEklenen.FormattingEnabled = true;
            this.lstboxEklenen.ItemHeight = 29;
            this.lstboxEklenen.Location = new System.Drawing.Point(453, 50);
            this.lstboxEklenen.Name = "lstboxEklenen";
            this.lstboxEklenen.Size = new System.Drawing.Size(320, 468);
            this.lstboxEklenen.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(17, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Beygir:";
            // 
            // tbxBeygir
            // 
            this.tbxBeygir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxBeygir.Location = new System.Drawing.Point(184, 440);
            this.tbxBeygir.Name = "tbxBeygir";
            this.tbxBeygir.Size = new System.Drawing.Size(167, 36);
            this.tbxBeygir.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(17, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tork:";
            // 
            // tbxTork
            // 
            this.tbxTork.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxTork.Location = new System.Drawing.Point(184, 356);
            this.tbxTork.Name = "tbxTork";
            this.tbxTork.Size = new System.Drawing.Size(167, 36);
            this.tbxTork.TabIndex = 24;
            // 
            // cbxRenk
            // 
            this.cbxRenk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbxRenk.FormattingEnabled = true;
            this.cbxRenk.Items.AddRange(new object[] {
            "Beyaz",
            "Siyah",
            "Mavi",
            "Lacivert",
            "Kırmızı",
            "Gri",
            "Sarı"});
            this.cbxRenk.Location = new System.Drawing.Point(184, 200);
            this.cbxRenk.Name = "cbxRenk";
            this.cbxRenk.Size = new System.Drawing.Size(167, 37);
            this.cbxRenk.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(17, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Motor Gücü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(17, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Renk:";
            // 
            // cbxKapiSayisi
            // 
            this.cbxKapiSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKapiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbxKapiSayisi.FormattingEnabled = true;
            this.cbxKapiSayisi.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cbxKapiSayisi.Location = new System.Drawing.Point(184, 119);
            this.cbxKapiSayisi.Name = "cbxKapiSayisi";
            this.cbxKapiSayisi.Size = new System.Drawing.Size(167, 37);
            this.cbxKapiSayisi.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(17, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kapı Sayısı:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEkle.Location = new System.Drawing.Point(184, 516);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(167, 57);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(836, 638);
            this.Controls.Add(this.cbxMarka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxMotorGucu);
            this.Controls.Add(this.lstboxEklenen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxBeygir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxTork);
            this.Controls.Add(this.cbxRenk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxKapiSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMotorGucu;
        private System.Windows.Forms.ListBox lstboxEklenen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxBeygir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTork;
        private System.Windows.Forms.ComboBox cbxRenk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxKapiSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
    }
}

