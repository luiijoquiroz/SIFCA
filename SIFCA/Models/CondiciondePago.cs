using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Condiciones de Pago
    [Table("DTC020")]
    public class CondiciondePago
    {
        [Key]
        [Display(Name = "Codigo Condicion de Pago")]
        public int CODCDP { get; set; } // Codigo Condicion de Pago

        [Display(Name = "Descripcion Condicion de Pago")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DESCPR { get; set; } // Descripcion Condicion de Pago

        [Display(Name = "Periodo de Pago")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string PRDOPG { get; set; } // Periodo de Pago

        [Display(Name = "Porcentaje de Descuento")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        public int DESCTO { get; set; } // Porcentaje de Descuento

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