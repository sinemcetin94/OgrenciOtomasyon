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
    public partial class NotGirisi : Form
    {
        public NotGirisi()
        {
            InitializeComponent();
        }

        private void cmbBolumListe_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=OgrenciOtomasyonu.accdb");
            baglanti.Open();

            OleDbCommand query = new OleDbCommand("SELECT TC_Kimlik_No, Bolum FROM OgrenciBilgiler WHERE TC_Kimlik_No NOT IN (SELECT TC_Kimlik_No FROM Notlar) AND Bolum=" + "'" + cmbBolumListe.Text + "'", baglanti);
            OleDbDataReader dr = query.ExecuteReader();

            while (dr.Read())
            {
                cmbTCKimlikNoListe.Items.Add(dr["TC_Kimlik_No"]);
            }

            dr.Close();
            query.Dispose();
            baglanti.Close();
        }

        

        private void cmbTCKimlikNoListe_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=OgrenciOtomasyonu.accdb");
            baglanti.Open();

            OleDbCommand query = new OleDbCommand("SELECT AdSoyad FROM OgrenciBilgiler WHERE TC_Kimlik_No = " + "'"+ cmbTCKimlikNoListe.Text+ "'", baglanti);

            OleDbDataReader dr = query.ExecuteReader();
            if (dr.Read())
            {
                lblAdSoyad.Text = dr["AdSoyad"].ToString();
            }
            query.Dispose();
            baglanti.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=OgrenciOtomasyonu.accdb");


            int VizeNotu, FinalNotu;
            float Ortalama;

            if(msktxtVize.Text==""|| msktxtFinal.Text == "")
            {
                MessageBox.Show("Vize veya final notu alanları boş geçilemez! Lütfen ilgili alanları doldurunuz.");
            }
            else
            {
                VizeNotu = Convert.ToInt32(msktxtVize.Text);
                FinalNotu = Convert.ToInt32(msktxtFinal.Text);

                if(VizeNotu>100 || FinalNotu > 100)
                {
                    MessageBox.Show("Vize veya Final notu 100'den büyük olamaz! Lütfen 0 ile 100 arasında not giriniz.");
                }
                else
                {
                    Ortalama = (VizeNotu * 0.3F) + (FinalNotu * 0.7F);
                    lblOrtalama.Text = Ortalama.ToString();
                    baglanti.Open();

                    OleDbCommand NotKaydet = new OleDbCommand("INSERT INTO Notlar (TC_Kimlik_No, Vize, Final, Ortalama) VALUES('" + cmbTCKimlikNoListe.Text + "','" + msktxtVize.Text + "','" + msktxtFinal.Text + "','" + lblOrtalama.Text + "')", baglanti);
                    NotKaydet.ExecuteNonQuery();

                    MessageBox.Show("Notlar veritabanına aktarılmıştır", "Not Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotKaydet.Dispose();
                    baglanti.Close();

                    cmbTCKimlikNoListe.Items.RemoveAt(cmbTCKimlikNoListe.SelectedIndex);
                    msktxtVize.Text = " ";
                    msktxtFinal.Text = " ";
                    lblOrtalama.Text = " ";
                    lblAdSoyad.Text = " ";
                }
            }
        }
    }
}
