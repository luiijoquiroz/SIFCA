using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Patrono
    [Table("DTC007")]
    public class Patrono
    {
        [Key]
        [Display(Name = "Codigo de patrono")]
        public int CODPTR { get; set; } // Codigo de Patrono

        [Display(Name = "Codigo Registro de la institucion")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int REGIDX { get; set; } // Codigo Registro de la Institucion

        [Display(Name = "Nombre de la empresa")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string NOMBRE { get; set; } // Nombre de la Empresa

        [Display(Name = "Horario de Oficina")]
        [Required(ErrorMessage ="Debe Ingresar {0}")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public string HRAOFI { get; set; } // Hora de Oficina 

        [Display(Name = "Codigo de sector")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int CODSEC { get; set; } // Codigo de Sector

        [Display(Name = "Numero RIF")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(15, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string NRORIF { get; set; } // Numero RIF

        [Display(Name = "Codigo de Direccion")]
        [Required(ErrorMessage = "Usted dede selecionar {0}")]
        public int CODDIR { get; set; } // Codigo de Direccion

        [Display(Name = "Sitio Web de la Institucion")]
        public string PAGWEB { get; set; } // Sitio Web de la Institucion

        [Display(Name = "Codigo de Red Social")]
        public int CODRDS { get; set; } // Codigo Red Social

        [Display(Name = "Logotipo")]
        [StringLength(15, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DIRLOG { get; set; } // Logotipo 

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

        //public virtual DatosdelaInstitucion DatosdelaInstitucion { get; set; }



    }
}