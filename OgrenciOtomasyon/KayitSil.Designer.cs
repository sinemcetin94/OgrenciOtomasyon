namespace OgrenciOtomasyon
{
    partial class KayitSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitSil));
            this.label1 = new System.Windows.Forms.Label();
            this.msktxtTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgviewSil = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewSil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik Numarasını giriniz  :   ";
            // 
            // msktxtTcKimlik
            // 
            this.msktxtTcKimlik.Location = new System.Drawing.Point(72, 105);
            this.msktxtTcKimlik.Mask = "00000000000";
            this.msktxtTcKimlik.Name = "msktxtTcKimlik";
            this.msktxtTcKimlik.Size = new System.Drawing.Size(120, 22);
            this.msktxtTcKimlik.TabIndex = 1;
            this.msktxtTcKimlik.ValidatingType = typeof(int);
            this.msktxtTcKimlik.Leave += new System.EventHandler(this.msktxtTcKimlik_Leave);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(395, 95);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(119, 41);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgviewSil
            // 
            this.dgviewSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewSil.Location = new System.Drawing.Point(52, 180);
            this.dgviewSil.Name = "dgviewSil";
            this.dgviewSil.RowTemplate.Height = 24;
            this.dgviewSil.Size = new System.Drawing.Size(588, 237);
            this.dgviewSil.TabIndex = 3;
            // 
            // KayitSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgviewSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.msktxtTcKimlik);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KayitSil";
            this.Text = "Kayıt Silme";
            ((System.ComponentModel.ISupportInitialize)(this.dgviewSil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktxtTcKimlik;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgviewSil;
    }
}