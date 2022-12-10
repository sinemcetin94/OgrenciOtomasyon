namespace OgrenciOtomasyon
{
    partial class KayitDuzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitDuzenleme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msktxtTCkimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.msktxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.dgvKayitlar = new System.Windows.Forms.DataGridView();
            this.btnduzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(322, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı  : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(619, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(878, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölüm : ";
            // 
            // msktxtTCkimlikNo
            // 
            this.msktxtTCkimlikNo.Location = new System.Drawing.Point(156, 32);
            this.msktxtTCkimlikNo.Mask = "00000000000";
            this.msktxtTCkimlikNo.Name = "msktxtTCkimlikNo";
            this.msktxtTCkimlikNo.Size = new System.Drawing.Size(131, 22);
            this.msktxtTCkimlikNo.TabIndex = 4;
            this.msktxtTCkimlikNo.ValidatingType = typeof(int);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(455, 31);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(131, 22);
            this.txtAdSoyad.TabIndex = 5;
            // 
            // msktxtTelefon
            // 
            this.msktxtTelefon.Location = new System.Drawing.Point(711, 30);
            this.msktxtTelefon.Mask = "(999) 000-0000";
            this.msktxtTelefon.Name = "msktxtTelefon";
            this.msktxtTelefon.Size = new System.Drawing.Size(131, 22);
            this.msktxtTelefon.TabIndex = 6;
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(976, 27);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(131, 24);
            this.cmbBolum.TabIndex = 7;
            // 
            // dgvKayitlar
            // 
            this.dgvKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKayitlar.Location = new System.Drawing.Point(12, 224);
            this.dgvKayitlar.Name = "dgvKayitlar";
            this.dgvKayitlar.RowTemplate.Height = 24;
            this.dgvKayitlar.Size = new System.Drawing.Size(1086, 394);
            this.dgvKayitlar.TabIndex = 8;
            // 
            // btnduzenle
            // 
            this.btnduzenle.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnduzenle.Location = new System.Drawing.Point(443, 124);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(221, 48);
            this.btnduzenle.TabIndex = 9;
            this.btnduzenle.Text = "DÜZENLE";
            this.btnduzenle.UseVisualStyleBackColor = true;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // KayitDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1129, 679);
            this.Controls.Add(this.btnduzenle);
            this.Controls.Add(this.dgvKayitlar);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.msktxtTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.msktxtTCkimlikNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KayitDuzenleme";
            this.Text = "Kayıt Düzenleme";
            this.Load += new System.EventHandler(this.KayitDuzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayitlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktxtTCkimlikNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.MaskedTextBox msktxtTelefon;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.DataGridView dgvKayitlar;
        private System.Windows.Forms.Button btnduzenle;
    }
}