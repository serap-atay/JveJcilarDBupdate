
using JveJcilarDBupdate.Data;
using JveJcilarDBupdate.Models;
using JveJcilarDBupdate.Repostory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaVeJavacilar.Forms
{
    public partial class frmKatlar : Form
    {
        public frmKatlar()
        {
            InitializeComponent();
        }

        private KatRepostory katRepostory;
        private MasaRepostory masaRepostory;
        private KafeBilgiRepostory kafeBilgiRepostory;
        private void frmKatlar_Load(object sender, EventArgs e)
        {
            katRepostory = new();
            masaRepostory = new();
            kafeBilgiRepostory = new();
            Temizle();
            ListeyiDoldur();
        }
        private void ListeyiDoldur()
        {
            cmbKafeBilgisi.DataSource = null;
            cmbKafeBilgisi.DataSource = kafeBilgiRepostory.Get().ToList();
            cmbKafeBilgisi.DisplayMember = nameof(KafeBilgi.Ad);
            lstKatlar.DataSource = null;
            lstKatlar.DataSource = katRepostory.Get().ToList();
            lstKatlar.DisplayMember = nameof(Kat.Ad);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(cmbKafeBilgisi.SelectedItem == null)
            {
                MessageBox.Show($"Bir kafe bilgisi seçmelisiniz.");
                return;
            }
            try
            {
                Kat yeniKat = new Kat()
                {
                    Ad = txtKatAdi.Text,
                    Sira = int.Parse(txtSira.Text),
                    Kod = txtKod.Text,
                    KafeBilgiId = (cmbKafeBilgisi.SelectedItem as KafeBilgi).Id
                };
                int adet = int.Parse(txtMasaSayisi.Text);
                katRepostory.Add(yeniKat);
                for (int i = 0; i < adet; i++)
                {
                    Masa yeniMasa = new Masa()
                    {
                        Sira = i + 1,
                        Ad = $"{yeniKat.Kod}/Masa {i + 1}"
                    };
                    //yeniKat.Masalar.Add(yeniMasa);
                    yeniMasa.KatId = yeniKat.Id;
                    masaRepostory.Add(yeniMasa);
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Temizle();
            ListeyiDoldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKat == null) return;
            var silinecekMasalar = masaRepostory.Get(masa => masa.KatId == seciliKat.Id).ToList();
            foreach (var item in silinecekMasalar)
            {
                masaRepostory.Remove(item);
            }
            seciliKat.Ad = txtKatAdi.Text;
            seciliKat.Sira = int.Parse(txtSira.Text);
            seciliKat.Kod = txtKod.Text;
            seciliKat.KafeBilgiId = (cmbKafeBilgisi.SelectedItem as KafeBilgi).Id;
            katRepostory.Update(seciliKat);
            int adet = int.Parse(txtMasaSayisi.Text);
            for (int i = 0; i < adet; i++)
            {
                Masa yeniMasa = new Masa()
                {
                    Sira = i + 1,
                    Ad = $"{seciliKat.Kod}/Masa {i + 1}"
                };
                //seciliKat.Masalar.Add(yeniMasa);
                yeniMasa.KatId = seciliKat.Id;
                masaRepostory.Add(yeniMasa);
            }
            Temizle();
            ListeyiDoldur();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliKat == null) return;
            katRepostory.Remove(seciliKat);
            Temizle();
            ListeyiDoldur();
        }

        private Kat seciliKat;
        private void lstKatlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKatlar.SelectedItem == null) return;
            seciliKat = lstKatlar.SelectedItem as Kat;
            txtKatAdi.Text = seciliKat.Ad;
            txtSira.Text = seciliKat.Sira.ToString();
            txtKod.Text = seciliKat.Kod;
            cmbKafeBilgisi.SelectedItem = kafeBilgiRepostory.GetById(seciliKat.KafeBilgiId.GetValueOrDefault());
            var liste3 = masaRepostory.Get(x => x.KatId == seciliKat.Id).ToList();
            txtMasaSayisi.Text = liste3.Count().ToString();


            //var liste1 = katRepostory
            //    .Get(new[] { "Masalar", "KafeBilgi" }, x => x.Id == seciliKat.Id)
            //    .ToList();

            //var liste2 = katRepostory
            //    .Get(new[] { "Masalar" }, x => x.Id == seciliKat.Id)
            //    .Select(x => x.Masalar)
            //    .ToList();

            //var liste4 = katRepostory
            //    .Get(new[] { "Masalar" }, x => x.Id == seciliKat.Id)
            //    .Select(x => x.Masalar)
            //    .ToList()[0];
            //txtMasaSayisi.Text = liste4.Count().ToString();


        }
        private void Temizle()
        {
            txtKatAdi.Text = "";
            txtKod.Text = "";
            txtSira.Text = "";
            txtMasaSayisi.Text = "";
            cmbKafeBilgisi.SelectedIndex = -1;
            lstKatlar.SelectedIndex = -1;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
