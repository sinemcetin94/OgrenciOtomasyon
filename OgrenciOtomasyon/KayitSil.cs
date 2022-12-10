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
    public partial class KayitSil : Form
    {
        public KayitSil()
        {
            InitializeComponent();
        }

        private void msktxtTcKimlik_Leave(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=OgrenciOtomasyonu.accdb");
            baglanti.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adt = new OleDbDataAdapter("SELECT * FROM OgrenciBilgiler WHERE TC_Kimlik_No= '" + msktxtTcKimlik.Text + "'", baglanti);
            adt.Fill(ds, "OgrenciBilgiler");

            dgviewSil.DataMember = "OgrenciBilgiler";
            dgviewSil.DataSource = ds;

            adt.Dispose();
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("İlgili kaydı silmek istediğinizden emin misiniz? Silme işlemi sonunda öğrenci bilgileri tamamen silinecektir.", "Kayıt Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=OgrenciOtomasyonu.accdb");
                baglanti.Open();

                DataSet ds = new DataSet();
                OleDbCommand KayitSil = new OleDbCommand("DELETE OgrenciBilgiler.*, Notlar.* FROM OgrenciBilgiler INNER JOIN Notlar ON OgrenciBilgiler.TC_Kimlik_No=Notlar.TC_Kimlik_No WHERE OgrenciBilgiler.TC_Kimlik_No=" + "'" + msktxtTcKimlik.Text + "'", baglanti);

                KayitSil.ExecuteNonQuery();
                ds.Clear();

                OleDbDataAdapter adt = new OleDbDataAdapter("SELECT * FROM OgrenciBilgiler", baglanti);
                adt.Fill(ds, "OgrenciBilgiler");

                dgviewSil.DataMember = "OgrenciBilgiler";
                dgviewSil.DataSource = ds;

                MessageBox.Show("Kayıt silme işlemi başarı ile gerçekleştirilmiştir.");
                KayitSil.Dispose();

                adt.Dispose();
                baglanti.Close();
            }
        }
    }
}
