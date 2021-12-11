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
    public partial class frmGunlukRapor : Form
    {
        public frmGunlukRapor()
        {
            InitializeComponent();
        }
        private RaporRepostory _raporRepostory;
        private void btnGunlukRapor_Click(object sender, EventArgs e)
        {
            _raporRepostory = new RaporRepostory();
            var allData = _raporRepostory.Get();
            var queryGunlukRapor = allData
                .Where(a => a.EklenmeZamani.Date.Day == DateTime.Now.Day && a.EklenmeZamani.Month == DateTime.Now.Month)
                .GroupBy(a => new
                {
                    a.UrunAdi
                })
                .Select(a => new
                {
                    a.Key.UrunAdi,
                    Adet = a.Sum(p => p.Adet),
                    Toplam = a.Sum(p => p.Adet * p.Fiyat)
                })
                .ToList();
            dgvGunlukRapor.DataSource = queryGunlukRapor;
        }
    }
}
