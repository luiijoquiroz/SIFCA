using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Bancos
    [Table("DTC018")]
    public class Banco
    {
        [Key]
        [Display(Name = "Codigo de Banco")]
        public int CODBCO { get; set; } // Codigo de Banco

        [Display(Name = "Descripcion del Banco")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(40, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DESCPR { get; set; } // Descripcion del Banco

        [Display(Name = "Codigo Cuenta de Banco")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        public string CTABCO { get; set; } // Codigo Cuenta de Banco

        [Display(Name = "Codigo Cuenta Contable ")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        public string CODCTA { get; set; } // Codigo Cuenta Contable 

        [Display(Name = "Direccion Sucursal Bancaria")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(30)]
        public string DIRBCO { get; set; } // Direccion Sucursal

        [Display(Name = "Estatus")]
        public int STATUS { get; set; } // Estatus

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