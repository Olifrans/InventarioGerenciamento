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
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class categorias
    {
        [Key]
        public byte cat_Id { get; set; }

        [Display(Name = "Nome da Categoria")]
        [Required(ErrorMessage = "*")]
        public string cat_Nome { get; set; }

        [Display(Name = "Status da Categoria")]
        [Required(ErrorMessage = "*")]
        public byte cat_Status { get; set; }
    }
}
