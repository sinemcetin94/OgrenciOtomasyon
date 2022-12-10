namespace OgrenciOtomasyon
{
    partial class AnaSayfaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKayitListele = new System.Windows.Forms.Button();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.btnKayitAra = new System.Windows.Forms.Button();
            this.btnKayitDuzenle = new System.Windows.Forms.Button();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ KAYIT OTOMASYONU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kayıt Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(646, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kayıt Düzenle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(413, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kayıt Ara";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(678, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kayıt Sil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(416, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Not Ekle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(141, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kayıt Listele";
            // 
            // btnKayitListele
            // 
            this.btnKayitListele.BackgroundImage = global::OgrenciOtomasyon.Properties.Resources.Actions_view_list_details_icon;
            this.btnKayitListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKayitListele.Location = new System.Drawing.Point(115, 361);
            this.btnKayitListele.Name = "btnKayitListele";
            this.btnKayitListele.Size = new System.Drawing.Size(152, 171);
            this.btnKayitListele.TabIndex = 10;
            this.btnKayitListele.UseVisualStyleBackColor = true;
            this.btnKayitListele.Click += new System.EventHandler(this.btnKayitListele_Click);
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.BackgroundImage = global::OgrenciOtomasyon.Properties.Resources.Files_Add_List_icon;
            this.btnNotEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNotEkle.Location = new System.Drawing.Point(382, 79);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(152, 171);
            this.btnNotEkle.TabIndex = 9;
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Image = global::OgrenciOtomasyon.Properties.Resources.delete_file_icon;
            this.btnKayitSil.Location = new System.Drawing.Point(641, 349);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(152, 171);
            this.btnKayitSil.TabIndex = 8;
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // btnKayitAra
            // 
            this.btnKayitAra.Image = global::OgrenciOtomasyon.Properties.Resources.search_icon;
            this.btnKayitAra.Location = new System.Drawing.Point(382, 349);
            this.btnKayitAra.Name = "btnKayitAra";
            this.btnKayitAra.Size = new System.Drawing.Size(152, 171);
            this.btnKayitAra.TabIndex = 7;
            this.btnKayitAra.UseVisualStyleBackColor = true;
            this.btnKayitAra.Click += new System.EventHandler(this.btnKayitAra_Click);
            // 
            // btnKayitDuzenle
            // 
            this.btnKayitDuzenle.Image = global::OgrenciOtomasyon.Properties.Resources.edit_file_icon;
            this.btnKayitDuzenle.Location = new System.Drawing.Point(641, 79);
            this.btnKayitDuzenle.Name = "btnKayitDuzenle";
            this.btnKayitDuzenle.Size = new System.Drawing.Size(152, 171);
            this.btnKayitDuzenle.TabIndex = 4;
            this.btnKayitDuzenle.UseVisualStyleBackColor = true;
            this.btnKayitDuzenle.Click += new System.EventHandler(this.btnKayitDuzenle_Click);
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Image = global::OgrenciOtomasyon.Properties.Resources.Actions_user_group_new_icon;
            this.btnKayitEkle.Location = new System.Drawing.Point(115, 79);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(152, 171);
            this.btnKayitEkle.TabIndex = 3;
            this.btnKayitEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKayitEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // AnaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(940, 659);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKayitListele);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.btnKayitAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKayitDuzenle);
            this.Controls.Add(this.btnKayitEkle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaSayfaForm";
            this.Text = "ÖĞRENCİ KAYIT SİSTEMİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaSayfaForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.Button btnKayitDuzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKayitAra;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.Button btnKayitListele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

