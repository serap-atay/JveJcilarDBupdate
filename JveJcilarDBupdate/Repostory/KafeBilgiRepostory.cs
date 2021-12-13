using JveJcilarDBupdate.Abstracts.Repostory;
using JveJcilarDBupdate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JveJcilarDBupdate.Repostory
{
    public class KafeBilgiRepostory : RepostoryBase<KafeBilgi>
    {
        public override int Save()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Mevcut bir kat varken işletme silinemez.", "İşlem tamamlanamadı.");
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem tamamlanamadı.");
                return -1;
            }
        }
    }
}
