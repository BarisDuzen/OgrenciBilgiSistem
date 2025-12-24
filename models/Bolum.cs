using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.models
{
    [Table("tBolum")]
    public class Bolum
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bolumID { get; set; }

        [Required(ErrorMessage = "Bölüm adı zorunludur")]
        [StringLength(100)]
        public string bolumAd { get; set; }

        public int fakulteID { get; set; }

        [ForeignKey("fakulteID")]
        public virtual Fakulte Fakulte { get; set; }

     
        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }

        public Bolum()
        {
            Ogrenciler = new HashSet<Ogrenci>();
        }
    }
}
