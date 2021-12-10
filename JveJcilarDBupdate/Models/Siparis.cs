using JveJcilarDBupdate.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JveJcilarDBupdate.Models
{
    [Table("Siparisler")]
    public class Siparis : CafeBase
    {
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal AraToplam { get => Adet * Fiyat; }
        public int MasaId { get; set; }
        public int UrunId { get; set; }

        [ForeignKey(nameof(MasaId))]
        public Masa Masa { get; set; }
        [ForeignKey(nameof(UrunId))]
        public Urun Urun { get; set; }
    }
}
