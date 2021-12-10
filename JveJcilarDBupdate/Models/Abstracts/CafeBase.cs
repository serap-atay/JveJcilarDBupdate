using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JveJcilarDBupdate.Models.Abstracts
{
    public class CafeBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime EklenmeZamani { get; set; } = DateTime.Now;
    }
}
