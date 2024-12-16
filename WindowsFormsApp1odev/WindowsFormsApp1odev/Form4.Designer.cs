namespace WindowsFormsApp1odev
{
    partial class Form4
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
            this.dgvListele = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnMuhasebe = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListele
            // 
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.Location = new System.Drawing.Point(10, 11);
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.Size = new System.Drawing.Size(580, 299);
            this.dgvListele.TabIndex = 0;
            this.dgvListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListele_CellContentClick);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(56, 341);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(180, 336);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnMuhasebe
            // 
            this.btnMuhasebe.Location = new System.Drawing.Point(459, 336);
            this.btnMuhasebe.Name = "btnMuhasebe";
            this.btnMuhasebe.Size = new System.Drawing.Size(75, 23);
            this.btnMuhasebe.TabIndex = 6;
            this.btnMuhasebe.Text = "Muhasebe";
            this.btnMuhasebe.UseVisualStyleBackColor = true;
            this.btnMuhasebe.Click += new System.EventHandler(this.btnMuhasebe_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.Location = new System.Drawing.Point(323, 336);
            this.btnRezervasyon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(88, 23);
            this.btnRezervasyon.TabIndex = 7;
            this.btnRezervasyon.Text = "Rezervasyon";
            this.btnRezervasyon.UseVisualStyleBackColor = true;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 420);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.btnMuhasebe);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgvListele);
            this.Name = "Form4";
            this.Text = "Kayıt Görüntüle";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListele;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnMuhasebe;
        private System.Windows.Forms.Button btnRezervasyon;
    }
}