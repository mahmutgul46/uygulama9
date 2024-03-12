namespace uygulama9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatirSayisi = new System.Windows.Forms.TextBox();
            this.txtSutunSayisi = new System.Windows.Forms.TextBox();
            this.txtRastgeleMin = new System.Windows.Forms.TextBox();
            this.txtRastgeleMax = new System.Windows.Forms.TextBox();
            this.btnDiziOlustur = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.listeDizi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dizi Satır Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dizi Sütun Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rastgele En Düşük Sayı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rastgele En Yüksek Sayı";
            // 
            // txtSatirSayisi
            // 
            this.txtSatirSayisi.Location = new System.Drawing.Point(173, 32);
            this.txtSatirSayisi.Name = "txtSatirSayisi";
            this.txtSatirSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSatirSayisi.TabIndex = 4;
            // 
            // txtSutunSayisi
            // 
            this.txtSutunSayisi.Location = new System.Drawing.Point(173, 84);
            this.txtSutunSayisi.Name = "txtSutunSayisi";
            this.txtSutunSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSutunSayisi.TabIndex = 5;
            // 
            // txtRastgeleMin
            // 
            this.txtRastgeleMin.Location = new System.Drawing.Point(173, 135);
            this.txtRastgeleMin.Name = "txtRastgeleMin";
            this.txtRastgeleMin.Size = new System.Drawing.Size(100, 20);
            this.txtRastgeleMin.TabIndex = 6;
            // 
            // txtRastgeleMax
            // 
            this.txtRastgeleMax.Location = new System.Drawing.Point(173, 186);
            this.txtRastgeleMax.Name = "txtRastgeleMax";
            this.txtRastgeleMax.Size = new System.Drawing.Size(100, 20);
            this.txtRastgeleMax.TabIndex = 7;
            // 
            // btnDiziOlustur
            // 
            this.btnDiziOlustur.Location = new System.Drawing.Point(186, 238);
            this.btnDiziOlustur.Name = "btnDiziOlustur";
            this.btnDiziOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnDiziOlustur.TabIndex = 8;
            this.btnDiziOlustur.Text = "Dizi Oluştur";
            this.btnDiziOlustur.UseVisualStyleBackColor = true;
            this.btnDiziOlustur.Click += new System.EventHandler(this.btnDiziOlustur_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(359, 14);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Dizi Göster";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // listeDizi
            // 
            this.listeDizi.FormattingEnabled = true;
            this.listeDizi.Location = new System.Drawing.Point(320, 62);
            this.listeDizi.Name = "listeDizi";
            this.listeDizi.Size = new System.Drawing.Size(157, 199);
            this.listeDizi.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 301);
            this.Controls.Add(this.listeDizi);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnDiziOlustur);
            this.Controls.Add(this.txtRastgeleMax);
            this.Controls.Add(this.txtRastgeleMin);
            this.Controls.Add(this.txtSutunSayisi);
            this.Controls.Add(this.txtSatirSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "İki Boyutlu Diziler ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSatirSayisi;
        private System.Windows.Forms.TextBox txtSutunSayisi;
        private System.Windows.Forms.TextBox txtRastgeleMin;
        private System.Windows.Forms.TextBox txtRastgeleMax;
        private System.Windows.Forms.Button btnDiziOlustur;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox listeDizi;
    }
}

