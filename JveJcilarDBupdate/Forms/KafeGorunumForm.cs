using JveJcilarDBupdate.Models;
using JveJcilarDBupdate.Repostory;
//using KafeAdisyon.Business;
//using KafeAdisyon.Data;
//using KafeAdisyon.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KafeAdisyon.Forms
{
    public partial class KafeGorunumForm : Form
    {
        public KafeGorunumForm()
        {
            InitializeComponent();
        }
        private MasaRepostory _masaRepostory;
        private KatRepostory _katRepostory;
        private SiparisRepostory _siparisRepository;
        private RaporRepostory _raporRepostory;
        Color seciliKatColor = Color.Coral, defaultKatColor = Color.CornflowerBlue;
        private void KafeGorunumForm_Load(object sender, EventArgs e)
        {
            _katRepostory = new KatRepostory();
            _siparisRepository = new SiparisRepostory();
            _masaRepostory = new MasaRepostory();
            _raporRepostory = new RaporRepostory();
            List<Kat> katlar = _katRepostory
                .Get()
                .OrderBy(x => x.Sira)
                .ToList();
            for (int i = 0; i < katlar.Count; i++)
            {
                Kat kat = katlar[i];
                Button btn = new Button()
                {
                    Text = kat.Ad,
                    Size = new Size(140, 95),
                    BackColor = defaultKatColor,
                    Tag = kat
                };
                btn.Click += KatBtn_Click;
                flpKatlar.Controls.Add(btn);
            }
        }

        private Kat _seciliKat;
        private void KatBtn_Click(object sender, EventArgs e)
        {
            Button seciliButton = sender as Button;

            _seciliKat = seciliButton.Tag as Kat;
            List<Masa> masalar = _masaRepostory.Get(masa => masa.KatId == _seciliKat.Id).ToList();
            //List<Masa> masalar = _seciliKat.Masalar.ToList();
            flpMasalar.Controls.Clear();
            foreach (Masa masa in masalar)
            {
                Button btn = new Button()
                {
                    Text = masa.Ad,
                    Size = new Size(140, 95),
                    BackColor = defaultKatColor,
                    Tag = masa
                };
                btn.Click += BtnMasa_Click;
                flpMasalar.Controls.Add(btn);
            }

            foreach (Button button in flpKatlar.Controls)
            {
                button.BackColor = defaultKatColor;
                if (button.Text == seciliButton.Text)
                    button.BackColor = seciliKatColor;
            }
            MasaRenklendir();
        }
        private void MasaRenklendir()
        {
            var mevcutSiparisler = _siparisRepository.Get(new[] { "Masa" }, x => x.Masa.MasaDurumu == true);
            foreach (Button button in flpMasalar.Controls)
            {
                button.BackColor = defaultKatColor;
                if (mevcutSiparisler.Any(x => x.Masa.Ad.Equals(button.Text)))
                {
                    button.BackColor = seciliKatColor;
                }
            }
        }
        private frmSiparis _frmSiparis;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font Font = new Font("Calibri", 20);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawLine(myPen, 120, 120, 750, 120);
            e.Graphics.DrawLine(myPen, 120, 160, 750, 160);
            e.Graphics.DrawString(DateTime.Now.ToString("MM/dd/yyyy HH:mm") + " tarihli " + _frmSiparis.SeciliMasa.Ad + " Adisyonu", Font, sbrush, 140, 120);

            e.Graphics.DrawLine(myPen, 120, 320, 750, 320);

            Font = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString("Adet", Font, sbrush, 140, 324);
            e.Graphics.DrawString("Ürün Adı", Font, sbrush, 240, 324);
            e.Graphics.DrawString("Birim Fiyatı", Font, sbrush, 440, 324);
            e.Graphics.DrawString("Fiyat", Font, sbrush, 640, 324);

            e.Graphics.DrawLine(myPen, 120, 348, 750, 348);

            int y = 360;

            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;

            decimal gTotal = 0;

            foreach (var item in silinecekSiparisler)
            {
                e.Graphics.DrawString(item.Adet.ToString(), Font, sbrush, 170, y, myStringFormat);
                e.Graphics.DrawString(item.Urun.Ad, Font, sbrush, 240, y);
                decimal bFiyat = item.Fiyat;
                decimal fiyat = item.AraToplam;
                gTotal += fiyat;
                e.Graphics.DrawString(bFiyat.ToString("c"), Font, sbrush, 490, y, myStringFormat);
                e.Graphics.DrawString(fiyat.ToString("c"), Font, sbrush, 690, y, myStringFormat);

                y += 20;

            }

            e.Graphics.DrawLine(myPen, 120, y, 750, y);
            e.Graphics.DrawString(gTotal.ToString("c"), Font, sbrush, 690, y + 10, myStringFormat);
        }
        List<Siparis> silinecekSiparisler;
        private void BtnMasa_Click(object sender, EventArgs e)
        {            
            Button seciliButton = sender as Button;
            if (_frmSiparis == null || _frmSiparis.IsDisposed)
            {
                _frmSiparis = new frmSiparis(this);
            }
            //_frmSiparis.MdiParent = this.MdiParent;
            _frmSiparis.MasaninSiparisleri = new();
            _frmSiparis.WindowState = FormWindowState.Maximized;
            _frmSiparis.SeciliMasa = seciliButton.Tag as Masa;
            _frmSiparis.MasaninSiparisleri = _siparisRepository
                .Get(new[] { "Masa" }, x => x.Masa.Id == _frmSiparis.SeciliMasa.Id && x.Masa.MasaDurumu == true)
                .ToList();
            DialogResult result = _frmSiparis.ShowDialog();
            if (result == DialogResult.OK)
            {
                seciliButton.BackColor = seciliKatColor;
                return;
            }
            else if (result == DialogResult.Abort)
            {
                _siparisRepository = new SiparisRepostory();
                silinecekSiparisler = _siparisRepository.Get(new[] { "Masa", "Urun" }, siparis => siparis.MasaId == _frmSiparis.SeciliMasa.Id).ToList();
                MessageBox.Show($"Masa kapatıldı: {silinecekSiparisler.Sum(x => x.AraToplam):c2} Tutar Tahsil edildi.");

                DialogResult pdr = printDialog1.ShowDialog();
                if (pdr == DialogResult.OK)
                {
                    printDocument1.Print();

                    this.DialogResult = DialogResult.OK;
                }

                foreach (var item in silinecekSiparisler)
                {
                    var rapor = new Rapor
                    {
                        UrunAdi = item.Urun.Ad,
                        Adet = item.Adet,
                        Fiyat = item.Fiyat
                    };
                    _raporRepostory.Add(rapor);
                    _siparisRepository.Remove(item);
                }
                seciliButton.BackColor = defaultKatColor;
            }
            _siparisRepository.Update();
            _masaRepostory.Update();
            MasaRenklendir();
            
        }
    }
}
