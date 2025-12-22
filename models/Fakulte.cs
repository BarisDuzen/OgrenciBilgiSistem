using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.models
{
    [Table("tFakulte")]
    public class Fakulte
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fakulteID { get; set; }

        [Required(ErrorMessage = "Fakülte adı zorunludur")]
        [StringLength(100)]
        public string fakulteAd { get; set; }

        // İlişki: Bir fakültede birden fazla bölüm olur
        public virtual ICollection<Bolum> Bolumler { get; set; }

        public Fakulte()
        {
            Bolumler = new HashSet<Bolum>();
        }
    }
}
