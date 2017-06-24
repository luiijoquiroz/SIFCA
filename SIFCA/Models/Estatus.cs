using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Estatus
    [Table("DTC030")]
    public class Estatus
    {
        [Key]
        [Display(Name = "Codigo Estatus")]
        public int STATUS { get; set; } // Codigo Estatus

        [Display(Name = "Estatus")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(15, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DESCPR { get; set; } // Descripcion del Estatus
    }
}