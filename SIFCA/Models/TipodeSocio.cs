using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Tipo de Socio
    [Table("DTC002")]
    public class TipodeSocio
    {
        [Key]
        [Display(Name = "Codigo Tipo de Socio")]
        public int TIPSOC { get; set; } // Codigo Tipo de Socio

        [Display(Name = "Descripcion del Tipo de Socio")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        public string DESCPR { get; set; } // Descripcion del Tipo de Socio

    }
}