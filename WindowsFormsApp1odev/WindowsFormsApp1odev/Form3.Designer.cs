namespace WindowsFormsApp1odev
{
    partial class Form3
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
            this.lbGun = new System.Windows.Forms.Label();
            this.lbSaat = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbTutar = new System.Windows.Forms.Label();
            this.lbTutarGoster = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Park Süresi";
            // 
            // lbGun
            // 
            this.lbGun.AutoSize = true;
            this.lbGun.Location = new System.Drawing.Point(32, 85);
            this.lbGun.Name = "lbGun";
            this.lbGun.Size = new System.Drawing.Size(40, 13);
            this.lbGun.TabIndex = 1;
            this.lbGun.Text = "Plaka :";
            this.lbGun.Click += new System.EventHandler(this.lbGun_Click);
            // 
            // lbSaat
            // 
            this.lbSaat.AutoSize = true;
            this.lbSaat.Location = new System.Drawing.Point(32, 123);
            this.lbSaat.Name = "lbSaat";
            this.lbSaat.Size = new System.Drawing.Size(68, 13);
            this.lbSaat.TabIndex = 1;
            this.lbSaat.Text = "Kaldığı Tarife";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(26, 161);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(106, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // lbTutar
            // 
            this.lbTutar.AutoSize = true;
            this.lbTutar.Location = new System.Drawing.Point(144, 161);
            this.lbTutar.Name = "lbTutar";
            this.lbTutar.Size = new System.Drawing.Size(38, 13);
            this.lbTutar.TabIndex = 4;
            this.lbTutar.Text = "Tutar :";
            // 
            // lbTutarGoster
            // 
            this.lbTutarGoster.AutoSize = true;
            this.lbTutarGoster.Location = new System.Drawing.Point(80, 186);
            this.lbTutarGoster.Name = "lbTutarGoster";
            this.lbTutarGoster.Size = new System.Drawing.Size(0, 13);
            this.lbTutarGoster.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 161);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 322);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTutarGoster);
            this.Controls.Add(this.lbTutar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lbSaat);
            this.Controls.Add(this.lbGun);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Ücret Hesaplama";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGun;
        private System.Windows.Forms.Label lbSaat;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbTutar;
        private System.Windows.Forms.Label lbTutarGoster;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}