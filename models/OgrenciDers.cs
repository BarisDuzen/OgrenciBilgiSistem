using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.models
{
    [Table("tOgrenciDers")]
    public class OgrenciDers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int kayitID { get; set; }

        public int ogrenciID { get; set; }
        public int dersID { get; set; }

        [Required(ErrorMessage = "Yıl bilgisi zorunludur")]
        [StringLength(9)] // Örn: 2023-2024
        public string yil { get; set; }

        [Required(ErrorMessage = "Yarıyıl bilgisi zorunludur")]
        [StringLength(10)] // Örn: Güz, Bahar
        public string yariyil { get; set; }

        [Range(0, 100, ErrorMessage = "Vize notu 0-100 arasında olmalıdır")]
        public int? vize { get; set; }

        [Range(0, 100, ErrorMessage = "Final notu 0-100 arasında olmalıdır")]
        public int? final { get; set; }

        [ForeignKey("ogrenciID")]
        public virtual Ogrenci Ogrenci { get; set; }

        [ForeignKey("dersID")]
        public virtual Ders Ders { get; set; }

    }
}
