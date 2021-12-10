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
    [Table("Masalar")]
    public class Masa : CafeBase
    {
        [StringLength(11)]
        public string Ad { get; set; }
        public int Sira { get; set; }
        public bool MasaDurumu { get; set; }
        public int KatId { get; set; }

        [ForeignKey(nameof(KatId))]
        public Kat Kat { get; set; }
    }
}
