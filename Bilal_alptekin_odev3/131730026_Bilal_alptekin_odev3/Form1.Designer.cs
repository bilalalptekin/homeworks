namespace _131730026_Bilal_alptekin_odev3
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listViewTek = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewCift = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Değeri :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Değeri :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // listViewTek
            // 
            this.listViewTek.HideSelection = false;
            this.listViewTek.Location = new System.Drawing.Point(365, 46);
            this.listViewTek.Name = "listViewTek";
            this.listViewTek.Size = new System.Drawing.Size(217, 367);
            this.listViewTek.TabIndex = 4;
            this.listViewTek.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewCift
            // 
            this.listViewCift.HideSelection = false;
            this.listViewCift.Location = new System.Drawing.Point(599, 46);
            this.listViewCift.Name = "listViewCift";
            this.listViewCift.Size = new System.Drawing.Size(217, 367);
            this.listViewCift.TabIndex = 6;
            this.listViewCift.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(404, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tek Değerler ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(650, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Çift Değerler ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Çarpım Tablosu Formu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewCift);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewTek);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listViewTek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewCift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

