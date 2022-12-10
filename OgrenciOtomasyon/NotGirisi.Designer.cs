namespace OgrenciOtomasyon
{
    partial class NotGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotGirisi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBolumListe = new System.Windows.Forms.ComboBox();
            this.cmbTCKimlikNoListe = new System.Windows.Forms.ComboBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.msktxtVize = new System.Windows.Forms.MaskedTextBox();
            this.msktxtFinal = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(88, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vize : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(83, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Final : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(45, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ortalama : ";
            // 
            // cmbBolumListe
            // 
            this.cmbBolumListe.FormattingEnabled = true;
            this.cmbBolumListe.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği",
            "Elektrik-Elektronik Mühendisliği",
            "Kimya Mühendisliği",
            "Makine Mühendisliği",
            "Çevre Mühendisliği",
            "Maden Mühendisliği",
            "Ziraat Mühendisliği",
            "Haberleşme Mühendisliği",
            "İnşaat Mühendisliği",
            "Enerji Mühendisliği",
            "Yazılım Mühendisliği"});
            this.cmbBolumListe.Location = new System.Drawing.Point(173, 49);
            this.cmbBolumListe.Name = "cmbBolumListe";
            this.cmbBolumListe.Size = new System.Drawing.Size(178, 24);
            this.cmbBolumListe.TabIndex = 6;
            this.cmbBolumListe.TextChanged += new System.EventHandler(this.cmbBolumListe_TextChanged);
            // 
            // cmbTCKimlikNoListe
            // 
            this.cmbTCKimlikNoListe.FormattingEnabled = true;
            this.cmbTCKimlikNoListe.Location = new System.Drawing.Point(173, 98);
            this.cmbTCKimlikNoListe.Name = "cmbTCKimlikNoListe";
            this.cmbTCKimlikNoListe.Size = new System.Drawing.Size(121, 24);
            this.cmbTCKimlikNoListe.TabIndex = 7;
            this.cmbTCKimlikNoListe.TextChanged += new System.EventHandler(this.cmbTCKimlikNoListe_TextChanged);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(170, 160);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 17);
            this.lblAdSoyad.TabIndex = 8;
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(180, 306);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(0, 17);
            this.lblOrtalama.TabIndex = 9;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(201, 370);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(150, 42);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // msktxtVize
            // 
            this.msktxtVize.Location = new System.Drawing.Point(173, 205);
            this.msktxtVize.Mask = "000";
            this.msktxtVize.Name = "msktxtVize";
            this.msktxtVize.Size = new System.Drawing.Size(121, 22);
            this.msktxtVize.TabIndex = 11;
            // 
            // msktxtFinal
            // 
            this.msktxtFinal.Location = new System.Drawing.Point(173, 255);
            this.msktxtFinal.Mask = "000";
            this.msktxtFinal.Name = "msktxtFinal";
            this.msktxtFinal.Size = new System.Drawing.Size(121, 22);
            this.msktxtFinal.TabIndex = 12;
            // 
            // NotGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.msktxtFinal);
            this.Controls.Add(this.msktxtVize);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.cmbTCKimlikNoListe);
            this.Controls.Add(this.cmbBolumListe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotGirisi";
            this.Text = "Not Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBolumListe;
        private System.Windows.Forms.ComboBox cmbTCKimlikNoListe;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.MaskedTextBox msktxtVize;
        private System.Windows.Forms.MaskedTextBox msktxtFinal;
    }
}