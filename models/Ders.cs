using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.models
{
    [Table("tDers")]
    public class Ders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int dersID { get; set; }

        [Required(ErrorMessage = "Ders adı zorunludur")]
        [StringLength(100)]
        public string dersAd { get; set; }
        public virtual ICollection<OgrenciDers> OgrenciDersleri { get; set; }

        public Ders()
        {
            OgrenciDersleri = new HashSet<OgrenciDers>();
        }
    }
}
