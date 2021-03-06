//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventarioGerenciamento.Web.Models.DAL
{
    using sun.security.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class usuario
    {
        [Key]
        public int u_Id { get; set; }

        [Display(Name ="Nome do Usuario")]
        [Required(ErrorMessage ="*")]
        public string u_Nome { get; set; }

        [Display(Name = "Usuario Login")]
        [Required(ErrorMessage = "*")]
        public string u_UsuarioNome { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string u_Senha { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "*")]
        public string u_Telefone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "*")]
        public string u_Email { get; set; }


        [Display(Name = "Status do Usuario")]
        [Required(ErrorMessage = "*")]
        public byte u_Status { get; set; }

        [Display(Name = "Fun??o do Usuario")]
        public byte u_funcaoID { get; set; }

        public virtual funcao funcao { get; set; }
    }
}
