using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{
    //Socios Datos Personales
    [Table("DTC026")]
    public class PersonalesSocio
    {
        [Key]
        [Display(Name = "Codigo del Socio")]
        public int IDSOC { get; set; } // Codigo del Socio

        [Display(Name = "Cedula de Indentidad")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        public int CISOC { get; set; } // Cedula de Indentidad del Socio

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string APLLDO { get; set; } // Apellido

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string NOMBRE { get; set; } // Nombre 

        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FHCNAC { get; set; } // Fecha de Nacimiento 

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public char SEXO { get; set; } // Sexo

        [Display(Name = "Estado Civil")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int EDOCVL { get; set; } // Estado Civil

        [Display(Name = "Direccion del Socio")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int CODDIR { get; set; } // Codigo de Direccion del Socio

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