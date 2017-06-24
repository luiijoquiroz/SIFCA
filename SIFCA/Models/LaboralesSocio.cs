using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Socios Datos Laborales
    [Table("DTC027")]
    public class LaboralesSocio
    {   [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Documento Identidad")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")] 
        public int CISOC { get; set; } // Cedula de Indentidad del Socio

        [Display(Name = "Codigo de Nomina")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int CODNOM { get; set; } // Codigo de Nomina

        [Display(Name = "Codigo Dependencia")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int CODDEP { get; set; } // Codigo Dependencia

        [Display(Name = "Codigo de cargo")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int CODCRG { get; set; } // Codigo de Cargo

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Ingreso a la Empresa")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}", ApplyFormatInEditMode = true)]
        public DateTime FINEMP { get; set; } // Fecha de Ingreso a la Empresa

        [Display(Name = "Fecha de Ingreso a la Caja de Ahorro")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FINCAH { get; set; } // Fecha de Ingreso a la Caja de Ahorro
        
        [DataType(DataType.Currency)]
        [Display(Name = "Sueldo")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal SUELDO { get; set; } // Sueldo / Salario

        [DataType(DataType.Currency)]
        [Display(Name = "Aporte a la caja de ahorro")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal APRTCA { get; set; } // Aporte a la caja de ahorro

        [Display(Name = "Codigo Tipo de Socio")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int TIPSOC { get; set; } // Codigo Tipo de Socio

        [Display(Name = "Codigo de Banco")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int CODBCO { get; set; } // Codigo de Banco

        [Display(Name = "Codigo Cuenta de Banco")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        public string CTABCO { get; set; } // Codigo Cuenta de Banco

        [Display(Name = "Estatus")]
        public int STATUS { get; set; } // Estatus

        [Display(Name = "Codigo Dirección Institución")]
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