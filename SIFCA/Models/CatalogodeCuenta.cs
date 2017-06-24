using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Catalogo de Cuentas
    [Table("DTC022")]
    public class CatalogodeCuenta
    {
        [Key]
        [Display(Name = "Codigo Cuenta de Banco")]
        public int CTABCO { get; set; } // Codigo Cuenta de Banco

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")] 
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DESCPR { get; set; } // Descripcion 

        [Display(Name = "Sunivel de la Cuenta")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")] 
        [StringLength(10, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string SUBNVL { get; set; } // Sunivel de la Cuenta

        [Display(Name = "Tipo de Cuenta")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")] 
        [StringLength(10, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string TIPCTA { get; set; }// Tipo de Cuenta

        [Display(Name = "Indicador Debe/ Haber")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")] //Atributo para Indicar que Sea Obligatorio
        public int INDCDH { get; set; } // Indicador Debe/ Haber


    }
}