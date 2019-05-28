using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Model
{
    [Table("Master_Barang")]
    public class MBarang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int TokoID { get; set; }
        [Column(TypeName ="VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string KdBarang { get; set; }
        [Column(TypeName ="VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string NmBarang { get; set; }
        [Column(TypeName ="VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings =false)]
        public string AslPabrik { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int JmlBarang { get; set; }
        [Required(AllowEmptyStrings =false)]
        public int LmKadaluarsa { get; set; }
    }
}
