namespace Bilal_Alptekin_131730026_odev7
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNameSurname = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim Soyisim:";
            // 
            // tbxNameSurname
            // 
            this.tbxNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNameSurname.Location = new System.Drawing.Point(225, 49);
            this.tbxNameSurname.Name = "tbxNameSurname";
            this.tbxNameSurname.Size = new System.Drawing.Size(303, 41);
            this.tbxNameSurname.TabIndex = 1;
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPhoneNumber.Location = new System.Drawing.Point(225, 127);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(303, 41);
            this.tbxPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon :";
            // 
            // tbxAdress
            // 
            this.tbxAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdress.Location = new System.Drawing.Point(225, 208);
            this.tbxAdress.Multiline = true;
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(303, 304);
            this.tbxAdress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(225, 542);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(303, 67);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(540, 621);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNameSurname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNameSurname;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
    }
}

