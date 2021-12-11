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
        Color seciliKatColor = Color.Coral, defaultKatColor = Color.CornflowerBlue;
        private void KafeGorunumForm_Load(object sender, EventArgs e)
        {
            _katRepostory = new KatRepostory();
            _siparisRepository = new SiparisRepostory();
            _masaRepostory = new MasaRepostory();
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
            }
            else if (result == DialogResult.Abort)
            {
                _siparisRepository = new SiparisRepostory();
                var silinecekSiparisler = _siparisRepository.Get(new[] { "Masa", "Urun" }, siparis => siparis.MasaId == _frmSiparis.SeciliMasa.Id).ToList();
                MessageBox.Show($"Masa kapatıldı: {silinecekSiparisler.Sum(x => x.AraToplam):c2} Tutar Tahsil edildi.");
                foreach (var item in silinecekSiparisler)
                {
                    ///////////////////////////////
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
