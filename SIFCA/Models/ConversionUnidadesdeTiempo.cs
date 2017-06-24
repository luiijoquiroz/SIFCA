using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Conversion Unidades de Tiempo
    [Table("DTC010")]
    public class ConversionUnidadesdeTiempo
    {
        [Key]
        [Display(Name ="Codigo Coversion de Unidad de Tiempo")]
        public int CODCON { get; set; } // Codigo Conversion  de Unidad de Tiempo

        [Display(Name = "Descripcion de la Conversion")]
        [Required(ErrorMessage ="Usted de ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DESCPR { get; set; } // Descripcion de la Conversion

        [Display(Name = "Codigo de Unidad de Tiempo")]
        [Required(ErrorMessage = "Usted de seleccionar {0}")]
        public int CODUND { get; set; } // Codigo de Unidad de Tiempo

    }
}