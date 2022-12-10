using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OgrenciOtomasyon
{
    public partial class KayitAra : Form
    {
        public KayitAra()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(txtAdSoyadAra.Text == "")
            {
                MessageBox.Show("Lütfen isim ve soyisim giriniz", "Kayıt Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KayitArama();
            }
        }
        public void KayitArama()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=OgrenciOtomasyonu.accdb");
            baglanti.Open();

            DataSet ds = new DataSet();
            OleDbDataAdapter adt = new OleDbDataAdapter("SELECT * FROM OgrenciBilgiler WHERE (AdSoyad LIKE '%" + txtAdSoyadAra.Text + "%')", baglanti);

            adt.Fill(ds, "OgrenciBilgiler");
            dgwievAra.DataMember = "OgrenciBilgiler";
            dgwievAra.DataSource = ds;

            adt.Dispose();
            baglanti.Close();
        }
    }
}
