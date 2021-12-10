using JveJcilarDBupdate.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JveJcilarDBupdate.Models
{
    [Table("Urunler")]
    public class Urun : CafeBase 
    {
        [StringLength(25)]
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public byte[] Fotograf { get; set; }
        public int KategoriId { get; set; }

        [ForeignKey(nameof(KategoriId))]
        public Kategori Kategori { get; set; }
    }
}
