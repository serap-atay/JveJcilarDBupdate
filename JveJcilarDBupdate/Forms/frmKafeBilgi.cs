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
            kafeBilgiRepostory.Add(kafeBilgi);
            ListeyiDoldur();
        }
    }
}
