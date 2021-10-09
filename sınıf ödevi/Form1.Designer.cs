namespace sınıf_ödevi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_göster = new System.Windows.Forms.Button();
            this.Sınıfllar = new System.Windows.Forms.ListBox();
            this.txt_katnumarası = new System.Windows.Forms.TextBox();
            this.lbl_katnumarası = new System.Windows.Forms.Label();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.btn_göster);
            this.groupBox1.Controls.Add(this.Sınıfllar);
            this.groupBox1.Controls.Add(this.txt_katnumarası);
            this.groupBox1.Controls.Add(this.lbl_katnumarası);
            this.groupBox1.Controls.Add(this.lbl_bilgi);
            this.groupBox1.Location = new System.Drawing.Point(61, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_göster
            // 
            this.btn_göster.Location = new System.Drawing.Point(56, 118);
            this.btn_göster.Name = "btn_göster";
            this.btn_göster.Size = new System.Drawing.Size(75, 23);
            this.btn_göster.TabIndex = 1;
            this.btn_göster.Text = "Göster";
            this.btn_göster.UseVisualStyleBackColor = true;
            this.btn_göster.Click += new System.EventHandler(this.btn_göster_Click);
            // 
            // Sınıfllar
            // 
            this.Sınıfllar.FormattingEnabled = true;
            this.Sınıfllar.Location = new System.Drawing.Point(6, 147);
            this.Sınıfllar.Name = "Sınıfllar";
            this.Sınıfllar.Size = new System.Drawing.Size(289, 95);
            this.Sınıfllar.TabIndex = 3;
            // 
            // txt_katnumarası
            // 
            this.txt_katnumarası.Location = new System.Drawing.Point(135, 72);
            this.txt_katnumarası.Name = "txt_katnumarası";
            this.txt_katnumarası.Size = new System.Drawing.Size(100, 20);
            this.txt_katnumarası.TabIndex = 2;
            // 
            // lbl_katnumarası
            // 
            this.lbl_katnumarası.AutoSize = true;
            this.lbl_katnumarası.Location = new System.Drawing.Point(53, 79);
            this.lbl_katnumarası.Name = "lbl_katnumarası";
            this.lbl_katnumarası.Size = new System.Drawing.Size(76, 13);
            this.lbl_katnumarası.TabIndex = 1;
            this.lbl_katnumarası.Text = "Kat Numarası :";
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Location = new System.Drawing.Point(87, 16);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(116, 13);
            this.lbl_bilgi.TabIndex = 0;
            this.lbl_bilgi.Text = "Okul Kat Yerleşim Planı";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(160, 118);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 4;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_göster;
        private System.Windows.Forms.ListBox Sınıfllar;
        private System.Windows.Forms.TextBox txt_katnumarası;
        private System.Windows.Forms.Label lbl_katnumarası;
        private System.Windows.Forms.Label lbl_bilgi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_temizle;
    }
}

