using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Periodos Mensuales
    [Table("DTC025")]
    public class PeriodoMensual
    {
        [Key]
        [Display(Name = "Codigo Periodo")]
        public string CODPER { get; set; } // Codigo Periodo

        [Display(Name = "Codigo Ejercicio Fiscal")]
        public int CODEJERC { get; set; } // Codigo Ejercicio Fiscal

        [Display(Name = "Nombre de la empresa")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DESCPR { get; set; } // Descripcion del Ejercicio Fiscal


        [Display(Name = "Fecha de Inicio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FCHINI { get; set; } // Fecha de Inicio

        [Display(Name = "Fecha de Finalizacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FCHFIN { get; set; } // Fecha de Finalizacion

        [Display(Name = "Estatus")]
        public int STATUS { get; set; } // Codigo Estatus


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