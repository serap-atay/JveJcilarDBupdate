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
    [Table("Kategoriler")]
    public class Kategori : CafeBase
    {
        [StringLength(25)]
        public string Ad { get; set; }
        [StringLength(200)]
        public string Aciklama { get; set; }
        public byte[] Fotograf { get; set; }
     
        public ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
