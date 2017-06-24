using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Estados
    [Table("DTC012")]
    public class Estados
    {
        [Key]
        [Display(Name ="Codigo de Estado")]
        public int CODEDO { get; set; } // Codigo de Estado

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(15, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 5)]
        public string DESCPR { get; set; } // Descripcion del Estado

    }
}