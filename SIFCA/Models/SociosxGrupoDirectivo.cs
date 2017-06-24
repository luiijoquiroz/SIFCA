using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIFCA.Models
{   //Socios x Grupo Directivo
    [Table("DTC006")]
    public class SociosxGrupoDirectivo
    {
        [Key]
        [Display(Name = "Codigo de Grupo de Directivos")]
        public int CDRLGR { get; set; } // Codigo de Rol X Grupo Directivo

        [Display(Name = "Codigo de Grupo de Directivos")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int CODGRP { get; set; } // Codigo Grupo Directivo

        [Display(Name = "Codigo de Grupo de Directivos")]
        [Required(ErrorMessage = "Usted dede seleccionar {0}")]
        public int CODSCO { get; set; } // Codigo de Socio

        [Display(Name = "Vigencia")]
        public int VGNCIA { get; set; } // Vigencia

        [Display(Name = "Referencia")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string REFRNC { get; set; } // Referencia

        [Display(Name = "Usuario Creador")]
        public int USRCRE { get; set; } // Usuario Creador

        [Display(Name = "Fecha de Creacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FCHCRE { get; set; } // Fecha de Creacion

        [Display(Name = "Usuario Actualizacion")]
        public int USRACT { get; set; } // Usuario de Actualizacion

        [Display(Name = "Fecha de Actualizacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FCHACT { get; set; } // Fecha de Actualizacion

    }
}