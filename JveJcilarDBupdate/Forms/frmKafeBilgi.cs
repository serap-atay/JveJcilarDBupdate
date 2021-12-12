using JveJcilarDBupdate.Models;
using JveJcilarDBupdate.Repostory;
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

namespace JveJcilarDBupdate.Forms
{
    public partial class frmKafeBilgi : Form
    {
        public frmKafeBilgi()
        {
            InitializeComponent();
        }
        private KafeBilgiRepostory kafeBilgiRepostory;
        private void frmKafeBilgi_Load(object sender, EventArgs e)
        {
            kafeBilgiRepostory = new();
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            lstKafeBilgi.DataSource = null;
            lstKafeBilgi.DataSource = kafeBilgiRepostory.Get().ToList();
            lstKafeBilgi.DisplayMember = nameof(KafeBilgi.Ad);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KafeBilgi kafeBilgi = new KafeBilgi()
            {
                Ad = txtKafeAd.Text
            };
            if (pbLogo.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbLogo.Image.Save(resimStream, ImageFormat.Jpeg);

                kafeBilgi.Logo = resimStream.ToArray();
            }
            kafeBilgiRepostory.Add(kafeBilgi);
            ListeyiDoldur();
        }

        private KafeBilgi _seciliKafeBilgi;
        private void lstKafeBilgi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKafeBilgi.SelectedItem == null) return;
            _seciliKafeBilgi = lstKafeBilgi.SelectedItem as KafeBilgi;
            txtKafeAd.Text = _seciliKafeBilgi.Ad;
            if (_seciliKafeBilgi.Logo != null)
            {
                byte[] imageSource = _seciliKafeBilgi.Logo;
                Bitmap image;
                using (MemoryStream stream = new MemoryStream(imageSource))
                {
                    image = new Bitmap(stream);
                }
                pbLogo.Image = image;
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoğraf seçiniz";
            dialog.Filter = "Resim Dosyaları | *.jpeg; *.jpg";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbLogo.ImageLocation = dialog.FileName;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_seciliKafeBilgi == null) return;
            _seciliKafeBilgi.Ad = txtKafeAd.Text;
            if (pbLogo.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                try
                {
                    pbLogo.Image.Save(resimStream, ImageFormat.Jpeg);
                    _seciliKafeBilgi.Logo = resimStream.ToArray();
                }
                catch (Exception)
                {

                }
            }
            kafeBilgiRepostory.Update(_seciliKafeBilgi);
            ListeyiDoldur();
        }
    }
}
