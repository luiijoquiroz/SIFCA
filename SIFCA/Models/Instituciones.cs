using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//NOTA Data Annotations Utiles 
//[Column("NOMINST")]//Cambia Fisicamente el Nombre de la Columna en la Tabla de la BD
//[ForeignKey("Campo")]//Para relacionar campos con nombres diferentes

namespace SIFCA.Models
{   // Datos de la Institucion
    [Table("DTC000")]
    public class Instituciones
    {   [Key]
        [Display(Name = "Codigo Registro de la Institucion")]
        public int REGIDX { get; set; } // Codigo Registro de la Institucion
        
        [Display(Name = "Institución" )]
        [Required(ErrorMessage = "Usted dede ingresar {0}")] //Atributo para Indicar que Sea Obligatorio
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string NOMBRE { get; set; } // Nombre de la Institucion 

        [DataType(DataType.Time)]
        [Display(Name = "Horario de Oficina")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Debe Ingresar {0}")]
        public string HRAOFI { get; set; } // Hora de Oficina

        [Display(Name = "Codigo SUDECA")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        public int SUDECA  { get; set; } // Codigo SUDECA

        [Display(Name = "Sector")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        public int CODSEC  { get; set; } // Codigo Sector

        [Display(Name = "Numero de RIF")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(12, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        public string NRORIF { get; set; } // Numero RIF

        [Display(Name = "Acronimo Institución")]
        [StringLength(12, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        public string ACRNIM  { get; set; } // Acronimo de la Institucion 

        [Display(Name = "Codigo Dirección Institución")]
        public int CODDIR{ get; set; } // Codigo de Direccion de la Institucion

        [Display(Name = "Codigo Red Social")]
        public int CODRDS{ get; set; } // Codigo de Red Social 

        [Display(Name = "Logotipo")]
        public string DIRLOG { get; set; } // Logotipo 

        [Display(Name = "URL de la Institucion")]
        public string PAGWEB { get; set; } // URL de la Institucion

        //public virtual ICollection<Patrono> Patrono { get; set; }

    }
}