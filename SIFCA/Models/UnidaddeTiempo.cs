using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SIFCA.Models
{ // Unidades de Tiempo
    [Table("DTC009")]
    public class UnidaddeTiempo
    {
        [Key]
        [Display(Name = "Codigo de Unidad de Tiempo")]
        public int CODUND { get; set; } // Codigo de Unidad de Tiempo

        [Display(Name = "Descripcion de la Unidad de Tiempo")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string DESCPR { get; set; } // Descripcion de la Unidad de Tiempo

        [Display(Name = "Periodo de Tiempo")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string PRIODT { get; set; } // Periodo de Tiempo

        [Display(Name = "Usuario Creador")]
        [ScaffoldColumn(false)]
        public string  USRCRE { get; set; } // Usuario Creador

        [Display(Name = "Fecha de Creacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [ScaffoldColumn(false)]
        public DateTime? FCHCRE { get; set; } // Fecha de Creacion

        [Display(Name = "Usuario Actualizacion")]
        [ScaffoldColumn(false)]
        public string USRACT { get; set; } // Usuario de Actualizacion

        [Display(Name = "Fecha de Actualizacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [ScaffoldColumn(false)]
        public DateTime? FCHACT { get; set; } // Fecha de Actualizacion


        public string CAPTION { get { return DESCPR + " " + PRIODT; } }// Propiedad Solo Lectura

        public virtual ICollection<TipodePrestamos> TiposdePrestamos { get; set; }
        

    }
}