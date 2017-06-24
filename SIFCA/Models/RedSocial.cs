using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Redes Sociales
    [Table("DTC029")]
    public class RedesSocial
    {
        [Key]
        [Display(Name = "Codigo Red Social")]
        public int CODRDS { get; set; } // Codigo Red Social

        [Display(Name = "Red Social")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(15, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DESCPR { get; set; } // Descripcion Red Social

    }
}