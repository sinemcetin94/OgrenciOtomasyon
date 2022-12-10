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
    public partial class KayitlariListele : Form
    {
        public KayitlariListele()
        {
            InitializeComponent();
        }

        private void KayitlariListele_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=OgrenciOtomasyonu.accdb");

            DataSet dt = new DataSet();

            baglanti.Open();

            OleDbDataAdapter adt = new OleDbDataAdapter("SELECT OgrenciBilgiler.TC_Kimlik_No, OgrenciBilgiler.AdSoyad, Notlar.Vize, Notlar.Final, Notlar.Ortalama FROM OgrenciBilgiler, Notlar WHERE OgrenciBilgiler.TC_Kimlik_No= Notlar.TC_Kimlik_No", baglanti);

            adt.Fill(dt, "OgrenciBilgiler");

            dataGridView1.DataMember = "OgrenciBilgiler";

            dataGridView1.DataSource = dt;

            adt.Dispose();
            baglanti.Close();
        }
    }
}
