using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Direcciones
    [Table("DTC011")]
    public class Direcciones
    {
        [Key]
        [Display(Name = "Codigo de Direccion")]
        public int CODDIR { get; set; } // Codigo de Direccion de la Institucion

        [Display(Name ="Direccion #1")]
        [Required(ErrorMessage ="Usted debe ingresar {0}")]
        [StringLength(40, ErrorMessage ="El campo debe {0} tener entre {2} y {1} caracteres", MinimumLength = 10)]
        public string DRCCN1 { get; set; } // Direccion 1

        [Display(Name = "Direccion #2")]
        [StringLength(40, ErrorMessage = "El campo debe {0} tener entre {2} y {1} caracteres", MinimumLength = 10)]
        public string DRCCN2 { get; set; } // Direccion 2

        [Display(Name = "Numero / Piso")]
        [StringLength(10, ErrorMessage = "El campo debe {0} tener entre {2} y {1} caracteres", MinimumLength = 1)]
        public string NUMERO { get; set;  } // Numero / Piso

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Usted debe seleccionar {0}")]
        public int CODEDO { get; set; } // Codigo de Estado

        [Display(Name = "Ciudad")]
        [StringLength(30, ErrorMessage = "El campo debe {0} tener entre {2} y {1} caracteres", MinimumLength = 5)]
        public string CIUDAD { get; set; } // Codigo de Ciudad

        [Display(Name = "Codigo Postal")]
        [StringLength(5, ErrorMessage = "El campo debe {0} tener {1} caracteres")]
        public string CDPSTL { get; set; } // Codigo Postal

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefono Movil")]
        [StringLength(12, ErrorMessage = "El campo debe {0} tener {1} caracteres")]
        public string TELMOV { get; set; } // Telefono Movil

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefono de Habitacion")]
        [StringLength(12, ErrorMessage = "El campo debe {0} tener {1} caracteres")]
        public string TELHAB { get; set; } // Telefono de Habitacion

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefono de Oficina")]
        [StringLength(12, ErrorMessage = "El campo debe {0} tener {1} caracteres")]
        public string TELOFI { get; set; } // Telefono de Oficina

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