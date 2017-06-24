using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Socios Datos Familiares
    [Table("DTC028")]
    public class FamiliarSocio
    {
        [Key]
        public int IDFAM { get; set; } // Codigo del Familiar

        [Display(Name = "Documento Identidad Familiar")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        public int CIFLIA { get; set; } // Cedula de Indentidad del Familiar

        [Display(Name = "Documento Identidad Socio")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        public int CISOC { get; set; } // Cedula de Indentidad del Familiar

        [Display(Name = "Codigo Registro de la Institucion")]
        [Required(ErrorMessage ="Usted debe seleccionar {0}")]
        public int REGIDX { get; set; } // Codigo Registro de la Institucion

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Usted debe ingresar {0}")]
        [StringLength(30,ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres",MinimumLength =3)]
        public string NOMBRE { get; set; } // Nombre del Familiar

        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FHCNAC { get; set; } // Fecha de Nacimiento 

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public char SEXO { get; set; } // Sexo

        [Display(Name = "Parentesco")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(5, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string PRNTSC { get; set; }// Parentesco

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