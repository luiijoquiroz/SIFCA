using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Metodos de Pago  por Banco
    [Table("DTC021")]
    public class MetododePagoporBanco
    {
        [Key]
        [Display(Name = "Codigo de Metodo de Pago")]
        public int CODMTD { get; set; } // Codigo de Metodo de Pago

        [Display(Name = "Codigo  de Banco")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int CODBCO { get; set; } // Codigo  de Banco

        [Display(Name = "Codigo de Concepto Contable")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        public string CPTOCTB { get; set; } // Codigo de Concepto Contable

        [Display(Name = "Codigo de Concepto Contable")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        public string CODCTA { get; set; } // Codigo Cuenta Contable 

        [Display(Name = "Usuario Creador")]
        [ScaffoldColumn(false)]
        public int USRCRE { get; set; } // Usuario Creador

        [Display(Name = "Fecha de Creacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [ScaffoldColumn(false)]
        public DateTime FCHCRE { get; set; } // Fecha de Creacion

        [Display(Name = "Usuario Actualizacion")]
        [ScaffoldColumn(false)]
        public int USRACT { get; set; } // Usuario de Actualizacion

        [Display(Name = "Fecha de Actualizacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [ScaffoldColumn(false)]
        public DateTime FCHACT { get; set; } // Fecha de Actualizacion
    }
}