using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Roles por Grupo Directivo
    [Table("DTC005")]
    public class RolesporGrupoDirectivo
    {
        [Key]
        [Display(Name = "Codigo de Rol X Grupo Directivo")]
        public int CDRLGR    { get; set; } // Codigo de Rol X Grupo Directivo

        [Display(Name = "Codigo Grupo Directivo")]
        [Required(ErrorMessage = "Usted dede seleccionar un {0}")]
        public int CODGRP    { get; set; } // Codigo Grupo Directivo

        [Display(Name = "Codigo de Rol")]
        [Required(ErrorMessage = "Usted dede seleccionar un {0}")]
        public int CODROL    { get; set; } // Codigo del Rol

        [Display(Name = "Descripcion del Grupo de Direcctivos")]
        [Required(ErrorMessage = "Usted dede ingresar {0}")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string REFRNC { get; set; } // Referencia

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

        //public virtual DTC004 DTC004 { get; set; }


    }
}