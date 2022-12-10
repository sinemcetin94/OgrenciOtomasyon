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
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            KayitEkle yeniform = new KayitEkle();
            yeniform.Show();
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            NotGirisi NotGirisiForm = new NotGirisi();
            NotGirisiForm.ShowDialog();
        }

        private void btnKayitListele_Click(object sender, EventArgs e)
        {
            KayitlariListele frm = new KayitlariListele();
            frm.Show();
        
        }

        private void btnKayitDuzenle_Click(object sender, EventArgs e)
        {
            KayitDuzenleme frm = new KayitDuzenleme();
            frm.Show();

        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            KayitAra frm = new KayitAra();
            frm.Show();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            KayitSil frm = new KayitSil();
            frm.Show();
        }

        private void AnaSayfaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("İyi Günler..");
        }
    }
}
