using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Contactos
    [Table("DTC013")]
    public class Contacto
    {   [Key]
        [Display(Name = "Codigo Conctacto")]
        public int CODCNT { get; set; }//Codigo Contacto

        [Display(Name = "Tratamiento")]
        [StringLength(35, ErrorMessage = "El campo debe {0} tener entre {1} y {0} caracteres", MinimumLength =6)]
        public string TRTMNT{get; set;}//Tratamientos

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string APLLDO { get; set; } // Apellido

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string NOMBRE { get; set; } // Nombre 

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

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Correo Electronico")]
        [StringLength(45, ErrorMessage = "El campo debe {0} tener entre {1} y {1} caracteres", MinimumLength =5)]
        public string DIRCOR { get; set; } // Telefono de Oficina

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