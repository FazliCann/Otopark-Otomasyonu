namespace WindowsFormsApp1odev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbKulAd = new System.Windows.Forms.Label();
            this.lbParola = new System.Windows.Forms.Label();
            this.txtKulAd = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKulAd
            // 
            this.lbKulAd.AutoSize = true;
            this.lbKulAd.Location = new System.Drawing.Point(303, 83);
            this.lbKulAd.Name = "lbKulAd";
            this.lbKulAd.Size = new System.Drawing.Size(70, 13);
            this.lbKulAd.TabIndex = 0;
            this.lbKulAd.Text = "Kullanıcı Adı :";
            // 
            // lbParola
            // 
            this.lbParola.AutoSize = true;
            this.lbParola.Location = new System.Drawing.Point(303, 119);
            this.lbParola.Name = "lbParola";
            this.lbParola.Size = new System.Drawing.Size(70, 13);
            this.lbParola.TabIndex = 1;
            this.lbParola.Text = "Parola          :";
            // 
            // txtKulAd
            // 
            this.txtKulAd.Location = new System.Drawing.Point(379, 83);
            this.txtKulAd.Name = "txtKulAd";
            this.txtKulAd.Size = new System.Drawing.Size(127, 20);
            this.txtKulAd.TabIndex = 2;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(379, 119);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(127, 20);
            this.txtParola.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(400, 145);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 217);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(573, 289);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKulAd);
            this.Controls.Add(this.lbParola);
            this.Controls.Add(this.lbKulAd);
            this.Name = "Form1";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKulAd;
        private System.Windows.Forms.Label lbParola;
        private System.Windows.Forms.TextBox txtKulAd;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

