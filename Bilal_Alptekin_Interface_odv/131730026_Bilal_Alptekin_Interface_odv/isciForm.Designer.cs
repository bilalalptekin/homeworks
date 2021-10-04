namespace _131730026_Bilal_Alptekin_Interface_odv
{
    partial class isciForm
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbxBirim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxProjeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxProjeKatki = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(321, 312);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(229, 82);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbxBirim
            // 
            this.cbxBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbxBirim.FormattingEnabled = true;
            this.cbxBirim.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği",
            "Donanım",
            "İnsan Kaynakları",
            "Muhasebe"});
            this.cbxBirim.Location = new System.Drawing.Point(322, 73);
            this.cbxBirim.Name = "cbxBirim";
            this.cbxBirim.Size = new System.Drawing.Size(229, 37);
            this.cbxBirim.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(192, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Proje Adı:";
            // 
            // tbxProjeAdi
            // 
            this.tbxProjeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxProjeAdi.Location = new System.Drawing.Point(321, 135);
            this.tbxProjeAdi.Name = "tbxProjeAdi";
            this.tbxProjeAdi.Size = new System.Drawing.Size(228, 36);
            this.tbxProjeAdi.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(236, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Birim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(172, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Proje Katkı:";
            // 
            // tbxProjeKatki
            // 
            this.tbxProjeKatki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxProjeKatki.Location = new System.Drawing.Point(322, 192);
            this.tbxProjeKatki.Name = "tbxProjeKatki";
            this.tbxProjeKatki.Size = new System.Drawing.Size(228, 36);
            this.tbxProjeKatki.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(260, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tel:";
            // 
            // tbxTel
            // 
            this.tbxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxTel.Location = new System.Drawing.Point(323, 250);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(228, 36);
            this.tbxTel.TabIndex = 22;
            // 
            // isciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxProjeKatki);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbxBirim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxProjeAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "isciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Id";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbxBirim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxProjeAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxProjeKatki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTel;
    }
}