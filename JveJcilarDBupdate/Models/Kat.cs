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
    [Table("Katlar")]
    public class Kat : CafeBase
    {

        [StringLength(11)]
        public string Ad { get; set; }
        public int? KafeBilgiId { get; set; }
        public int Sira { get; set; }
        [StringLength(11)]
        public string Kod { get; set; }

        [ForeignKey(nameof(KafeBilgiId))]
        public KafeBilgi KafeBilgi { get; set; }
        public ICollection<Masa> Masalar { get; set; } = new HashSet<Masa>();
    }
}
