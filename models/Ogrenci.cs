using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.models
{
    [Table("tOgrenci")]
    public class Ogrenci
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ogrenciID { get; set; }

        [Required(ErrorMessage = "Ad zorunludur")]
        [StringLength(50)]
        public string ad { get; set; }

        [Required(ErrorMessage = "Soyad zorunludur")]
        [StringLength(50)]
        public string soyad { get; set; }

        public int bolumID { get; set; }

        [ForeignKey("bolumID")]
        public virtual Bolum Bolum { get; set; }

        public virtual ICollection<OgrenciDers> OgrenciDersleri { get; set; }

        public Ogrenci()
        {
            OgrenciDersleri = new HashSet<OgrenciDers>();
        }

   
    }
}
