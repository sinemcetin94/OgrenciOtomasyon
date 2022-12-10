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
    public partial class KayitEkle : Form
    {
        public KayitEkle()
        {
            InitializeComponent();
        }

        private void btnkydet_Click(object sender, EventArgs e)
        {
            if (msktxtTcKimlikNo.Text != " ")
            {

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=OgrenciOtomasyonu.accdb");
                baglanti.Open();


                OleDbCommand TckimlikVarMi = new OleDbCommand("SELECT * FROM OgrenciBilgiler WHERE TC_Kimlik_No=" + "'" + msktxtTcKimlikNo.Text + "'", baglanti);
                OleDbDataReader dr = TckimlikVarMi.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Daha önceden kaydedilmiş TC Kimlik numarası girdiniz");
                    txtAdSoyad.Text = " ";
                    msktxtTcKimlikNo.Text = " ";
                }
                else
                {
                    OleDbCommand OgrenciKayitEkle = new OleDbCommand("INSERT INTO OgrenciBilgiler (TC_Kimlik_No,AdSoyad,DogumTarihi,Telefon,Bolum) VALUES (" + msktxtTcKimlikNo.Text + ",'" + txtAdSoyad.Text + "','" + dtpDogumTarihi.Value + "','" + txtTelefon.Text + "','" + cmbbolum.Text + "')", baglanti);
                    OgrenciKayitEkle.ExecuteNonQuery();

                    MessageBox.Show("Kayit işlemi gerçekleştirilmiştir.", "Öğrenci Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OgrenciKayitEkle.Dispose();
                    baglanti.Close();
                }
            }
            else
                MessageBox.Show("Lütfen TC Kimlik numarası giriniz.", "TC kimlik numarası alanı boş!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void KayitEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
