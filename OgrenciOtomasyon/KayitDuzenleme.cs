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
    public partial class KayitDuzenleme : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=OgrenciOtomasyonu.accdb");
        DataSet dt = new DataSet();

        public KayitDuzenleme()
        {
            InitializeComponent();
        }

        private void KayitDuzenleme_Load(object sender, EventArgs e)
        {
            VerileriListele();

            msktxtTCkimlikNo.DataBindings.Add("Text", dt, "OgrenciBilgiler.TC_Kimlik_No");
            txtAdSoyad.DataBindings.Add("Text", dt, "OgrenciBilgiler.AdSoyad");
            msktxtTelefon.DataBindings.Add("Text", dt, "OgrenciBilgiler.Telefon");
            cmbBolum.DataBindings.Add("Text", dt, "OgrenciBilgiler.Bolum");

        }
        


        public void VerileriListele()
        {
            baglanti.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("SELECT * FROM OgrenciBilgiler", baglanti);
            adt.Fill(dt, "OgrenciBilgiler");

            dgvKayitlar.DataMember = "OgrenciBilgiler";
            dgvKayitlar.DataSource = dt;

            adt.Dispose();
            baglanti.Close();
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            OleDbCommand cmd = new OleDbCommand("UPDATE OgrenciBilgiler SET AdSoyad='" + txtAdSoyad.Text + "', Telefon='" + msktxtTelefon.Text + "' , Bolum='" + cmbBolum.Text + "' WHERE TC_Kimlik_No='" + msktxtTCkimlikNo.Text + "'", baglanti);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Veri Güncelleme işlemi bitmiştir", "Veri Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Dispose();
            baglanti.Close();
            dt.Clear();
            VerileriListele();

        }
    }
}
