using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Conceptos de Nomina
    [Table("DTC023")]
    public class Nomina
    {
        [Key]
        [Display(Name = "Codigo de Nomina")]
        public int CODNOM { get; set; } // Codigo de Nomina

        [Display(Name = "Descripcion del Tipo de Socio")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DESCPR { get; set; } // Descripcion Codigo de Nomina

        [Display(Name = "Tipo de Movimiento")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(15, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string TIPMVTO { get; set; } // Tipo de Movimiento
    }
}