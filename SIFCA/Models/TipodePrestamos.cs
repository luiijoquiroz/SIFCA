using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   // TIPO DE PRESTAMOS
    [Table("DTC001")]
    public class TipodePrestamos
    {
        [Key]
        [Display(Name = "Codigo Tipo de Prestamo")]
        public int CODTIP  { get; set; } // Codigo Tipo de Prestamo

        [Display(Name = "Descripcion del Prestamo")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        public string DESCPR  { get; set; } // Descripcion del Prestamo

        [Display(Name = "Tasa de Interes")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public float TSAPMO  { get; set; } // Tasa de Interes

        [Display(Name = "Codigo Cantidad de Tiempo / Plazo")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        public int CANTMP  { get; set; } // Codigo Cantidad de Tiempo / Plazo

        [Display(Name = "Unidad de Tiempo")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int CODUND { get; set; } // Codigo de Unidad de Tiempo

        [Display(Name = "Cuenta Contable de Prestamo")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        public int      CTAPMO  { get; set; } // Cuenta Contable de Prestamo

        [Display(Name = "Cuenta Contable de Interes")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        public int      CTAINT  { get; set; } // Cuenta Contable de Interes

        [Display(Name = "Usuario Creador")]
        [ScaffoldColumn(false)]
        public string USRCRE { get; set; } // Usuario Creador

        [Display(Name = "Fecha de Creacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [ScaffoldColumn(false)]
        public DateTime FCHCRE { get; set; } // Fecha de Creacion

        [Display(Name = "Usuario Actualizacion")]
        [ScaffoldColumn(false)]
        public string USRACT { get; set; } // Usuario de Actualizacion

        [Display(Name = "Fecha de Actualizacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [ScaffoldColumn(false)]
        public DateTime FCHACT { get; set; } // Fecha de Actualizacion

        [Display(Name = "Estatus")]
        public int      STATUS  { get; set; } // Estatus

        public virtual UnidaddeTiempo UnidaddeTiempos { get; set; }

    }
}