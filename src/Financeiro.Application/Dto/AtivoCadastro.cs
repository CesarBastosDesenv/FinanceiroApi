using System.ComponentModel.DataAnnotations;
using System;

namespace Financeiro.Application.Dto;

public class AtivoCadastro
{
    [Required(ErrorMessage = "{0}: É obrigatório")]
    [StringLength(40,ErrorMessage = "{0}: Maximo de 40 caracteres")]
    public string NomeAtivo { get; set; }

    [Required(ErrorMessage = "{0}: É obrigatório")]
    [StringLength(40,ErrorMessage = "{0}: Maximo de 40 caracteres")]
    public string NomeCompleto { get; set; }
}
