using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using JveJcilarDBupdate.Models;
using JveJcilarDBupdate.Repostory;
using System.Linq;

namespace KafeAdisyon.Forms
{
    public partial class frmSiparis : Form
    {
        public frmSiparis(KafeGorunumForm kafeGorunumForm)
        {
            InitializeComponent();
            this.kafeGorunumForm = kafeGorunumForm;
        }
        public KafeGorunumForm kafeGorunumForm;
        public Masa SeciliMasa { get; set; }
        public List<Siparis> MasaninSiparisleri { get; set; }
        private KategoriRepostory _kategoriRepostory;
        private SiparisRepostory _siparisRepostory;
        private UrunRepostory _urunRepostory;
        private MasaRepostory _masaRepostory;

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            _masaRepostory = new MasaRepostory();
            _kategoriRepostory = new KategoriRepostory();
            _siparisRepostory = new SiparisRepostory();
            _urunRepostory = new UrunRepostory();
            List<Kategori> kategoriler = _kategoriRepostory.Get().ToList();
            flpKategori.Controls.Clear();
            foreach (Kategori kategori in kategoriler)
            {
                Button btn = new Button()
                {
                    Text = kategori.Ad,
                    Size = new Size(220, 150),                   
                    BackgroundImageLayout = ImageLayout.Stretch,
                    ForeColor = Color.White,
                    Font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular),
                    Tag = kategori
                };
                if (kategori.Fotograf != null) 
                { 
                    btn.BackgroundImage = Image.FromStream(new MemoryStream(kategori.Fotograf)); 
                }              
                btn.Click += KategoriBtn_Click; 
                flpKategori.Controls.Add(btn);
            }
            lstSiparis.FullRowSelect = true;
            ListeyiDoldur();
        }
        private Kategori _seciliKategori;
        private void KategoriBtn_Click(object sender, EventArgs e)
        {
            Button seciliButton = sender as Button;
            _seciliKategori = seciliButton.Tag as Kategori;
            //List<Urun> urunler = _seciliKategori.Urunler.ToList();
            List<Urun> urunler = _urunRepostory.Get(urun => urun.KategoriId == _seciliKategori.Id).ToList();
            flpUrun.Controls.Clear();
            foreach (Urun urun in urunler)
            {
                Button btn = new Button()
                {
                    Text = urun.Ad,
                    Size = new Size(220, 150),
                    BackgroundImage = Image.FromStream(new MemoryStream(urun.Fotograf)),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    ForeColor = Color.White,
                    Font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular),
                    Tag = urun
                };
                if (urun.Fotograf != null)
                {
                    btn.BackgroundImage = Image.FromStream(new MemoryStream(urun.Fotograf));
                }
                btn.Click += BtnUrun_Click; ;
                flpUrun.Controls.Add(btn);
            }
        }
        public Urun _seciliUrun;
        private void BtnUrun_Click(object sender, EventArgs e)
        {
            Button seciliButton = (Button)sender;
            _seciliUrun = seciliButton.Tag as Urun;
            //her seferinde veritabanında güncelleme yapmamalı
            SeciliMasa.MasaDurumu = true;
            _masaRepostory.Update(SeciliMasa);
            bool varMi = false;
            Siparis seciliSiparis = new Siparis();
            foreach (Siparis item in MasaninSiparisleri)
            {
                Siparis siparis = _siparisRepostory.Get(new [] { "Urun" }, a => a.UrunId == item.Urun.Id).First();
                if (siparis.Urun.Id == _seciliUrun.Id)
                {
                    seciliSiparis = siparis;
                    varMi = true;
                    break;
                }
            }
            if (varMi)
            {
                seciliSiparis.Adet++;
                _siparisRepostory.Update(seciliSiparis);
            }
            else
            {
                Siparis yeniSiparis = new Siparis()
                {
                    Adet = 1,
                    UrunId = _seciliUrun.Id,
                    Fiyat = _seciliUrun.Fiyat,
                    MasaId = SeciliMasa.Id
                };
                _siparisRepostory.Add(yeniSiparis);
            }           
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            this.MasaninSiparisleri = _siparisRepostory
                .Get(new[] { "Masa" }, x => x.Masa.Id == this.SeciliMasa.Id && x.Masa.MasaDurumu == true)
                .ToList();
            lstSiparis.Columns.Clear();
            lstSiparis.Items.Clear();
            lstSiparis.View = View.Details;
            lstSiparis.Columns.Add("Adet");
            lstSiparis.Columns.Add("Ürün");
            lstSiparis.Columns.Add("Ara Toplam");
            foreach (Siparis item in MasaninSiparisleri)
            {
                //------>
                var siparis = _siparisRepostory.Get(new[] { "Urun" }, x => x.Urun.Id == item.UrunId && x.Masa.Id == item.MasaId).First();
                ListViewItem viewItem = new ListViewItem(siparis.Adet.ToString());
                viewItem.SubItems.Add(siparis.Urun.Ad);
                viewItem.SubItems.Add($"{siparis.AraToplam:c2}");
                lstSiparis.Items.Add(viewItem);
            }

            lstSiparis.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            decimal toplam = 0;
            foreach (Siparis item in MasaninSiparisleri)
            {
                toplam += item.AraToplam;
            }
            lblToplam.Text = $"{toplam:c2}";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
            this.SeciliMasa.MasaDurumu = false;
            _masaRepostory.Update(this.SeciliMasa);
        }


    }
}
