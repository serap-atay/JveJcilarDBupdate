using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JveJcilarDBupdate.Models;
using JveJcilarDBupdate.Repostory;

namespace KafeAdisyon.Forms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private KategoriRepostory _kategoriRepo;
        private UrunRepostory _urunRepo;


        private void MenuForm_Load(object sender, EventArgs e)
        {
            _kategoriRepo = new();
            _urunRepo = new();
            KategoriDoldur();
        }
        private void KategoriDoldur()
        {
            lstKategori.DataSource = null;
            lstKategori.DataSource = _kategoriRepo.Get().ToList();
            lstKategori.DisplayMember = nameof(Kategori.Ad);
        }
        private void UrunDoldur()
        {
            lstUrunler.DataSource = null;
            lstUrunler.DataSource = _urunRepo.Get(urun => urun.KategoriId == _seciliKategori.Id).ToList();
            lstUrunler.DisplayMember = nameof(Urun.Ad);
        }
        private Kategori _seciliKategori;
        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;
            _seciliKategori = lstKategori.SelectedItem as Kategori;
            txtKategoriAdi.Text = _seciliKategori.Ad;
            UrunDoldur();
        }
        private Urun _seciliUrun;
        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            _seciliUrun = lstUrunler.SelectedItem as Urun;
            Kategori kategori = _kategoriRepo.GetById(_seciliUrun.KategoriId);
            lstKategori.SelectedItem = kategori;
            //lstKategori.SelectedItem = _seciliUrun.Kategori;
            txtUrunAdi.Text = _seciliUrun.Ad;
            nFiyat.Value = _seciliUrun.Fiyat;
            pbUrun.Image = null;
            if(_seciliUrun.Fotograf != null)
            {
                byte[] imageSource = _seciliUrun.Fotograf;
                Bitmap image;
                using (MemoryStream stream = new MemoryStream(imageSource))
                {
                    image = new Bitmap(stream);
                }
                pbUrun.Image = image;
            }
        }

        private void pbKategori_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoğraf seçiniz";
            dialog.Filter = "Resim Dosyaları | *.jpeg; *.jpg";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbKategori.ImageLocation = dialog.FileName;
            }
        }

        private void pbUrun_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoğraf seçiniz";
            dialog.Filter = "Resim Dosyaları | *.jpeg; *.jpg";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbUrun.ImageLocation = dialog.FileName;
            }
        }

        private void btnKategoriKaydet_Click(object sender, EventArgs e)
        {
            Kategori yeniKategori = new Kategori()
            {
                Ad = txtKategoriAdi.Text
            };
            if (pbKategori.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbKategori.Image.Save(resimStream, ImageFormat.Jpeg);

                yeniKategori.Fotograf = resimStream.ToArray();
            }
            _kategoriRepo.Add(yeniKategori);
            KategoriDoldur();
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            Urun yeniUrun = new Urun()
            {
                Ad = txtUrunAdi.Text,
                Fiyat = nFiyat.Value,
                KategoriId = _seciliKategori.Id
            };
            if (pbUrun.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbUrun.Image.Save(resimStream, ImageFormat.Jpeg);
                yeniUrun.Fotograf = resimStream.ToArray();
            }
            _urunRepo.Add(yeniUrun);
            UrunDoldur();
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (_seciliKategori == null) return;
            _seciliKategori.Ad = txtKategoriAdi.Text;
            if (pbKategori.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbKategori.Image.Save(resimStream, ImageFormat.Jpeg);
                _seciliKategori.Fotograf = resimStream.ToArray();
            }
            _kategoriRepo.Update(_seciliKategori);
            KategoriDoldur();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (_seciliUrun == null) return;
            _seciliUrun.Ad = txtUrunAdi.Text;
            _seciliUrun.Fiyat = nFiyat.Value;
            _seciliUrun.KategoriId = _seciliKategori.Id;
            if (pbUrun.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbUrun.Image.Save(resimStream, ImageFormat.Jpeg);
                _seciliUrun.Fotograf = resimStream.ToArray();
            }
            _urunRepo.Update(_seciliUrun);
            UrunDoldur();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (_seciliUrun == null) return;
            _urunRepo.Remove(_seciliUrun);
            KategoriDoldur();
        }
    }
}
