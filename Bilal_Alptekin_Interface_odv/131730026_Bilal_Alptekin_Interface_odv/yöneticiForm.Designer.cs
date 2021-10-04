namespace _131730026_Bilal_Alptekin_Interface_odv
{
    partial class yöneticiForm
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
            this.tbxİstedigiMaas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxYönBolüm = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxİstedigiMaas
            // 
            this.tbxİstedigiMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbxİstedigiMaas.Location = new System.Drawing.Point(322, 190);
            this.tbxİstedigiMaas.Name = "tbxİstedigiMaas";
            this.tbxİstedigiMaas.Size = new System.Drawing.Size(228, 36);
            this.tbxİstedigiMaas.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(118, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yönettiği Bölüm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(68, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "İstediği Ekstra Maaş:";
            // 
            // cbxYönBolüm
            // 
            this.cbxYönBolüm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYönBolüm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbxYönBolüm.FormattingEnabled = true;
            this.cbxYönBolüm.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği",
            "Donanım",
            "İnsan Kaynakları",
            "Muhasebe"});
            this.cbxYönBolüm.Location = new System.Drawing.Point(322, 128);
            this.cbxYönBolüm.Name = "cbxYönBolüm";
            this.cbxYönBolüm.Size = new System.Drawing.Size(229, 37);
            this.cbxYönBolüm.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(322, 278);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(229, 82);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // yöneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbxYönBolüm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxİstedigiMaas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "yöneticiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yöneticiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxİstedigiMaas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxYönBolüm;
        private System.Windows.Forms.Button btnEkle;
    }
}