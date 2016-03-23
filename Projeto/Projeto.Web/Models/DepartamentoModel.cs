using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Web.Models
{
    public class DepartamentoViewModelCadastro
    {
        [Display(Name = "Nome do Departamento")]
        [Required(ErrorMessage = "Nome do Departamento Obrigatorio")]
        public string Nome { get; set; }

    }
}