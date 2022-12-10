namespace OgrenciOtomasyon
{
    partial class KayitAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitAra));
            this.txtAdSoyadAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.dgwievAra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwievAra)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdSoyadAra
            // 
            this.txtAdSoyadAra.Location = new System.Drawing.Point(55, 108);
            this.txtAdSoyadAra.Name = "txtAdSoyadAra";
            this.txtAdSoyadAra.Size = new System.Drawing.Size(311, 22);
            this.txtAdSoyadAra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aramak istediğiniz öğrenci adı ve soyadını giriniz : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(486, 90);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(162, 40);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dgwievAra
            // 
            this.dgwievAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwievAra.Location = new System.Drawing.Point(55, 176);
            this.dgwievAra.Name = "dgwievAra";
            this.dgwievAra.RowTemplate.Height = 24;
            this.dgwievAra.Size = new System.Drawing.Size(633, 253);
            this.dgwievAra.TabIndex = 3;
            // 
            // KayitAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 520);
            this.Controls.Add(this.dgwievAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdSoyadAra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KayitAra";
            this.Text = "KAYIT ARAMA";
            ((System.ComponentModel.ISupportInitialize)(this.dgwievAra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyadAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgwievAra;
    }
}