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
    [Table("KafeBilgileri")]
    public class KafeBilgi : CafeBase
    {
        [Required()]
        [StringLength(50)]
        public string Ad { get; set; }
        public byte[] Logo { get; set; }
  
        public ICollection<Kat> Katlar { get; set; } = new HashSet<Kat>();
    }
}
