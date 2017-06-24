using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Cargos
    [Table("DTC014")]
    public class Cargos
    {
        [Key]
        [Display(Name ="Codigo de cargo")]
        public int CODCRG { get; set; } // Codigo de Cargo

        [Display(Name ="Descripcion del cargo ")]
        [StringLength(20,ErrorMessage ="El campo {0} debe tener al entre {2} y caracteres{1}", MinimumLength = 3)]
        [Required(ErrorMessage ="Debe ingresar {0}")]
        public string DESCPR { get; set; } // Descripcion de Cargo

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